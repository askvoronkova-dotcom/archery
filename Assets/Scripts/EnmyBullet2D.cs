using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]

public class EnmyBullet2D : MonoBehaviour
{
    private int lifetime = 1;
    public int damage = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerHealth player))
        {
            if (player != null)
            {
                player.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
