using System;
using UnityEngine;
using Utils;
using Utils.Event;

namespace LevelSystem
{
    public class DisableObject : MonoBehaviour
    {
        private const float Distance = -0.5f;
        
        private void Update()
        {
            if (transform.position.x < Camera.main.ViewportToWorldPoint(new Vector3(0, 0)).x + Distance)
            {
                Signals.Get<SetObjectSignal>().Dispatch(gameObject);
            }
        }
    }
}