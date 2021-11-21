using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public class Item_Headdress : Item
    {
        private Sprite _texture;
        private int _armorClass;
        public int GetArmorClass => _armorClass;
        public Sprite GetTexture => _texture;
        [SerializeField]
        private Headdress_SO _headdressList;
        private void Start()
        {
            _type = ItemType.Headdress;
            _typeString = "Головной Убор";
            foreach (HeaddressData Headdress in _headdressList.GetHeaddressDatas)
            {
                if (Headdress.ID == _id)
                {
                    _name = Headdress.Name;
                    _sprite = Headdress.Sprite;
                    _price = Headdress.Price;
                    _texture = Headdress.Texture;
                    _armorClass = Headdress.ArmorClass;
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