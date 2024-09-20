using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class GameModel : MonoBehaviour
    {
        public static GameModel instance { get; set; }

        [SerializeField]
        public float jumpForcePlayer; // сила прыжка героя

        [SerializeField]
        public float speedEnemy; // скорость врага

        [SerializeField]
        public string ground; // Тег террейна

        [SerializeField]
        public string destroy; // Тег обьекта, при котором герой проигрывает

        [SerializeField]
        public float timeRespawnEnemy; // время спавна врага, начальное

        [SerializeField]
        public float timeRespawnEnemyCoff; // коэффициент рандома для респавна

        [SerializeField]
        public int score; // начальное число очков

        [SerializeField]
        public float timeScale; // начальное время при старте игры

        [SerializeField]
        public float timeScaleCoff; // коэффициент прироста скорости игры 


        private void Awake()
        {
            instance = this;
        }
    }
}