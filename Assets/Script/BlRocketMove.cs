using UnityEditor.Callbacks;
using UnityEngine;

public class BlRocketMove : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float forceValue = 1f;

    [SerializeField]
    private float torqueValue = 0.15f;


    [SerializeField]
    private float constantForceValue = 15f;
    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.forward * constantForceValue, ForceMode.VelocityChange);
        Vector3 currentRotation = transform.eulerAngles;
        transform.eulerAngles = new Vector3(currentRotation.x, currentRotation.y, 0f);
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(transform.forward * forceValue, ForceMode.VelocityChange);

        float horizontalInput = Input.GetAxis("Horizontal");
        rb.AddTorque(transform.right * torqueValue * horizontalInput, ForceMode.VelocityChange);
    }



}
