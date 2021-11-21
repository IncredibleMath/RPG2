using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public class BodyCharacterComponent : MonoBehaviour
    {
        [SerializeField]
        private BasePlayerComponent Parent;
        public BasePlayerComponent GetParent => Parent;
    }
}
