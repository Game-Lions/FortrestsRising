using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player hit a wall
        if (collision.gameObject.CompareTag("Border")) // משתמשים ב-collision
        {
            Debug.Log("Player hit the Border!");
            Destroy(gameObject);
        }
    }
}
