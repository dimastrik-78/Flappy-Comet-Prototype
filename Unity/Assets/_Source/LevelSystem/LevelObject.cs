using UnityEngine;

namespace LevelSystem
{
    public class LevelObject : MonoBehaviour
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