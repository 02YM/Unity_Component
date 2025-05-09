using UnityEngine;

public class PhysicsRaycastAll : MonoBehaviour
{
    public float distance = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit[] hits = Physics.RaycastAll(ray,distance); // Ray�� ���� ��� ������Ʈ ������ ���� �迭

        if(hits.Length > 0)
        {
            foreach(RaycastHit hit in hits)
            {
                Debug.Log(hit.collider.name);
            }
        }

        Debug.DrawLine(transform.position, transform.forward * distance, Color.red);
    }
}
