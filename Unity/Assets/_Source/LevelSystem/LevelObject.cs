using PlayerSystem;
using UnityEngine;
using VContainer;

namespace LevelSystem
{
    public class LevelObject : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private float speed;
        
        [Inject] private Movement _movement;

        void Awake()
        {
            //TODO remove incapsulated initialisation
            _movement.Move(rb, transform, speed);
        }
    }
}