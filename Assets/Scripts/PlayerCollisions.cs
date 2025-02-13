using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Debug.Log("Finish !");
        }
        else if (other.CompareTag("Dammage"))
        {
            Debug.Log("Perdu !");
            gameManager.SpawnPlayer();
            Destroy(gameObject);
        }
    }
}