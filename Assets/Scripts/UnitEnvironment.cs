using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    [RequireComponent(typeof(Animator))]
    public class UnitEnvironment : MonoBehaviour
    {
        [SerializeField]
        private Animator _animator;
        [SerializeField]
        private Collider2D _collider;
        public void Moving(bool direction)
        {
            _animator.SetBool("Movement", direction);
        }
        public void BattleMod(bool direction)
        {
            _animator.SetBool("BattleMod", direction);
        }
        private void AnimationEventEnd_UnityEditor(string result)
        {
        }
    }
}