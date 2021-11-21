using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public class GameMenuManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _gamePauseMenu;
        [SerializeField]
        private GameObject _gameOverMenu;

        public void ActivateGameOverMenu()
        {
            _gameOverMenu.SetActive(true);
        }
    }
}
