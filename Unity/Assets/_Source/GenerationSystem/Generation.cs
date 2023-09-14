using UnityEngine;
using Utils;
using Utils.Event;
using VContainer;
using Random = System.Random;

namespace GenerationSystem
{
    public class Generation
    {
        private readonly Random _random;
        private readonly int _minDistanceSpawn;
        private readonly int _maxDistanceSpawn;
        private GenerationSO _generationSO;

        [Inject]
        public Generation(int minDistanceSpawn, int maxDistanceSpawn)
        {
            _random = new Random();
            _minDistanceSpawn = minDistanceSpawn;
            _maxDistanceSpawn = maxDistanceSpawn;
            _generationSO = Resources.Load<GenerationSO>("GenerationSO");
        }
        
        public void PlayerGeneration()
        {
            Object.Instantiate(_generationSO.PlayerPrefab, new Vector3(_generationSO.SpawnDistanceX, 0), Quaternion.Euler(Vector3.zero), null);
        }

        public void BonusGeneration()
        {
            for (int i = 0; i < _generationSO.CountBonusSpawn; i++)
            {
                Object.Instantiate(_generationSO.BonusPrefab, new Vector2(_random.Next(_generationSO.MinDistance, _generationSO.MaxDistance), 0), Quaternion.Euler(0, 0, 0));
            }
        }
        
        public void ObstacleGeneration()
        {
            for (int i = 0; i < _generationSO.CountObstacleSpawn; i++)
            {
                Object.Instantiate(_generationSO.ObstaclePrefab, new Vector2(_random.Next(_generationSO.MinDistance, _generationSO.MaxDistance), 0), Quaternion.Euler(0, 0, 0));
            }
        }

        public void OnEvent()
        {
            Signals.Get<SetObjectSignal>().AddListener(SetObject);
            Signals.Get<ResetSceneSignal>().AddListener(DisEvent);
        }

        private void DisEvent()
        {
            Signals.Get<SetObjectSignal>().RemoveListener(SetObject);
            Signals.Get<ResetSceneSignal>().RemoveListener(DisEvent);
        }

        private void SetObject(GameObject gameObject)
        {
            gameObject.transform.position = new Vector2(Camera.main.ViewportToWorldPoint(new Vector3(1, 0)).x + _random.Next(_minDistanceSpawn, _maxDistanceSpawn), 0);
            gameObject.SetActive(true);
        }
    }
}
