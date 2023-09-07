using UnityEngine;
using Utils;
using Utils.Event;
using Random = System.Random;

namespace GenerationSystem
{
    public class Generation
    {
        private readonly Random _random;
        private readonly int _minDistanceSpawn;
        private readonly int _maxDistanceSpawn;

        public Generation(int minDistanceSpawn, int maxDistanceSpawn)
        {
            _random = new Random();
            _minDistanceSpawn = minDistanceSpawn;
            _maxDistanceSpawn = maxDistanceSpawn;

            OnEvent();
        }

        private void OnEvent()
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
