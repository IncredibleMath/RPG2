using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    [System.Serializable]
    public struct WeaponData
    {
        public string ID;
        public string Name;
        public Sprite Sprite;
        public Sprite Texture;
        public bool IsStackable;
        public int Price;
        public int MaxStack;
        public WeaponType WeaponType;
        public int MinDamage;
        public int MaxDamage;

        //Отступ канваса оружия
        public Vector2 Offset;
        //Размер канваса оружия
        public Vector2 Size;
    }
    [System.Serializable]
    public struct ArmorData
    {
        public string ID;
        public string Name;
        public Sprite Sprite;
        public Sprite Texture;
        public int Price;
        public int ArmorClass;
    }
    [System.Serializable]
    public struct OtherData
    {
        public string ID;
        public string Name;
        public Sprite Sprite;
        public bool IsStackable;
        public int Price;
        public int MaxStack;

    }
    [System.Serializable]
    public struct HeaddressData
    {
        public string ID;
        public string Name;
        public Sprite Sprite;
        public Sprite Texture;
        public int Price;
        public int ArmorClass;
    }
    [System.Serializable]
    public struct SecondWeaponData
    {
        public string ID;
        public string Name;
        public Sprite Sprite;
        public Sprite Texture;
        public bool IsStackable;
        public int Price;
        public int MaxStack;
        public int MinDamage;
        public int MaxDamage;
    }
}