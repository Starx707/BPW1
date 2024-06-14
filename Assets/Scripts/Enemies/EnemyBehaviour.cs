using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavriour : MonoBehaviour
{
    public bool playerSeen { get; private set; }
    public Vector2 playerLocation { get; private set; } //DirectionToPlayer

    [SerializeField]
    private float awarenessDistance;
    private Transform playerTransform;

    // Start is called before the first frame update
    private void Awake()
    {
        playerTransform = FindObjectOfType<playerMovement>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vecPlayerToEnemy = playerTransform.position - transform.position;
        playerLocation = vecPlayerToEnemy.normalized;

        if (vecPlayerToEnemy.magnitude <= awarenessDistance)
        {
            playerSeen = true;
        }
        else
        {
            playerSeen = false;
        }
    }
}
