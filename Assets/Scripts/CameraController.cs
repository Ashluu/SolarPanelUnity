using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of camera movement
    public float rotationSpeed = 5f; // Speed of camera rotation

    void Update()
    {
        // Rotate camera based on mouse movement
        RotateCamera();

        // Move camera based on arrow keys
        MoveCamera();
    }

    void RotateCamera()
    {
        // Get mouse movement
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

        // Rotate the camera around the Y-axis
        transform.Rotate(Vector3.up, mouseX, Space.World);

        // Rotate the camera around the X-axis (clamped to prevent flipping)
        float newRotationX = transform.eulerAngles.x - mouseY;
        transform.rotation = Quaternion.Euler(newRotationX, transform.eulerAngles.y, 0f);
    }

    void MoveCamera()
    {
        // Get input from arrow keys for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction based on input
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Move the camera in the calculated direction
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
