using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_controller : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent navMeshAgent;
    public bool onoff_brains = true;
    public bool interesingPlayer = true;
    public bool needtoCompleteBrick = true;
    public GameObject enemy;
    public GameObject en_brick;
    public GameObject onArena;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onoff_brains == true)
        {
            if (needtoCompleteBrick == true)
            {
                DDD();
                navMeshAgent.SetDestination(GameObject.FindGameObjectWithTag("enemy_brick").transform.position);
                return;
            }
            navMeshAgent.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
            navMeshAgent.isStopped = false;
        }
        else
        {
            navMeshAgent.isStopped = true;
        }
    }


    void DDD()
    {

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("enemy_brick"))
        {
            Debug.Log("Он тут!");
            enemy.gameObject.SetActive(false);
            enemy.gameObject.SetActive(true);
            enemy.transform.position = onArena.transform.position;
            needtoCompleteBrick = false;
        }
    }
}
