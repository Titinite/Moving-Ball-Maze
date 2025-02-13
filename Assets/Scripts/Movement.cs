using UnityEngine;

public class Movement : MonoBehaviour
{
    public int rotationSpeed = 8;

    void Update()
    {
        int rotationX = 0;
        int rotationZ = 0;

        if (Input.GetKey(KeyCode.W)) rotationX = rotationSpeed;
        if (Input.GetKey(KeyCode.S)) rotationX = -rotationSpeed;
        if (Input.GetKey(KeyCode.A)) rotationZ = rotationSpeed;
        if (Input.GetKey(KeyCode.D)) rotationZ = -rotationSpeed;

        transform.Rotate(new Vector3(rotationX, 0, rotationZ) * rotationSpeed * Time.deltaTime);
    }
}