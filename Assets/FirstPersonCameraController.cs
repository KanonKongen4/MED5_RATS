using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonCameraController : MonoBehaviour
{
    public float sensitivity = 2.0f;
    public float smoothing = 2.0f;

    private Vector2 smoothMouseDelta = Vector2.zero;
    

    private GameObject player;

    private InputAction lookAction;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        player = GameObject.FindWithTag("Player"); // Change "Player" to the name of your player character

        
    }

 

    private void Update()
    {
     
    }
}
