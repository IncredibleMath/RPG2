using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace RPG
{
    public class Item : MonoBehaviour
    {
        [SerializeField]
        protected string _id;
        protected string _name;
        protected ItemType _type;
        protected string _typeString;
        protected Sprite _sprite;
        protected bool _isStackable;
        protected int _price;
        protected int _maxStack; //пока не использую
        [SerializeField]
        protected int _count;

        [SerializeField]
        protected GameObject _gameObject;

        public string GetID => _id;
        public ItemType GetItemType => _type;
        public string GetName => _name;
        public string GetTypeToString => _typeString;
        public Sprite GetSprite => _sprite;
        public int GetPrice => _price;
        public GameObject GetGameObject => _gameObject;
        public bool GetCanItBeStacked => _isStackable;
        public int GetCount => _count;

        protected string _info;
        [SerializeField]
        protected TextMeshProUGUI _stackText;
        [SerializeField]
        protected Image _image;

        public void AddQuantity (int quantity)
        {
            _count += quantity;
        }

        public void UpdateStackText()
        {
            _stackText.text = _count.ToString();
        }
    }
}