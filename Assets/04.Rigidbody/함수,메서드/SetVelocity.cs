using UnityEngine;

public class SetVelocity : MonoBehaviour
{
    Rigidbody rigid;
    public Vector3 velocity = new Vector3(10, 5, 0);

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.linearVelocity = velocity;
    }
}
