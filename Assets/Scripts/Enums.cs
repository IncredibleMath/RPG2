using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public enum ObjectType
    {
        Unit,
        Surroundings, //окружение
    }
    public enum UnitType
    {
        Enemy,
        QuestMan,
        Commoner,
        Character
    }
    public enum Characteristics
    {
        Strength,
        Dextrity,
        Concentration,
        Intelligense
    }
    public enum InteractionsType
    {
        Open,
        Search,
        Talk,
        Trade
    }
    public enum ItemType
    {
        Weapon,
        Armor,
        Other,
        Headdress,
        SecondWeapon,
    }
    public enum WeaponType
    {
        Knife,
        Sword,
        Rapier,
        Axe,
        Blockhead,
        Shaft
    }
    public enum EquipmentType
    {
        Head,
        Body,
        Weapon,
        SecondWeapon,
    }
    public enum InventoryInteractionType
    {
        Trade,
        Search,
        Inventory,
    }

}
