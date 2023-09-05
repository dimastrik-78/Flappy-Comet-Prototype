using UnityEngine;

namespace CameraSystem
{
    public class PlayerCamera : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rb;
        
        private Movement _movement;

        void Awake()
        {
            _movement = new Movement(rb, transform);
            _movement.Move();
        }
    }
}