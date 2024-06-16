using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 100f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }

    void FixedUpdate()
    {
        float moveDirection = Input.GetAxis("Vertical");
        float turnDirection = Input.GetAxis("Horizontal");

        Vector3 move = transform.forward * moveDirection * speed * Time.deltaTime;
        rb.MovePosition(rb.position + move);

        float turn = turnDirection * turnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }

    public bool IsMoving()
    {
        return Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0;
    }
}