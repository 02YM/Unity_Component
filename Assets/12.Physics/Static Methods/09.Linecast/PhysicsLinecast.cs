using UnityEngine;

public class PhysicsLinecast : MonoBehaviour
{

    public Transform startPoint;
    public Transform endPoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Linecast(startPoint.position, endPoint.position, out hit))
        {
            Debug.Log("�浹�� ������Ʈ" + hit.collider.name);
        }
        else
        {
            Debug.Log("�浹 ����");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(startPoint.position, endPoint.position);
    }
}
