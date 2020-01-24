using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateAndRotate : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] UnityEngine.AI.NavMeshAgent agent;
    [SerializeField] float updateDelay = .3f;
    private void Reset()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FollowTarget", 0f, updateDelay);
    }
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
