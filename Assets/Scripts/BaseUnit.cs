using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public class BaseUnit : BaseObject
    {
        protected bool _isPossibleToHit;
        [SerializeField]
        protected int _currentStaminaCosts;
        [SerializeField]
        protected int _maxForce;
        [SerializeField]
        protected int _force;
        protected UnitEnvironment _unitEnvironment;
        [SerializeField]
        protected Collider2D _weapon;
        private InteractionComponent _interactionComponent;
        [SerializeField]
        protected int _minDamage;
        [SerializeField]
        protected int _maxDamage;
        protected int _armorClass;
        [SerializeField]
        protected int _maxStamina;
        [SerializeField]
        protected int _stamina;

        [SerializeField]
        protected UnitType _unitType;

        [SerializeField]
        protected int _strength;
        [SerializeField]
        protected int _dextrity;
        [SerializeField]
        protected int _concentration;
        [SerializeField]
        protected int _intelligence;

        [SerializeField]
        private int XP;

        public int GetStrength => _strength;
        public int GetDextrity => _dextrity;
        public int GetConcentration => _concentration;
        public int GetIntelligence => _intelligence;
        public int GetXP => XP;
        public int GetMinDamage => _minDamage;
        public int GetMaxDamage => _maxDamage;
        public int GetArmorClass => _armorClass;
        public int GetStamina => _stamina;
        public int GetMaxStamina => _maxStamina;

        private void Start()
        {
            _interactionComponent = GetComponent<InteractionComponent>();
        }
        public void EndOfStrike_UnityEditor()
        {
            _isPossibleToHit = true;
        }
        public void ActivateWeapon_UnityEditor()
        {
            _weapon.enabled = true;
        }
        public void DeactivateWeapon_UnityEditor()
        {
            _weapon.enabled = false;
        }
        public void SetDamage(int Damage, BasePlayerComponent Player)
        {
            _health = _health - Damage;
            if (_health <= 0)
            {
                Player.AddExpirience(XP);
                Player.RemoveFromListInteractions(_interactionComponent);
                DestroyObject();
            }
        }


        protected void SetArmorClass (int armor, int dextrity, int headArmor)
        {
            if (((dextrity - 10) / 2) > 3)
            {
                _armorClass =10+ armor + 3 + headArmor;
            }
            else
            {
                _armorClass =10+ armor + ((dextrity - 10) / 2) + headArmor;
            }
        }

        private IEnumerator StaminaRecovery()
        {
            while (true)
            {
                if (_stamina < _maxStamina)
                {
                    _stamina += 1;
                }
                yield return new WaitForSeconds(1);
            }

        }
        private IEnumerator HealthRecovery()
        {
            while (true)
            {
                if (_health < _maxHealth)
                {
                    _health += 1;
                }
                yield return new WaitForSeconds(1);
            }

        }
    }
}