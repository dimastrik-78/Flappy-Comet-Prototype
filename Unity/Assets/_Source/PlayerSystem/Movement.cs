using UnityEngine;

namespace PlayerSystem
{
    public class Movement
    {
        private readonly Rigidbody2D _rb;
        private readonly Transform _transform;
        private readonly float _speed;
        
        public Movement(Rigidbody2D rb, Transform transform, float speed)
        {
            _rb = rb;
            _transform = transform;
            _speed = speed;
        }
        
        public void Move() 
            => _rb.velocity = new Vector2(_transform.position.x + _speed, _transform.position.y);

        public void Fly() 
            => _rb.gravityScale *= -1;
    }
}
