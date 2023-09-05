using UnityEngine;

namespace PlayerSystem
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rb;
        
        private PlayerInputSystem _input;
        private Movement _movement;

        private bool _isPress;
        
        void Awake()
        {
            _movement = new Movement(rb, transform);
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
    }
}
