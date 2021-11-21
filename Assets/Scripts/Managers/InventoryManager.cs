using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public class InventoryManager : MonoBehaviour
    {
        [SerializeField]
        private InventoryComponent _playerInventory;
        private InventoryComponent _otherActiveInventory;

        [SerializeField]
        private InventoryOperator _inventoryOperator;

        [SerializeField]
        private Transform _playerSlots;
        [SerializeField]
        private Transform _otherSlots;

        private InventoryInteractionType _interaction;
        public InventoryInteractionType GetInteraction => _interaction;
        public InventoryComponent GetPlayerInventory => _playerInventory;
        public void SetInteraction(InventoryInteractionType formatOfInteraction)
        {
            _interaction = formatOfInteraction;
        }
        private void Start()
        {
            _interaction = InventoryInteractionType.Inventory;
        }

        public void Translate(InventoryComponent inventory, GameObject ItemGO, Item Item, Slot slot )
        {
            if (inventory == _playerInventory)
            {
                _playerInventory._inventory.Remove(Item);
                if (Item.GetCanItBeStacked)
                {
                    AddQuantityToTheSame(_otherActiveInventory, Item, ItemGO, slot, _otherSlots);

                    
                }
                else
                {
                    ItemGO.transform.SetParent(_otherSlots);
                    _otherActiveInventory._inventory.Add(Item);
                    slot.SetInventoryComponent(_otherActiveInventory);
                }

            }
            else
            {
                _otherActiveInventory._inventory.Remove(Item);
                if (Item.GetCanItBeStacked)
                {
                    AddQuantityToTheSame(_playerInventory, Item, ItemGO, slot, _playerSlots);


                }
                else
                {
                    ItemGO.transform.SetParent(_playerSlots);
                    _playerInventory._inventory.Add(Item);
                    slot.SetInventoryComponent(_playerInventory);
                }
            }
        }
        public void PutToOtherSlots (InventoryComponent inventory)
        {
            _otherActiveInventory = inventory;
            foreach (Item item in inventory._inventory)
            {
                item.GetGameObject.transform.SetParent(_otherSlots);
            }
        }
        public void ReturnFromOtherSlots (InventoryComponent inventory, Transform pool)
        {
            _otherActiveInventory = null;
            foreach (Item item in inventory._inventory)
            {
                item.GetGameObject.transform.SetParent(pool);
            }
        }
        private void AddQuantityToTheSame(InventoryComponent inventory, Item Item, GameObject ItemGO, Slot slot, Transform transform)
        {
            //Изменить, добавив новую переменную, чтобы элс делал кое-что другое
            bool IsFind = false;
            foreach (Item SameItem in inventory._inventory)
            {
                if (SameItem.GetID == Item.GetID)
                {
                    SameItem.AddQuantity(Item.GetCount);
                    SameItem.UpdateStackText();
                    slot.DeleteSlot();
                    IsFind = true;
                }
            }
            if (!IsFind)
            {
                ItemGO.transform.SetParent(transform);
                inventory._inventory.Add(Item);
                slot.SetInventoryComponent(inventory);
            }
        }
    }
}
