using GenerationSystem;
using UISystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private int minDistanceSpawn;
        [SerializeField] private int maxDistanceSpawn;
        [SerializeField] private ScoreView scoreView;
        
        private Game _game;
        
        void Awake()
        {
            _game = new Game();
            new Score(scoreView);
            new Generation(minDistanceSpawn, maxDistanceSpawn);
        }
    }
}
