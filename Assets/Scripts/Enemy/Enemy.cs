using Assets.Scripts.Models;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Enemy : MonoBehaviour
    {

        private Rigidbody2D _rb;


        // Use this for initialization
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            Run();
        }


        private void Run()
        {
            _rb.linearVelocity = new Vector2(GameModel.instance.speedEnemy, _rb.linearVelocity.y);
        }
    }
}