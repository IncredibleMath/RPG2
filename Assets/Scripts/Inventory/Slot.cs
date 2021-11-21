using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace RPG
{
    public class Slot : MonoBehaviour, IPointerClickHandler
    {
        private InventoryManager InventoryManager;
        [SerializeField]
        private InventoryComponent _inventoryFrom;
        [SerializeField]
        private GameObject Self;
        private InventoryOperator _operator;
        private Item _item;

        public InventoryComponent GetInventoryComponent => _inventoryFrom;
        public GameObject GetGameObject => Self;
        public Item GetItem => _item;
        public void SetInventoryComponent (InventoryComponent inventoryComponent)
        {
            _inventoryFrom = inventoryComponent;
        }
        private void Start()
        {
            InventoryManager = FindObjectOfType<InventoryManager>();
            _operator = FindObjectOfType<InventoryOperator>();
            _item = GetComponent<Item>();
            
            _inventoryFrom._inventory.Add(this._item);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            _operator.InitializePanel(this, InventoryManager.GetInteraction);
        }
        public void DeleteSlot()
        {
            Destroy(Self);
        }
    }
}
