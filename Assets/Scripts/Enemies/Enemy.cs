using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Chase player (at all times)
    [SerializeField] private float _chaseSpeed;
    [SerializeField] private float _patrolSpeed;
    [SerializeField] private Player _target;
    private float _distance;

    [SerializeField] Transform[] _patrolLoc;
    [SerializeField] float _waitTime;
    int _currentIndex;
    bool _seesPlayer = false;
    bool _once = false;

    private void Update()
    {
        _distance = Vector2.Distance(transform.position, _target.transform.position); //calculates distance between itself and player

        if (_distance < 3.5) //chases the player from a certain distance
        {
            _seesPlayer = true;
            transform.position = Vector2.MoveTowards(transform.position, _target.transform.position, _chaseSpeed * Time.deltaTime);
        }
        else
        {
            _seesPlayer = false;
            if (transform.position != _patrolLoc[_currentIndex].position) 
            {
                transform.position = Vector2.MoveTowards(transform.position, _patrolLoc[_currentIndex].position, _patrolSpeed * Time.deltaTime);
            }
            else 
            {
                Debug.Log(_once); //for some reason stays true and....
                if (_once == false)
                {
                    _once = true;
                    StartCoroutine(Wait());
                    Debug.Log("Changing course");
                }
                else
                {
                    Debug.Log("skipped");//...ends up skipping the remaining code
                }
            }
        }

    }

    IEnumerator Wait() //...doesn't even get here
    {
        yield return new WaitForSeconds(_waitTime);
        if (_currentIndex + 1 < _patrolLoc.Length)
        {
            _currentIndex++;
            _once = false;
            Debug.Log(_once + "row 60");
        }
        else if (_currentIndex >= _patrolLoc.Length)
        {
            Debug.Log(_currentIndex);
            _currentIndex = 0;
            _once = false;
        }
        _once = false;
    }


}
