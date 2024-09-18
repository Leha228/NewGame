using Assets.Scripts.Models;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameController : MonoBehaviour
    {
        public static GameController instance { get; set;}


        public void StopGame() => Time.timeScale = 0;

        public void ResumeGame() =>  Time.timeScale = GameModel.instance.timeScale;


        public void Awake()
        {
            instance = this;
        }


        //Доработать временую шляпу
        void Start()
        {
            Time.timeScale = GameModel.instance.timeScale;
        }

    }
}