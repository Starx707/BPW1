using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Chase player (at all times)
    [SerializeField] private float _chaseSpeed;
    [SerializeField] private float _patrolSpeed;
    [SerializeField] private Player _target;
    [SerializeField] float _minimumDist;
    private float _distance;
    [SerializeField] Transform[] _patrolLoc;
    [SerializeField] float waitTime;
    int currentIndex;

    private void Update()
    {
        _distance = Vector2.Distance(transform.position, _target.transform.position); //calculates distance between itself and player

        if (_distance < 5) //chases the player from a certain distance
        {
            transform.position = Vector2.MoveTowards(transform.position, _target.transform.position, _chaseSpeed * Time.deltaTime);
        }

    }


}
