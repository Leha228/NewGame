using Assets.Scripts.Models;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameController : MonoBehaviour
    {
        public static GameController instance { get; set;}
        private bool pause = false;

        public void StopGame() => pause = true;

        public void ResumeGame() => pause = false;


        public void Awake()
        {
            instance = this;
        }


        
        private void Start()
        {
            Time.timeScale = GameModel.instance.timeScale;
        }

        private void Update()
        {
            CheckPause();
        }

        public float EditTimeRespawnEnemy()
        {
            float time = Random.Range(
                GameModel.instance.timeRespawnEnemy - GameModel.instance.timeRespawnEnemyCoff, 
                GameModel.instance.timeRespawnEnemy + GameModel.instance.timeRespawnEnemyCoff
            );

            return time;
        }

        private void CheckPause()
        {
            if (pause)
                Time.timeScale = 0;
            else
            {
                GameModel.instance.timeScale += GameModel.instance.timeScaleCoff;
                Time.timeScale = GameModel.instance.timeScale;
            }
        }

    }
}