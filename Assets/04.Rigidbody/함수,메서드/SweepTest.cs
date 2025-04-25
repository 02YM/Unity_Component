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
            Debug.Log("�浹�� ���� ������Ʈ : "+hit.transform.name);
            Debug.Log("�浹�� �Ÿ� : " + hit.distance);            
        }
        Debug.DrawLine(transform.position, target.transform.position, Color.red);
    }
}
