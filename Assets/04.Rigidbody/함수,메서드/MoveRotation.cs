using UnityEngine;

public class MoveRotation : MonoBehaviour
{
    Rigidbody rigid;
    public Vector3 eulerAngle = new Vector3(0, 100, 0);

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 angleVelocity = eulerAngle * Input.GetAxis("Horizontal") * Time.fixedDeltaTime;

        Quaternion delta = Quaternion.Euler(angleVelocity);

        rigid.MoveRotation(transform.rotation * delta);
    }
}
