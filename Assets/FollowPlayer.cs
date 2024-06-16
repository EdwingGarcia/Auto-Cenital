using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public NavMeshAgent agent;
    private GameObject player;

    void Start()
    {
        // Encuentra al jugador por la etiqueta "Player"
        player = GameObject.FindGameObjectWithTag("Player");

        // Asegúrate de que el NavMeshAgent esté asignado
        if (agent == null)
        {
            agent = GetComponent<NavMeshAgent>();
        }
    }

    void Update()
    {
        // Verifica que el agente y el jugador estén presentes
        if (agent != null && agent.isActiveAndEnabled && player != null)
        {
            // Asegúrate de que el agente esté en una superficie de NavMesh
            if (agent.isOnNavMesh)
            {
                agent.SetDestination(player.transform.position);
            }
            else
            {
                Debug.LogWarning("NavMeshAgent no está en una superficie de NavMesh.");
            }
        }
    }
}
