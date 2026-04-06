using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 _velocity;
    private Rigidbody _rb;
    private InputAction _moveAction;
    private InputAction _interactAction;
    public float movementSpeed = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.freezeRotation = true;
        _moveAction = InputSystem.actions.FindAction("Move");
        _interactAction = InputSystem.actions.FindAction("Interact");
        _velocity = new Vector3(.1f, .1f, .1f);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 moveValue = _moveAction.ReadValue<Vector2>();
        Vector3 playerVelocity = transform.forward * moveValue.y + transform.right * moveValue.x;
        _rb.AddForce(playerVelocity.normalized * movementSpeed, ForceMode.Force);
        
        
        // transform.position += _velocity;
        if (_interactAction.WasPressedThisFrame())
        {
            Debug.Log("Move Value: " + moveValue);
        }
    }
}
