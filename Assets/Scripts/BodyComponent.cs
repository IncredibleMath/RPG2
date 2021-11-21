using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public class BodyComponent : MonoBehaviour
    {
        [SerializeField]
        private BaseUnit Parent;
        public BaseUnit GetParent => Parent;
    }
}