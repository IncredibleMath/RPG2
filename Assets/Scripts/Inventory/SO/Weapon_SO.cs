using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    [CreateAssetMenu(fileName = "Weapons", menuName = "SO/Weapons")]
    public class Weapon_SO : ScriptableObject
    {
        [SerializeField]
        private List<WeaponData> weaponDatas ;
        public List<WeaponData> GetWeaponDatas => weaponDatas;
    }
}