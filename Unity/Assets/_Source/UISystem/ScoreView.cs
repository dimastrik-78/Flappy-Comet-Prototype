using System;
using TMPro;
using UnityEngine;
using Utils;
using Utils.Event;

namespace UISystem
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textMeshPro;

        public void ScoreUpdate(string score)
        {
            textMeshPro.text = score;
        }
    }
}