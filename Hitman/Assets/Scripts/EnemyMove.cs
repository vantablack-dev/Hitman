using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMove : MonoBehaviour
{
    public List<Transform> wayPoint;
    public int curWayPoint;

    Animator anim;
    public float speed;

    NavMeshAgent agent;

    void Start() {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update() {
        Patrol();
    }

    void Patrol() {
        if (wayPoint.Count > 1)
        {
            if (wayPoint.Count > curWayPoint) {
                agent.SetDestination(wayPoint[curWayPoint].position);
                float distance = Vector3.Distance(transform.position, wayPoint[curWayPoint].position);

                if (distance > 2.5f)
                {
                    //anim.SetFloat("Speed", speed);
                    speed += Time.deltaTime * 3;
                }
                else if (distance < 2.5f && distance >= 1f)
                {
                    Vector3 direction = (wayPoint[curWayPoint].position - transform.position).normalized;
                    Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
                    transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation,  Time.deltaTime * 10);   
                }
                else
                {
                    curWayPoint++;
                }

            }
            else if (wayPoint.Count == curWayPoint) {
                curWayPoint = 0;
            }
                
        }
        else if (wayPoint.Count == 1)
        { }
        else { }
        speed = Mathf.Clamp(speed,0,1);
    }
}
