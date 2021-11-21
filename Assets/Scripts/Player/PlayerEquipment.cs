using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RPG
{

    public class PlayerEquipment : MonoBehaviour
    {
        [SerializeField]
        private Image _head;
        [SerializeField]
        private Image _body;
        [SerializeField]
        private Image _weapon;
        [SerializeField]
        private Image _secondWeapon;

        [SerializeField]
        private SpriteRenderer _headTexture;
        [SerializeField]
        private SpriteRenderer _armorTexture;
        [SerializeField]
        private SpriteRenderer _weaponTexture;
        [SerializeField]
        private SpriteRenderer _scabbardTexture;
        [SerializeField]
        private SpriteRenderer _secondWeaponTexture;

        [SerializeField]
        private BoxCollider2D _weaponCollider;
        private BasePlayerComponent _player;

        private Item_Weapon _equippedWeapon;
        private Item_Armor _equippedArmor;
        private Item_Headdress _equippedHeaddress;
        private Item_SecondWeapon _equippedSecondWeapon;

        public Item_Weapon GetEquippedWeapon => _equippedWeapon;
        public Item_Armor GetEquippedArmor => _equippedArmor;
        public Item_Headdress GetEquippedHeaddress => _equippedHeaddress;
        public Item_SecondWeapon GetEquippedSecondWeapon => _equippedSecondWeapon;

        [SerializeField]
        private Sprite _withoutArmor;
        [SerializeField]
        private Sprite _withoutHeaddress;
        [SerializeField]
        private Sprite _nullIcon;
        private Vector2 _nullOffset;
        private Vector2 _nullSize;



        private void Start()
        {
            _player = GetComponent<BasePlayerComponent>();
            _nullOffset = new Vector2(0.002f, -0.05f);
            _nullSize = new Vector2(0.02f, 0.02f);
        }

        public void SetArmor (Item item, Slot slot)
        {
            Item_Armor Item = (Item_Armor)item;
            if (Item == _equippedArmor)
            {
                _equippedArmor = null;
                _player.UpdateArmor(0);
                _body.sprite = _nullIcon;
                _armorTexture.sprite = _withoutArmor;
            }
            else
            {
                _equippedArmor = Item;
                _player.UpdateArmor(Item.GetArmorClass);
                _body.sprite = Item.GetSprite;
                _armorTexture.sprite = Item.GetTexture;
            }
        }
        
        public void SetHead(Item item, Slot slot)
        {
            Item_Headdress Item = (Item_Headdress)item;
            if (Item == _equippedHeaddress)
            {
                _equippedHeaddress = null;
                _player.UpdateHeaddress(0);
                _head.sprite = _nullIcon;
                _headTexture.sprite = _withoutHeaddress;
            }
            else
            {
                _equippedHeaddress = Item;
                _player.UpdateHeaddress(Item.GetArmorClass);
                _head.sprite = Item.GetSprite;
                _headTexture.sprite = Item.GetTexture;
            }

        }

        public void SetWeapon(Item item, Slot slot)
        {
            Item_Weapon Item = (Item_Weapon)item;
            if (Item == _equippedWeapon)
            {
                _equippedWeapon = null;
                _player.UpdateWeapon(1, 3);
                _weapon.sprite = _nullIcon;
                _weaponTexture.sprite = null;
                _scabbardTexture.sprite = null;
                _weaponCollider.offset = _nullOffset;
                _weaponCollider.size = _nullSize;
            }
            else
            {
                _equippedWeapon = Item;
                _player.UpdateWeapon(Item.GetMinDamage, Item.GetMaxDamage);
                _weapon.sprite = Item.GetSprite;
                _weaponTexture.sprite = Item.GetTexture;
                _scabbardTexture.sprite = Item.GetTexture;
                _weaponCollider.offset = Item.GetOffset;
                _weaponCollider.size = Item.GetSize;
            }

        }

        public void SetSecondWeapon(Item item, Slot slot)
        {

        }
    }
}
