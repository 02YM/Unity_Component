using UnityEngine;

public class PhysicsOverlapBox : MonoBehaviour
{

    public Vector3 boxCenterOffset; // �ڽ� �߽� ��ġ
    public Vector3 boxHalfExtents = new Vector3(1, 1, 1); // �ڽ� ũ���� ����
    public LayerMask targetLayer;

    private Vector3 lastCenter;
    private Quaternion lastOrientation;
    private Collider[] lastHits;

    void Start()
    {
        boxCenterOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // ���� ���� �ڽ� �߽� ��ġ ���
        Vector3 center = transform.position + transform.rotation * boxCenterOffset;
        Quaternion orientation = transform.rotation;

        lastCenter = center;
        lastOrientation = orientation;

        // �ڽ� ���� ���� ��� ��ü ����
        lastHits = Physics.OverlapBox(center, boxHalfExtents, orientation, targetLayer);

        foreach(Collider hit in lastHits)
        {
            Debug.Log("������ ���" + hit.name);
        }

        //DebugDrawBox(center, boxHalfExtents, orientation, Color.red);
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Matrix4x4 cubeTransform = Matrix4x4.TRS(lastCenter, lastOrientation, boxHalfExtents * 2);
        Gizmos.matrix = cubeTransform;
        Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
    }
}
