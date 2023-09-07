using UnityEngine;

namespace PlayerSystem
{
    public class Movement
    {
        public void Move(Rigidbody2D rb, Transform transform, float speed) 
            => rb.velocity = new Vector2(speed, transform.position.y);

        public void Fly(Rigidbody2D rb) 
            => rb.gravityScale *= -1;
    }
}
