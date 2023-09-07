using System;
using Unity.VisualScripting;
using UnityEngine;
using Utils;
using Utils.Event;

namespace PlayerSystem
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private float speed;
        [SerializeField] private LayerMask obstacle;
        [SerializeField] private LayerMask bonus;
        
        private PlayerInputSystem _input;
        private Movement _movement;

        private bool _isPress;
        
        void Awake()
        {
            _movement = new Movement(rb, transform, speed);
            _movement.Move();
            
            InputSetting();
        }

        private void InputSetting()
        {
            _input = new PlayerInputSystem();

            _input.Action.Fly.started += _ => _movement.Fly();
            _input.Action.Fly.canceled += _ => _movement.Fly();
            
            _input.Enable();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (obstacle.Contains(other.gameObject.layer))
            {
                Signals.Get<ResetSceneSignal>().Dispatch();
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (bonus.Contains(other.gameObject.layer))
            {
                Signals.Get<TakeBonusSignal>().Dispatch();
            }
        }
    }
}
