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

    void Update()
    {
        if (currentPlayer.transform.position.y < -10)
        {
            SpawnPlayer();
        }
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