using UnityEngine;
using Utils;
using Utils.Event;
using Zenject;
using Random = System.Random;

namespace GenerationSystem
{
    public class Generation
    {
        private readonly Random _random;
        private readonly int _minDistanceSpawn;
        private readonly int _maxDistanceSpawn;

        [Inject]
        public Generation(int minDistanceSpawn, int maxDistanceSpawn)
        {
            _random = new Random();
            _minDistanceSpawn = minDistanceSpawn;
            _maxDistanceSpawn = maxDistanceSpawn;
        }
        
        public void GenerationGame(GameObject prefab, Transform position)
        {
            Object.Instantiate(prefab, position.position, position.rotation, null);
        }

        public void GenerationGame(GameObject prefab, int minDistance, int maxDistance, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Object.Instantiate(prefab, new Vector2(_random.Next(minDistance, maxDistance), 0), Quaternion.Euler(0, 0, 0));
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
