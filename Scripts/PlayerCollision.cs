using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController playerController;
    
    void Start() {
        playerController = GetComponent<PlayerController>();
    }

    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            playerController.enabled = false;
            GameManager.EndGame();
        }
    }
}
