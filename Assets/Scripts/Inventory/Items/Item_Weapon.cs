using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public class Item_Weapon : Item
    {
        private Sprite _texture;
        private int _minDamage;
        private int _maxDamage;
        private WeaponType _weaponType;
        private Vector2 _offset;
        private Vector2 _size;

        public int GetMinDamage => _minDamage;
        public int GetMaxDamage => _maxDamage;
        public Sprite GetTexture => _texture;
        public WeaponType GetWeaponType => _weaponType;
        public Vector2 GetOffset => _offset;
        public Vector2 GetSize => _size;
        [SerializeField]
        private Weapon_SO _weaponList;


        private void Start()
        {
            _type = ItemType.Weapon;
            _typeString = "Оружие";
            foreach (WeaponData Weapon in _weaponList.GetWeaponDatas)
            {
                if (Weapon.ID == _id)
                {
                    _name = Weapon.Name;
                    _texture = Weapon.Texture;
                    _sprite = Weapon.Sprite;
                    _price = Weapon.Price;
                    _isStackable = Weapon.IsStackable;
                    _maxStack = Weapon.MaxStack;
                    _weaponType = Weapon.WeaponType;
                    _minDamage = Weapon.MinDamage;
                    _maxDamage = Weapon.MaxDamage;
                    _offset = Weapon.Offset;
                    _size = Weapon.Size;
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
