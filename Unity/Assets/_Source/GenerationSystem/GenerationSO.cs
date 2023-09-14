using UnityEngine;

namespace GenerationSystem
{
    [CreateAssetMenu(fileName = "GenerationSO", menuName = "SO/GenerationSO")]
    public class GenerationSO : ScriptableObject
    {
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private int spawnDistanceX;
        [SerializeField] private GameObject obstaclePrefab;
        [SerializeField] private int countObstacleSpawn;
        [SerializeField] private GameObject bonusPrefab;
        [SerializeField] private int countBonusSpawn;
        [SerializeField] private int minDistance;
        [SerializeField] private int maxDistance;

        public GameObject PlayerPrefab => playerPrefab;
        public int SpawnDistanceX => spawnDistanceX;
        public GameObject ObstaclePrefab => obstaclePrefab;
        public int CountObstacleSpawn => countObstacleSpawn;
        public GameObject BonusPrefab => bonusPrefab;
        public int CountBonusSpawn => countBonusSpawn;
        public int MinDistance => minDistance;
        public int MaxDistance => maxDistance;
    }
}