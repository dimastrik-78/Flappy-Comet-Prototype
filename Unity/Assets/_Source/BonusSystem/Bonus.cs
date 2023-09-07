using UnityEngine;
using Utils;
using Utils.Event;

namespace BonusSystem
{
    public class Bonus : MonoBehaviour
    {
        [SerializeField] private LayerMask player;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (player.Contains(other.gameObject.layer))
            {
                Signals.Get<SetObjectSignal>().Dispatch(gameObject);
            }
        }
    }
}