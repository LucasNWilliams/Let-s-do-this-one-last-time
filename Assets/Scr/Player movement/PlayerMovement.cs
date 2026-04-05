using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 _vector3;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _vector3 = new Vector3(.1f, .1f, .1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += _vector3;
        // Debug.Log("Transform Position: " + transform.position);
    }
}
