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

        // Aseg�rate de que el NavMeshAgent est� asignado
        if (agent == null)
        {
            agent = GetComponent<NavMeshAgent>();
        }
    }

    void Update()
    {
        // Verifica que el agente y el jugador est�n presentes
        if (agent != null && agent.isActiveAndEnabled && player != null)
        {
            // Aseg�rate de que el agente est� en una superficie de NavMesh
            if (agent.isOnNavMesh)
            {
                agent.SetDestination(player.transform.position);
            }
            else
            {
                Debug.LogWarning("NavMeshAgent no est� en una superficie de NavMesh.");
            }
        }
    }
}
