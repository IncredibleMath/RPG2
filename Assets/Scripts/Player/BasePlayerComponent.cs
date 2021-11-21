using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public class BasePlayerComponent : BaseUnit
    {

        private PlayerControls Controls;
        private Rigidbody2D _rigidbody;
        [SerializeField]
        private float _forceModifier = 100;
        private Animator _animator;

        private Camera _camera;
        private bool _battleMod;
        private bool _inventoryMod;
        private bool _pauseMod;
        [SerializeField]
        private GameObject InventoryPanel;
        [SerializeField]
        private GameObject PausePanel;
        [SerializeField]
        private GameObject TreasurePanel;
        [SerializeField]
        private GameObject PressE;
        [SerializeField]
        private GameObject TalkPanel;

        private InventoryOperator _inventoryOperator;

        private int _headArmor;
        private int _level;
        public int GetLevel => _level;
        private int _skillPoints;
        private int _expirience;
        private List<InteractionComponent> Interactions = new List<InteractionComponent>();
        private Dictionary<int, int> _levelUps = new Dictionary<int, int>()
        {
            {1,0},
            {2,1000},
            {3,3000},
            {4,9000},
            {5,15000}
        };

        [SerializeField]
        private InventoryCharacteristics_UI InventoryCharacteristics_UI;
        [SerializeField]
        private InterfaceVisualisation_UI InterfaceVisualisation_UI;
        private PlayerEquipment _playerEquipment;
        private GameManager GameManager;
        #region Main
        private void Start()
        {
            _level = 0;
            _skillPoints = 3;
            LvlUp();
            _battleMod = false;
            _pauseMod = false;
            _currentStaminaCosts = 10;
            _camera = Camera.main;
            _unitEnvironment = GetComponent<UnitEnvironment>();
            _animator = GetComponent<Animator>();
            Controls = new PlayerControls();
            Controls.Enable();
            _rigidbody = GetComponent<Rigidbody2D>();
            _inventoryOperator = FindObjectOfType<InventoryOperator>();
            _playerEquipment = GetComponent<PlayerEquipment>();

            _isPossibleToHit = true;
            StartCoroutine(PlayerHealthRecovery());
            StartCoroutine(PlayerStaminaRecovery());

            GameManager = FindObjectOfType<GameManager>();
            Controls.Moving.BattleState.performed += BattleState_performed;
            Controls.Moving.Inventory.performed += Inventory_performed;
            Controls.Moving.Pause.performed += Pause_performed;
            InventoryCharacteristics_UI.ChangeStrenghText(_strength);
            InventoryCharacteristics_UI.ChangeDextrityText(_dextrity);
            InventoryCharacteristics_UI.ChangeConsentrationText(_concentration);
            InventoryCharacteristics_UI.ChangeIntelligenseText(_intelligence);
        }
        private void Update()
        {
            if (Controls.Moving.Move.ReadValue<Vector2>().magnitude > 0)
            {
                Move();
                _unitEnvironment.Moving(true);
            }
            else
            {
                _unitEnvironment.Moving(false);
            }

            Rotate();
        }
        public void OnManagement ()
        {
            Controls.Enable();
        }
        public void OffManagement ()
        {
            Controls.Disable();
        }
        public void SetPlayerDamage(int Damage)
        {
            _health = _health - Damage;
            InterfaceVisualisation_UI.ChangeHealth();
            if (_health<=0)
            {
                GameManager.GameOver();
            }
        }
        #endregion
        #region BUTTONS
        private void Inventory_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {

            if (_inventoryMod)
            {
                if(Interactions.Count>0)
                {
                    if (Interactions[0].GetInteractActive)
                    {
                        Interactions[0].Interact();
                    }
                    else
                    {
                        OffTreasurePanel();
                        _inventoryOperator.Back_UnityEditor();
                    }
                }
                else
                {
                    OffTreasurePanel();
                    _inventoryOperator.Back_UnityEditor();
                }
            }
            else
            {
                InventoryPanel.SetActive(true);
                _inventoryMod = true;
            }
        }
        

        private void BattleState_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (!_battleMod)
            {
                _animator.SetBool("BattleMod", true);//
                _battleMod = true;//
                Controls.Battle.Attack.performed += Attack_performed;//
                OffTreasurePanel(); //NONONONO
                _inventoryOperator.Back_UnityEditor();
                Controls.Moving.Inventory.performed -= Inventory_performed;
                PressE.SetActive(false);
            }
            else
            {
                _animator.SetBool("BattleMod", false);
                _battleMod = false;
                Controls.Battle.Attack.performed -= Attack_performed;
                Controls.Moving.Inventory.performed += Inventory_performed;
            }
        }

        private void Attack_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (_isPossibleToHit && _stamina>_currentStaminaCosts)
            {
                _stamina = _stamina - _currentStaminaCosts;
                InterfaceVisualisation_UI.ChangeStamina();
                _isPossibleToHit = false;
                _animator.SetTrigger("Attack");
            }
        }

        private void Use_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (!_battleMod)
            {
                _animator.SetTrigger("OnUse");
                Interactions[0].Interact();
            }
        }

        private void Pause_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (_pauseMod)
            {
                Controls.Enable();
                Time.timeScale = 1;
                _pauseMod = false;
                PausePanel.SetActive(false);
            }
            else
            {
                Controls.Disable();
                _pauseMod = true;
                PausePanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
#endregion
#region MoveAndRotate
        private void Move()
        {
            var move = Controls.Moving.Move.ReadValue<Vector2>() *Time.deltaTime * _forceModifier + (Vector2)transform.position;
            _rigidbody.MovePosition(move);
            if (!(_animator.GetCurrentAnimatorStateInfo(0).IsName("Walk") || _animator.GetCurrentAnimatorStateInfo(0).IsName("EspadaRapera_Medium_Walk")))
            {
                if (!_battleMod)
                {
                    _animator.Play("Walk");
                }
            }
            _camera.transform.position = new Vector3(transform.position.x, transform.position.y, -2.88f);
        }

        private void Rotate ()
        {
            var mousePos = Camera.main.ScreenToWorldPoint(Controls.Moving.MousePosition.ReadValue<Vector2>());
            Vector3 t = new Vector3 (mousePos.x, mousePos.y, 0)-transform.position;
            float rotateZ = Mathf.Atan2(t.y, t.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotateZ-90);
        }
        #endregion
#region Expirience
        public void AddExpirience (int Exp)
        {
            _expirience += Exp;
            Debug.Log("Получено опыта " + Exp);
            if (_expirience>=_levelUps[_level+1])
            {
                LvlUp();
            }
            InventoryCharacteristics_UI.ChangeExpText(_levelUps[_level + 1], _expirience);
        }
        private void LvlUp ()
        {
            _level++;
            if (_level != 1)
            {
                _skillPoints += 2;
                InventoryCharacteristics_UI.LvlUp_buttonsOn();
            }
            InventoryCharacteristics_UI.ChangeLevelText(_level, _skillPoints);
        }
        public void AddOneToCharacteristic(Characteristics Char)
        {
            _skillPoints--;
            if (Char == Characteristics.Strength)
            {
                _strength++;
                InventoryCharacteristics_UI.ChangeStrenghText(_strength);
                InventoryCharacteristics_UI.ChangeDamageText(_minDamage,_maxDamage,_strength);
            }
            else if (Char == Characteristics.Dextrity)
            {
                _dextrity++;
                SetArmorClass(_armor, _dextrity, _headArmor);
                InventoryCharacteristics_UI.ChangeDextrityText(_dextrity);
                InventoryCharacteristics_UI.ChangeAttackAdvantageClassText(_dextrity, _level);
                InventoryCharacteristics_UI.ChangeArmorClassText(_armorClass);
            }
            else if (Char == Characteristics.Concentration)
            {
                _concentration++;
                InventoryCharacteristics_UI.ChangeConsentrationText(_concentration);
            }
            else
            {
                _intelligence++;
                InventoryCharacteristics_UI.ChangeIntelligenseText(_intelligence);
            }

            if (_skillPoints<=0)
            {
                InventoryCharacteristics_UI.LvlUp_buttonsOff();
            }
            InventoryCharacteristics_UI.ChangeLevelText(_level, _skillPoints);
        }
        #endregion
#region Interactions
        public void AddToListInteractions(InteractionComponent component)
        {
            if (!_battleMod)
            {
                Interactions.Add(component);

                if (Interactions.Count == 1)
                {
                    PressE.SetActive(true);
                    Controls.Moving.Use.performed += Use_performed;
                }
            }

        }
        public void RemoveFromListInteractions(InteractionComponent component)
        {
            Interactions.Remove(component);
            if (Interactions.Count == 0)
            {
                PressE.SetActive(false);
                Controls.Moving.Use.performed -= Use_performed;
            }
        }
        public void OnTreasurePanel()
        {
            if (_inventoryMod)
            {
                TreasurePanel.SetActive(true);
            }
            else
            {
                InventoryPanel.SetActive(true);
                TreasurePanel.SetActive(true);
                _inventoryMod = true;
            }

        }
        public void OffTreasurePanel()
        {
            if (_inventoryMod)
            {
                TreasurePanel.SetActive(false);
                InventoryPanel.SetActive(false);
                _inventoryMod = false;
            }
        }

        public void OnTalkPanel()
        {
            TalkPanel.SetActive(true);
            Time.timeScale = 0;
            OffManagement();
        }
        public void OffTalkPanel()
        {
            OnManagement();
            Time.timeScale = 1;
            TalkPanel.SetActive(false);
        }
        #endregion
#region Equipment
        public void UpdateHeaddress(int ArmorClass)
        {
            _headArmor = ArmorClass;
            SetArmorClass(_armor, _dextrity, _headArmor);
            InventoryCharacteristics_UI.ChangeArmorClassText(_armorClass);
        }
        public void UpdateArmor(int ArmorClass)
        {
            _armor = ArmorClass;
            SetArmorClass(_armor, _dextrity, _headArmor);
            InventoryCharacteristics_UI.ChangeArmorClassText(_armorClass);
        }
        public void UpdateWeapon(int MinDam, int MaxDam)
        {
            _minDamage = MinDam ;
            _maxDamage = MaxDam ; //НА ОДИН БОЛЬШЕ ЧЕМ НАДО!!!
            InventoryCharacteristics_UI.ChangeDamageText(_minDamage, _maxDamage, _strength);
        }
        public void UpdateSecondWeapon()
        {

        }
        #endregion

        protected IEnumerator PlayerStaminaRecovery()
        {
            while (true)
            {
                if (_stamina < _maxStamina)
                {
                    _stamina += 1;
                    InterfaceVisualisation_UI.ChangeStamina();
                }
                yield return new WaitForSeconds(1);
            }

        }
        protected IEnumerator PlayerHealthRecovery()
        {
            while (true)
            {
                if (_health < _maxHealth)
                {
                    _health += 1;
                    InterfaceVisualisation_UI.ChangeHealth();
                }
                yield return new WaitForSeconds(5);
            }

        }
    }
}