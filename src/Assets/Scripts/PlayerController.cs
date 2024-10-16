using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float FORWARD_ACCELERATION = 30.0F;
    [SerializeField] float SIDE_ACCELERATION = 100.0f;
    [SerializeField] float FORWARD_DAMPING = 4.0f;
    [SerializeField] float SIDE_DAMPING = 4.0f;

    float forward = 0.0f;
    float side = 0.0f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal") ;
        float z = Input.GetAxis("Vertical");

        forward += z * FORWARD_ACCELERATION * Time.deltaTime;
        side += x * SIDE_ACCELERATION * Time.deltaTime;

        transform.Translate(Vector3.forward * forward * Time.deltaTime);
        transform.Rotate(Vector3.up, side * forward * Time.deltaTime);
        
        forward -= forward * FORWARD_DAMPING* Time.deltaTime;
        side -= side * SIDE_DAMPING * Time.deltaTime;
    
    }
}
