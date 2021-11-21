using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPG
{

    public class BotWeaponComponent : MonoBehaviour
    {
        [SerializeField]
        private int _minDamage;
        [SerializeField]
        private int _maxDamage;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            var Object = collision.GetComponent<BodyCharacterComponent>();
            if (Object == null) return;
            var RollD20 = Random.Range(1, 21);
            var AttackValue = RollD20;
            Debug.Log("D20 = " + RollD20);
            if (RollD20 > 19)
            {
                Debug.Log("CRITICAL HIT!!!");
                var Damage = _maxDamage * 2;
                Debug.Log("Damage = " + Damage);
                Object.GetParent.SetPlayerDamage(Damage);
            }
            else if (AttackValue >= Object.GetParent.GetArmorClass)
            {
                Debug.Log("AttackValue = " + AttackValue);
                Debug.Log("Hit!");
                var Damage = Random.Range(_minDamage, _maxDamage+1);
                Debug.Log("Damage = " + Damage);
                Object.GetParent.SetPlayerDamage(Damage);
            }
            else
            {
                Debug.Log("AttackValue = " + AttackValue);
                Debug.Log("Miss!");
            }
            
        }
    }

}
