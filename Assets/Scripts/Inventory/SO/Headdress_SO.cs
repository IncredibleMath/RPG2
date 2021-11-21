using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPG
{
    [CreateAssetMenu(fileName = "Headdress", menuName = "SO/Headdress")]
    public class Headdress_SO : ScriptableObject
    {
        [SerializeField]
        private List<HeaddressData> headdressDatas;
        public List<HeaddressData> GetHeaddressDatas => headdressDatas;
    }
}

