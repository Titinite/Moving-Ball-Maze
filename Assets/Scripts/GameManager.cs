using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab; 
    public Transform spawnPoint;

    private GameObject currentPlayer;

    void Start()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        if (currentPlayer != null)
        {
            Destroy(currentPlayer);
        }
        currentPlayer = Instantiate(playerPrefab, spawnPoint.position, Quaternion.identity);
    }
}