using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Zombie: MonoBehaviour
{
    public Transform Player;
    private Rigidbody rb;
    public NavMeshAgent _agent;
    private Vector2 movement;
    private float distance; 
    
    public float moveSpeed=5.0f;

    void Start()
    {
    
    }
    void Update()
    {
      // distance=Vector3.Distance(Player.transform.position,this.transform.position);
       _agent.SetDestination(Player.transform.position);


        }

}