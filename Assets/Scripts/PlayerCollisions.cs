using UnityEngine.SceneManagement;
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
            SceneManager.LoadScene("Win menu");
        }
        else if (other.CompareTag("Dammage"))
        {
            gameManager.SpawnPlayer();
            Destroy(gameObject);
        }
    }
}