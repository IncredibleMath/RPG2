using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace RPG
{
    public class InventoryCharacteristics_UI : MonoBehaviour
    {
        private BasePlayerComponent Player;

        [SerializeField]
        private TextMeshProUGUI Level;
        [SerializeField]
        private TextMeshProUGUI Strength;
        [SerializeField]
        private TextMeshProUGUI Dextrity;
        [SerializeField]
        private TextMeshProUGUI Consentration;
        [SerializeField]
        private TextMeshProUGUI Intelligense;
        [SerializeField]
        private TextMeshProUGUI SkillPoints;

        [SerializeField]
        private GameObject StrengthButton;
        [SerializeField]
        private GameObject DextrityButton;
        [SerializeField]
        private GameObject ConsentrationButton;
        [SerializeField]
        private GameObject IntelligenseButton;

        [SerializeField]
        private TextMeshProUGUI AttackAdvantage;
        [SerializeField]
        private TextMeshProUGUI Damage;
        [SerializeField]
        private TextMeshProUGUI ArmorClass;

        [SerializeField]
        private TextMeshProUGUI Exp;

        private void Start()
        {
            Player = FindObjectOfType<BasePlayerComponent>();
            ArmorClass.text = Player.GetArmor.ToString();
            Damage.text = (Player.GetMinDamage + ((Player.GetStrength - 10) / 2)).ToString() + " - " + ((Player.GetMaxDamage + ((Player.GetStrength - 10) / 2))-1).ToString();
            AttackAdvantage.text = (((Player.GetDextrity - 10) / 2) + Player.GetLevel).ToString();
            Exp.text = "1000";
        }

        public void ChangeLevelText(int level, int SP)
        {
            Level.text = level.ToString();
            SkillPoints.text = SP.ToString();
        }
        public void ChangeStrenghText(int strengh)
        {
            Strength.text = strengh.ToString();
        }
        public void ChangeDextrityText(int dextrity)
        {
            Dextrity.text = dextrity.ToString();
        }
        public void ChangeConsentrationText(int consentration)
        {
            Consentration.text = consentration.ToString();
        }
        public void ChangeIntelligenseText(int intelligense)
        {
            Intelligense.text = intelligense.ToString();
        }

        public void ChangeArmorClassText(int armor)
        {
            ArmorClass.text = armor.ToString();
        }
        public void ChangeDamageText(int minDamage, int maxDamage, int strength)
        {
            Damage.text = (minDamage + ((strength - 10) / 2)).ToString() + " - " + ((maxDamage-1) + ((strength - 10) / 2)).ToString();
        }
        public void ChangeAttackAdvantageClassText(int dextrity, int level)
        {
            AttackAdvantage.text = (((dextrity - 10) / 2) + level).ToString();
        }

        public void ChangeExpText (int necessaryExp, int exp)
        {
            Exp.text = (necessaryExp - exp).ToString();
        }


        public void LvlUp_buttonsOn ()
        {
            StrengthButton.SetActive(true);
            DextrityButton.SetActive(true);
            ConsentrationButton.SetActive(true);
            IntelligenseButton.SetActive(true);
        }
        public void LvlUp_buttonsOff()
        {
            StrengthButton.SetActive(false);
            DextrityButton.SetActive(false);
            ConsentrationButton.SetActive(false);
            IntelligenseButton.SetActive(false);
        }

        public void AddStrength_UnityEditor()
        {
            Player.AddOneToCharacteristic(Characteristics.Strength);
        }
        public void AddDextrity_UnityEditor()
        {
            Player.AddOneToCharacteristic(Characteristics.Dextrity);
        }
        public void AddConsentration_UnityEditor()
        {
            Player.AddOneToCharacteristic(Characteristics.Concentration);
        }
        public void AddIntelligense_UnityEditor()
        {
            Player.AddOneToCharacteristic(Characteristics.Intelligense);
        }

    }
}