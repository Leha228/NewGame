using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class GameModel : MonoBehaviour
    {
        public static GameModel instance { get; set; }

        [SerializeField]
        public float jumpForcePlayer;
        [SerializeField]
        public float speedEnemy;
        [SerializeField]
        public string ground;
        [SerializeField]
        public string destroy;
        [SerializeField]
        public float timeRespawnEnemy;
        [SerializeField]
        public int score;
        [SerializeField]
        public float timeScale;


        private void Awake()
        {
            instance = this;
        }
    }
}