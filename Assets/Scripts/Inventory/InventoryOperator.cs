using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace RPG
{
    public class InventoryOperator : MonoBehaviour
    {
        [SerializeField]
        private InventoryManager InventoryManager;
        [SerializeField]
        private PlayerEquipment PlayerEquipment;
        private Slot _currentSlot;

        [SerializeField]
        private GameObject _characterPanelInfo;
        [SerializeField]
        private GameObject _itemPanelInfo;
        [SerializeField]
        private GameObject _equipmentPanel;
        [SerializeField]
        private GameObject _panelInterract;

        [SerializeField]
        private Image _itemIcon;
        [SerializeField]
        private TextMeshProUGUI _itemName;
        [SerializeField]
        private TextMeshProUGUI _itemType;
        [SerializeField]
        private TextMeshProUGUI _itemCost;
        [SerializeField]
        private TextMeshProUGUI _itemInfo;

        [SerializeField]
        private GameObject _equipButton;
        [SerializeField]
        private GameObject _interractButton;

        private void Start()
        {
            InventoryManager = FindObjectOfType<InventoryManager>();
            PlayerEquipment = FindObjectOfType<PlayerEquipment>();
        }
        public void InitializePanel (Slot slot, InventoryInteractionType formatOfInteraction)
        {
            _currentSlot = slot;
            _characterPanelInfo.SetActive(false);
            _equipmentPanel.SetActive(false);
            _itemPanelInfo.SetActive(true);
            _panelInterract.SetActive(true);

            _itemIcon.sprite = slot.GetItem.GetSprite;
            _itemName.text = slot.GetItem.GetName;
            _itemType.text = slot.GetItem.GetTypeToString;
            _itemCost.text = slot.GetItem.GetPrice.ToString();
            _itemInfo.text = "info";

            if (formatOfInteraction == InventoryInteractionType.Inventory)
            {
                if (slot.GetItem.GetItemType != ItemType.Other)
                {
                    _equipButton.SetActive(true);
                    _interractButton.SetActive(false);
                }
                else
                {
                    _equipButton.SetActive(false);
                    _interractButton.SetActive(false);
                }
            }
            else if (formatOfInteraction == InventoryInteractionType.Search)
            {
                if ((slot.GetItem.GetItemType != ItemType.Other))
                {
                    _equipButton.SetActive(true);
                    _interractButton.SetActive(true);
                }
                else
                {
                    _equipButton.SetActive(false);
                    _interractButton.SetActive(true);
                }
            }
            else if ((formatOfInteraction == InventoryInteractionType.Trade))
            {
                    _equipButton.SetActive(false);
                    _interractButton.SetActive(true);
            }
        }

        public void Equip_UnityEditor ()
        {
            if (_currentSlot.GetInventoryComponent != InventoryManager.GetPlayerInventory)
            {
                InventoryManager.Translate(_currentSlot.GetInventoryComponent, _currentSlot.GetGameObject, _currentSlot.GetItem, _currentSlot);
            }
            ChangeEquipment();
            Back_UnityEditor();
        }

        public void Translate_UnityEditor ()
        {
            if (_currentSlot.GetInventoryComponent == InventoryManager.GetPlayerInventory && IsEquipCurrentItem())
            {
                ChangeEquipment();
            }
            InventoryManager.Translate(_currentSlot.GetInventoryComponent, _currentSlot.GetGameObject, _currentSlot.GetItem, _currentSlot);
            Back_UnityEditor();
        }

        public void Back_UnityEditor ()
        {
            _characterPanelInfo.SetActive(true);
            _equipmentPanel.SetActive(true);
            _itemPanelInfo.SetActive(false);
            _panelInterract.SetActive(false);
            _currentSlot = null;
        }


        private void ChangeEquipment()
        {
            if (_currentSlot.GetItem.GetItemType == ItemType.Armor)
            {
                PlayerEquipment.SetArmor(_currentSlot.GetItem, _currentSlot);
            }
            else if (_currentSlot.GetItem.GetItemType == ItemType.Weapon)
            {
                PlayerEquipment.SetWeapon(_currentSlot.GetItem, _currentSlot);
            }
            else if (_currentSlot.GetItem.GetItemType == ItemType.Headdress)
            {
                PlayerEquipment.SetHead(_currentSlot.GetItem, _currentSlot);
            }
            else if (_currentSlot.GetItem.GetItemType == ItemType.SecondWeapon)
            {
                PlayerEquipment.SetSecondWeapon(_currentSlot.GetItem, _currentSlot);
            }
        }
        /// <summary>
        /// Метод определяющий является ли текущий слот/итем экипированным
        /// </summary>
        /// <returns></returns>
        private  bool IsEquipCurrentItem()
        {
            if (_currentSlot.GetItem.GetItemType == ItemType.Armor)
            {
                if ((Item_Armor)_currentSlot.GetItem == PlayerEquipment.GetEquippedArmor)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (_currentSlot.GetItem.GetItemType == ItemType.Weapon)
            {
                if ((Item_Weapon)_currentSlot.GetItem == PlayerEquipment.GetEquippedWeapon)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (_currentSlot.GetItem.GetItemType == ItemType.Headdress)
            {
                if ((Item_Headdress)_currentSlot.GetItem == PlayerEquipment.GetEquippedHeaddress)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (_currentSlot.GetItem.GetItemType == ItemType.SecondWeapon)
            {
                if ((Item_SecondWeapon)_currentSlot.GetItem == PlayerEquipment.GetEquippedSecondWeapon)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
