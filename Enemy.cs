//attach it to the gameobject that you want to follow you.
//the gameobject MUST have attached a nav mesh agent.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    GameObject Player;

    NavMeshAgent NMA;

    void Start()
    {
        NMA = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        NMA.destination = Player.transform.position;
    }
}
