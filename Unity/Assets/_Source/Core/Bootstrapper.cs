using GenerationSystem;
using UISystem;
using UnityEngine;
using Zenject;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private GameObject obstaclePrefab;
        [SerializeField] private int countObstacleSpawn;
        [SerializeField] private GameObject bonusPrefab;
        [SerializeField] private int countBonusSpawn;
        [SerializeField] private int minDistance;
        [SerializeField] private int maxDistance;
        [SerializeField] private Transform playerSpawn;

        [Inject] private Game _game;
        [Inject] private Score _score;
        [Inject] private Generation _generation;
        
        void Awake()
        {
            _game.StartGame();
            _score.OnEvent();
            _generation.OnEvent();
            _generation.GenerationGame(playerPrefab, playerSpawn);
            _generation.GenerationGame(obstaclePrefab, minDistance, maxDistance, countObstacleSpawn);
            _generation.GenerationGame(bonusPrefab, minDistance, maxDistance, countBonusSpawn);
        }
    }
}
