﻿using PlayerSystem;
using UnityEngine;

namespace LevelSystem
{
    public class LevelObject : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private float speed;
        
        private Movement _movement;

        void Awake()
        {
            _movement = new Movement();
            _movement.Move(rb, transform, speed);
        }
    }
}