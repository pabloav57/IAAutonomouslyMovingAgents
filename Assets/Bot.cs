using UnityEngine;
using UnityEngine.AI;

public class bot : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    void Seek(Vector3 location)
    {
        agent.SetDestination(location);
    }

    void Flee(Vector3 location)
    {
        Vector3 fleeVector = location - this.transform.position;
        agent.SetDestination(this.transform.position - fleeVector);
    }
    // Update is called once per frame
    void Update()
    {
        Flee(target.transform.position);
    }
}
