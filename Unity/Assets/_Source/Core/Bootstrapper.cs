using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        private Game _game;
        
        void Awake()
        {
            _game = new Game();
        }
    }
}
