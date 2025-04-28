using UnityEngine;

public class SweepTest : MonoBehaviour
{

    Rigidbody rigid;
    [SerializeField] float distance = 10f;
    [SerializeField] Transform target;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(rigid.SweepTest(transform.forward, out hit, distance))
        {
            Debug.Log("충돌된 게임 오브젝트 : "+hit.transform.name);
            Debug.Log("충돌된 거리 : " + hit.distance);            
        }
        Debug.DrawLine(transform.position, target.transform.position, Color.red);
    }
}
