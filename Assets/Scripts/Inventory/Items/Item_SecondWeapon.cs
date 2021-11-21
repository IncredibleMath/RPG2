using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPG
{
    public class Item_SecondWeapon : Item
    {
        private Sprite _texture;
        private int _minDamage;
        private int _maxDamage;
        [SerializeField]
        private SecondWeapon_SO _secondWeaponList;


        private void Start()
        {
            _type = ItemType.SecondWeapon;
            _typeString = "Второстепенное Оружие";
            foreach (SecondWeaponData SecondWeapon in _secondWeaponList.GetSecondWeaponDatas)
            {
                if (SecondWeapon.ID == _id)
                {
                    _name = SecondWeapon.Name;
                    _texture = SecondWeapon.Texture;
                    _sprite = SecondWeapon.Sprite;
                    _price = SecondWeapon.Price;
                    _isStackable = SecondWeapon.IsStackable;
                    _maxStack = SecondWeapon.MaxStack;
                    _minDamage = SecondWeapon.MinDamage;
                    _maxDamage = SecondWeapon.MaxDamage;
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

