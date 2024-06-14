using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEft;
    [SerializeField] private int _bulletDmg;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyMovement>())
        {
            //GameObject effect = Instantiate(hitEft, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            print(collision.gameObject);
        }
        Debug.Log(collision.gameObject);
    }
}
