using Assets.Scripts.Models;
using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {

        private Rigidbody2D _rb;
        private BoxCollider2D _boxCollider;
        private bool _isGround = false;


        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Jump();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.gameObject.CompareTag(GameModel.instance.ground)) 
                _isGround = true;
            else if (collision.gameObject.CompareTag(GameModel.instance.destroy))
                GameController.instance.StopGame();
            else
                Debug.Log("New collision to Player: " + collision.gameObject.tag);
        }

        private void Jump()
        {

            if (Input.GetKeyDown(KeyCode.Space) && _isGround)
            {
                _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, GameModel.instance.jumpForcePlayer);
                _isGround = false;
            }
        }

    }
}
