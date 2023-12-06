using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.CompleteLevel();
        }
    }
}
