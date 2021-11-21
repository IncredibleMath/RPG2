using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public class InteractionComponent : MonoBehaviour
    {
        [SerializeField]
        private InteractionsType _interactionsType;
        private InventoryManager _inventoryManager;
        private InventoryComponent _inventoryComponent;
        private InventoryOperator _inventoryOperator;
        private BasePlayerComponent _player;
        private bool _interactActive;
        [SerializeField]
        private Transform _pool;


        public bool GetInteractActive => _interactActive;
        public void SetInteractActive(bool Bool)
        {
            _interactActive = Bool;
        }
        private int CurrentNode = 0;
        [SerializeField]
        private TextAsset xml;
        [SerializeField]
        private DialogueManager dialogueManager;


        private void Start()
        {
            if (_interactionsType == InteractionsType.Search || _interactionsType == InteractionsType.Trade)
            {
                _inventoryComponent = GetComponent<InventoryComponent>();
                _inventoryOperator = FindObjectOfType<InventoryOperator>();
                _inventoryManager = FindObjectOfType<InventoryManager>();
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            var playerBody = collision.GetComponent<BodyCharacterComponent>();
            if (playerBody == null) return;
            _player = playerBody.GetParent;
            if (_player != null)
            {
                _interactActive = false;
                _player.AddToListInteractions(this);
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            var playerBody = collision.GetComponent<BodyCharacterComponent>();
            if (playerBody == null) return;
            _player = playerBody.GetParent;
            if (_player != null)
            {
                if (_interactActive == true)
                {
                    Interact();
                }
                _player.RemoveFromListInteractions(this);
                _player = null;
            }
        }

        public void Interact()
        {
            if (_interactActive)
            {
                if (_interactionsType == InteractionsType.Open)
                {

                }
                else if (_interactionsType == InteractionsType.Search)
                {
                    SearchOff();
                }
                else if (_interactionsType == InteractionsType.Talk)
                {
                    TalkOff();
                }
                else if (_interactionsType == InteractionsType.Trade)
                {
                    TradeOff();
                }
                else
                {
                    Debug.LogError("_interactionsType не имеет значения");
                }
            }
            else
            {
                if (_interactionsType == InteractionsType.Open)
                {

                }
                else if (_interactionsType == InteractionsType.Search)
                {
                    SearchOn();
                }
                else if (_interactionsType == InteractionsType.Talk)
                {
                    TalkOn();
                }
                else if (_interactionsType == InteractionsType.Trade)
                {
                    TradeOn(); //ИЗМЕНИТЬ СЕРЧОФФ
                }
                else
                {
                    Debug.LogError("_interactionsType не имеет значения");
                }
            }

        }

        private void SearchOn()
        {

            _inventoryManager.PutToOtherSlots(_inventoryComponent);
            _inventoryManager.SetInteraction(InventoryInteractionType.Search);
            _player.OnTreasurePanel();
            _interactActive = true;
        }
        private void SearchOff()
        {
            _inventoryManager.ReturnFromOtherSlots(_inventoryComponent, _pool);
            _inventoryManager.SetInteraction(InventoryInteractionType.Inventory);
            _player.OffTreasurePanel();
            _interactActive = false;
            _inventoryOperator.Back_UnityEditor();
        }
        private void TradeOn()
        {
            _inventoryManager.PutToOtherSlots(_inventoryComponent);
            _inventoryManager.SetInteraction(InventoryInteractionType.Trade);
            _player.OnTreasurePanel();
            _interactActive = true;
        }
        private void TradeOff()
        {
            _inventoryManager.ReturnFromOtherSlots(_inventoryComponent, _pool);
            _inventoryManager.SetInteraction(InventoryInteractionType.Inventory);
            _player.OffTreasurePanel();
            _interactActive = false;
            _inventoryOperator.Back_UnityEditor();
        }
        private void TalkOn ()
        {
            _player.OnTalkPanel();
            dialogueManager.InitializeDialogue(xml, CurrentNode, this);

        }
        private void TalkOff()
        {
            _player.OffTalkPanel();
        }

        public void BackNode (int numberOfNode)
        {
            CurrentNode = numberOfNode;
            _player.OffTalkPanel();
        }
    }
}