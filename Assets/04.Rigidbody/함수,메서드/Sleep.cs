using UnityEngine;

public class Sleep : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            rigid.Sleep();
            Debug.Log("���� ���Դϴ�.");
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            rigid.WakeUp();
            Debug.Log("�������ϴ�.");
        }
    }
}
