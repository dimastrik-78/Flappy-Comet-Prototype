using TMPro;
using UnityEngine;

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