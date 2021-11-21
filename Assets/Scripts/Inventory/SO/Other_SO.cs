using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    [CreateAssetMenu(fileName = "Others", menuName = "SO/Others")]
    public class Other_SO : ScriptableObject
    {
        [SerializeField]
        private List<OtherData> otherDatas;
        public List<OtherData> GetOtherDatas => otherDatas;
    }
}

