using Assets.Scripts.Models;
using UnityEngine;


namespace Assets.Scripts
{
    public class EnemyDestroy : MonoBehaviour
    {

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(GameModel.singleton.destroy))
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
