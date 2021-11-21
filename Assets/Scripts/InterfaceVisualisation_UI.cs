using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RPG
{
    public class InterfaceVisualisation_UI : MonoBehaviour
    {
        private BasePlayerComponent Player;
        [SerializeField]
        private Slider _healthSlider;
        [SerializeField]
        private Slider _staminaSlider;

        private void Start()
        {
            Player = FindObjectOfType<BasePlayerComponent>();
            _healthSlider.value = 1;
        }
        public void ChangeHealth()
        {
            _healthSlider.maxValue = Player.GetMaxHealth;
            _healthSlider.value = Player.GetHealth;
        }
        public void ChangeStamina()
        {
            _staminaSlider.maxValue = Player.GetMaxStamina;
            _staminaSlider.value = Player.GetStamina;
        }
    }
}
