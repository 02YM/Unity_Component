using UnityEngine;

public class AddRelativeForce : MonoBehaviour
{
    Rigidbody2D rigid;
    [SerializeField] float thrust = 500;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rigid.AddRelativeForce(Vector2.right * thrust);
        }
    }
}
