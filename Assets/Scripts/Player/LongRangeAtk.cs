using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongRangeAtk : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    private Vector3 MousePos;

    public float bulletForce = 1f; //try out lower speeds


    private void Start()
    {
        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePos = new Vector3(pos.x, pos.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }

    void Attack()
    { 
        var dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //var rot = Quaternion.Euler(0f, 0f, dir.z);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion rot = Quaternion.AngleAxis(angle, Vector3.forward);
        //change firepoint.position to player.position
        GameObject bullet = Instantiate(bulletPrefab, transform.position,rot);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        //rb.AddForce(Vector3.forward* bulletForce);
        rb.AddForce(dir.normalized * bulletForce, ForceMode2D.Impulse);
    }
}
