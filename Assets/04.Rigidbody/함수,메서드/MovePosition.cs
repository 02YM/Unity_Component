using UnityEngine;

public class MovePosition : MonoBehaviour
{
    Rigidbody rigid;

    [SerializeField] float moveSpeed;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;

        //input = transform.TransformDirection(input);
        rigid.MovePosition(transform.position + input * Time.fixedDeltaTime * moveSpeed);
    }
    
}
