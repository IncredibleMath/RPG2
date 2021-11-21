using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public class BaseObject : MonoBehaviour
    {
        [SerializeField]
        protected GameObject _gameObject;
        [SerializeField]
        protected int _maxHealth;
        [SerializeField]
        protected int _health;
        [SerializeField]
        protected int _armor;
        [SerializeField]
        protected ObjectType _type;


        public int GetMaxHealth => _maxHealth;
        public int GetHealth => _health;
        public int GetArmor => _armor;
        public ObjectType GetObjectType => _type;

        public void DestroyObject ()
        {
            Destroy(_gameObject, 0.5f);
        }
        public void SetDamage(int Damage)
        {
            _health = _health - Damage;
            if (_health<=0)
            {
                DestroyObject();
            }
        }
    }
}