using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{

    public float speed;
    private float waitTime;
    public float startWaitTime;
   

    public Transform[] movePoints;
    private int randomPoints;
    public Animator animator;

    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, movePoints[randomPoints].position, speed * Time.deltaTime);
        Vector2 direction = movePoints[randomPoints].transform.position - transform.position;
        agent.SetDestination(movePoints[randomPoints].position);
        if (Vector2.Distance(transform.position, movePoints[randomPoints].position) < 0.2f) 
        {
            if(waitTime <= 0)
            {
                randomPoints = Random.Range(0, movePoints.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -=Time.deltaTime;
            }
            

        }
        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Speed", direction.sqrMagnitude);

        
        

    }
}
