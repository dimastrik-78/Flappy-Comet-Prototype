using UnityEngine;
using System;
using Utils;
using Utils.Event;
using Random = System.Random;

namespace ObstacleSystem
{
    public class Obstacle : MonoBehaviour
    {
        [SerializeField] private int maxHeight;
        [SerializeField] private int minHeight;
        [SerializeField] private float speed;

        private Random _random;
        private Movement _movement;

        private int _maxHeight;
        private int _minHeight;
        private bool _isUp = true;
        
        private void Awake()
        {
            _random = new Random();
            _movement = new Movement(transform);
        }

        private void Update()
        {
            if (_isUp)
            {
                MoveUp();
            }
            else
            {
                MoveDown();
            }
        }

        private void OnEnable()
        {
            _maxHeight = _random.Next(0, maxHeight);
            _minHeight = _random.Next(minHeight, 0);
        }

        private void MoveUp()
        {
            _movement.Move(speed);
            
            if (transform.position.y >= _maxHeight)
            {
                _isUp = false;
            }
        }

        private void MoveDown()
        {
            _movement.Move(-speed);
            
            if (transform.position.y <= _minHeight)
            {
                _isUp = true;
            }
        }
    }
}
