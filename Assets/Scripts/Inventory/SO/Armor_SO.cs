using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    [CreateAssetMenu(fileName = "Armors", menuName = "SO/Armors")]
    public class Armor_SO : ScriptableObject
    {
        [SerializeField]
        private List<ArmorData> armorDatas;
        public List<ArmorData> GetArmorDatas => armorDatas;
    }
}

