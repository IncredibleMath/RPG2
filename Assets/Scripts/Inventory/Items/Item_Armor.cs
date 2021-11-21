using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public class Item_Armor : Item
    {
        private Sprite _texture;
        private int _armorClass;
        public int GetArmorClass => _armorClass;
        public Sprite GetTexture => _texture;
        [SerializeField]
        private Armor_SO _armorList;
        private void Start()
        {
            _type = ItemType.Armor;
            _typeString = "Броня";
            foreach (ArmorData Armor in _armorList.GetArmorDatas)
            {
                if (Armor.ID == _id)
                {
                    _name = Armor.Name;
                    _sprite = Armor.Sprite;
                    _price = Armor.Price;
                    _texture = Armor.Texture;
                    _armorClass = Armor.ArmorClass;
                }
            }
            _image.sprite = _sprite;
            if (_isStackable)
            {
                _stackText.text = _count.ToString();
            }
            else
            {
                _stackText.text = "";
                _count = 1;
                _maxStack = 1;
            }
        }
    }
}