using UnityEngine;

namespace ObstacleSystem
{
    [CreateAssetMenu(fileName = "ObstacleSO", menuName = "SO/ObstacleSO")]
    public class ObstacleSO : ScriptableObject
    {
        [SerializeField] private int minDistanceSpawn;
        [SerializeField] private int maxDistanceSpawn;

        public int MinDistanceSpawn => minDistanceSpawn;
        public int MaxDistanceSpawn => maxDistanceSpawn;
    }
}