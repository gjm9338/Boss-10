using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spwaner : MonoBehaviour
{
    public Transform[] spawnPoint;
    float timer;

     void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.2f)
        {
            timer = 0;
            spawn();
            
        }

    }

    void spawn()
    {
       GameObject enemy= GameManager.instance.pool.Get(Random.Range(0,3));
        enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position;
    }
}
