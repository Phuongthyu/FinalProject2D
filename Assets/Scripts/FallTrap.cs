using System.Collections;
using UnityEngine;

public class FallTrap : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rg;
    [SerializeField] private float delayTime = 3f; 

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        rg.isKinematic = true; 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
        {
            StartCoroutine(ActivateTrapAfterDelay()); 
        }
    }

    IEnumerator ActivateTrapAfterDelay()
    {
        yield return new WaitForSeconds(delayTime); 
        rg.isKinematic = false; 
    }
}