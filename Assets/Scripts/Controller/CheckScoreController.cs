using UnityEngine;
using Assets.Scripts.Models;
using TMPro;
using System;

namespace Assets.Scripts
{
    public class CheckScoreController : MonoBehaviour
    {

        [SerializeField]
        public TMP_Text textMesh;
        private float checkScore = 0f;

        private void Update()
        {
            EditTextScore();
        }

        /*
         * Отрисовка очков прогресса
         */
        private void EditTextScore()
        {
            checkScore += Time.timeScale / 40;
            textMesh.text = Convert.ToInt32(checkScore).ToString();
        }
    }
}
