using UnityEngine;

namespace ObstacleSystem
{
    public class Movement
    {
        private readonly Transform _transform;
        
        public Movement(Transform transform)
        {
            _transform = transform;
        }

        public void Move(float speed)
        {
            _transform.position = new Vector2(_transform.position.x, _transform.position.y + speed * Time.deltaTime);
        }
    }
}