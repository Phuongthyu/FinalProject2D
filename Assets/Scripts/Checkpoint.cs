using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1") || other.CompareTag("Player2"))
        {
            
            other.GetComponent<PlayerHealth>().respawnPosition = transform.position;
        }
    }
}

