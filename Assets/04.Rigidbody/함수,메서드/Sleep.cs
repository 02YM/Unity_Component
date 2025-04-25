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
            Debug.Log("슬립 중입니다.");
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            rigid.WakeUp();
            Debug.Log("깨었습니다.");
        }
    }
}
