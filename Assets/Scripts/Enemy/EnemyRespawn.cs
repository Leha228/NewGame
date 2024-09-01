using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyRespawn : MonoBehaviour
    {

        [SerializeField]
        public GameObject enemyObject;

        private bool _coroutine = false;


        void Start()
        {
            Time.timeScale = 1.0f;
            StartCoroutine("Respawn", 1.0f);
        }

        IEnumerator Respawn(float timeSecond)
        {
            float counter = 0;
            _coroutine = true;

            while (counter < timeSecond)
            {
                counter += Time.deltaTime;
                yield return null;
            }

            _coroutine = false;
            Instantiate(enemyObject, this.transform.position, Quaternion.identity);
        }

        void Update()
        {
            if (!_coroutine)
                StartCoroutine("Respawn", 3.0f); 
        }
    }
}
