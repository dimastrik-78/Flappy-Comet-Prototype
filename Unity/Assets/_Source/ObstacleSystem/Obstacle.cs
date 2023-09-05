using System;
using UnityEngine;
using Utils;

namespace ObstacleSystem
{
    public class Obstacle : MonoBehaviour
    {
        [SerializeField] private float maxHeight;
        [SerializeField] private float minHeight;
        [SerializeField] private float speed;

        private Movement _movement;

        private bool _isUp = true;
        
        void Awake()
        {
            _movement = new Movement(transform);
            
            FixHeight();
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

        private void MoveUp()
        {
            _movement.Move(speed);
            
            if (transform.position.y >= maxHeight)
            {
                _isUp = false;
            }
        }

        private void MoveDown()
        {
            _movement.Move(-speed);
            
            if (transform.position.y <= minHeight)
            {
                _isUp = true;
            }
        }

        private void FixHeight()
        {
            if (maxHeight > 4.5)
            {
                maxHeight = 4.5f;
            }
            else if (maxHeight < 0)
            {
                maxHeight = 0;
            }
            
            if (minHeight < -4.5)
            {
                minHeight = -4.5f;
            }
            else if (minHeight > 0)
            {
                minHeight = 0;
            }
        }
    }
}
