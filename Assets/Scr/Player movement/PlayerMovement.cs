using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 _velocity;
    private InputAction moveAction;
    private InputAction interactAction;
    public float movementSpeed = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        interactAction = InputSystem.actions.FindAction("Interact");
        _velocity = new Vector3(.1f, .1f, .1f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(moveValue.x * movementSpeed * Time.deltaTime, 0, moveValue.y * movementSpeed * Time.deltaTime);
        // transform.position += _velocity;
        if (interactAction.WasPressedThisFrame())
        {
            Debug.Log("Move Value: " + moveValue);
        }
    }
}
