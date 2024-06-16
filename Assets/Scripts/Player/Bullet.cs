using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEft;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyMovement>())
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
        Debug.Log(collision.gameObject);
    }
}
