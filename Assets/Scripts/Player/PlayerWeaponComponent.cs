using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public class PlayerWeaponComponent : MonoBehaviour
    {
        private BasePlayerComponent _player;
        private Collider2D _collider;

        private void Start()
        {
            _player = FindObjectOfType<BasePlayerComponent>();
            _collider = GetComponent<BoxCollider2D>();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            var Object = collision.GetComponent<BodyComponent>();
            if (Object == null) return;
            var RollD20 = Random.Range(1, 21);
            var AttackValue = RollD20 + ((_player.GetDextrity - 10) / 2)+_player.GetLevel;
            Debug.Log("D20 = " + RollD20);
            if (RollD20 >19)
            {
                Debug.Log("CRITICAL HIT!!!");
                var Damage = ((_player.GetMaxDamage-1) + ((_player.GetStrength - 10) / 2)) * 2;
                Debug.Log("Damage = " + Damage);
                Object.GetParent.SetDamage(Damage, _player);
            }
            else if (AttackValue >= Object.GetParent.GetArmor)
            {
                Debug.Log("AttackValue = " + AttackValue);
                Debug.Log("Hit!");
                var Damage = Random.Range(_player.GetMinDamage, _player.GetMaxDamage) + ((_player.GetStrength - 10) / 2);
                Debug.Log("Damage = " + Damage);
                Object.GetParent.SetDamage(Damage, _player);
            }
            else
            {
                Debug.Log("AttackValue = " + AttackValue);
                Debug.Log("Miss!");
            }
    }
    }
}