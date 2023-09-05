using UISystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private ScoreView scoreView;
        
        private Game _game;
        
        void Awake()
        {
            _game = new Game();
            new ScoreController(scoreView);
        }
    }
}
