using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    public class GameManager : MonoBehaviour
    {
        private GameMenuManager GameMenuManager;
        private BasePlayerComponent Player;

        private void Start()
        {
            Player = FindObjectOfType<BasePlayerComponent>();
            GameMenuManager = GetComponent<GameMenuManager>();
        }
        public void GameOver ()
        {
            GameMenuManager.ActivateGameOverMenu();
            Player.OffManagement();
            Time.timeScale = 0f;
        }



    }
}