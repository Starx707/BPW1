using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum EnemyState
    {
        Patrolling,
        Chasing,
    }

    [SerializeField] private EnemyState _state = EnemyState.Patrolling;

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

        // if (_distance < 0.25) { _state = EnemyState.Attacking }
        if (_distance < 3.5)
        {
            _state = EnemyState.Chasing;
        }
        else
        {
            _state = EnemyState.Patrolling;
        }

        switch (_state)
        {
            case EnemyState.Chasing:
                _seesPlayer = true; // is this used for anything?
                transform.position = Vector2.MoveTowards(transform.position, _target.transform.position, _chaseSpeed * Time.deltaTime);
                break;
            case EnemyState.Patrolling:
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
                        //Debug.Log("Changing course");
                    }
                    else
                    {
                        //Debug.Log("skipped");
                    }
                }
                break;
        }

    }

    IEnumerator Wait() 
    {
        yield return new WaitForSeconds(_waitTime);
        if (_currentIndex + 1 < _patrolLoc.Length)
        {
            _currentIndex++;
            _once = false;
        }
        else if (_currentIndex + 1 >= _patrolLoc.Length)
        {
            Debug.Log(_currentIndex);
            _currentIndex = 0;
            _once = false;
        }
        _once = false;
    }


}
