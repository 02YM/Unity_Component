using UnityEngine;

public class AddTorque : MonoBehaviour
{

    private Rigidbody rigid;
    [SerializeField] float thrust = 20;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
            rigid.AddTorque(Vector3.up * thrust);
    }
}
