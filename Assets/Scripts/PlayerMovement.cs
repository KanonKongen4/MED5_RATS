using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 4;
    private Vector2 _movedirection;

    public InputActionReference move;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _movedirection = move.action.ReadValue<Vector2>();
        transform.Translate(_movedirection * movementSpeed);
    }
}
