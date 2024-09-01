using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class GameModel : MonoBehaviour
    {
        public static GameModel singleton { get; private set; }

        [SerializeField]
        public float jumpForcePlayer;
        [SerializeField]
        public float speedEnemy;
        [SerializeField]
        public string ground;
        [SerializeField]
        public string destroy; 


        private void Awake()
        {
            singleton = this;
        }
    }
}