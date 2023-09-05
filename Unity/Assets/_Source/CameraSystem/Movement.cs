using UnityEngine;

namespace CameraSystem
{
    public class Movement
    {
        private readonly Rigidbody2D _rb;
        private readonly Transform _transform;
        
        public Movement(Rigidbody2D rb, Transform transform)
        {
            _rb = rb;
            _transform = transform;
        }
        
        public void Move() 
            => _rb.velocity = new Vector2(_transform.position.x + 1, _transform.position.y);
    }
}