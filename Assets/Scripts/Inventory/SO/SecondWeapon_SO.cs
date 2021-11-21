using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    [CreateAssetMenu(fileName = "SecondWeapon", menuName = "SO/SecondWeapon")]
    public class SecondWeapon_SO : ScriptableObject
    {
        [SerializeField]
        private List<SecondWeaponData> secondWeaponDatas;
        public List<SecondWeaponData> GetSecondWeaponDatas => secondWeaponDatas;
    }
}

