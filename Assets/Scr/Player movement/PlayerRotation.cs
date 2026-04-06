using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotation : MonoBehaviour
{

    private InputAction _cameraRotateAction;
    private float _xRotation = 0f;
    private float _yRotation = 0f;
    public float sensitivity = 0.1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _cameraRotateAction = InputSystem.actions.FindAction("Look");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cameraMovement = _cameraRotateAction.ReadValue<Vector2>();
        
        _xRotation -= cameraMovement.y * sensitivity;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
        
        _yRotation += cameraMovement.x * sensitivity;
        
        transform.rotation = Quaternion.Euler(_xRotation, _yRotation, 0f);
    }
}
