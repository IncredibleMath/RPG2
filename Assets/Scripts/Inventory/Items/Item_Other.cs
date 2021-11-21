using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public class Item_Other : Item
    {
        [SerializeField]
        private Other_SO _otherList;
        void Start()
        {
            _type = ItemType.Other;
            _typeString = "Другое";
            foreach (OtherData Other in _otherList.GetOtherDatas)
            {
                if (Other.ID == _id)
                {
                    _name = Other.Name;
                    _sprite = Other.Sprite;
                    _price = Other.Price;
                    _isStackable = Other.IsStackable;
                    _maxStack = Other.MaxStack;
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
