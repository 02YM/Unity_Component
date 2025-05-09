using UnityEngine;

public class PhysicsOverlapBox : MonoBehaviour
{

    public Vector3 boxCenterOffset; // 박스 중심 위치
    public Vector3 boxHalfExtents = new Vector3(1, 1, 1); // 박스 크기의 절반
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
        // 월드 기준 박스 중심 위치 계산
        Vector3 center = transform.position + transform.rotation * boxCenterOffset;
        Quaternion orientation = transform.rotation;

        lastCenter = center;
        lastOrientation = orientation;

        // 박스 영역 내의 모든 물체 감지
        lastHits = Physics.OverlapBox(center, boxHalfExtents, orientation, targetLayer);

        foreach(Collider hit in lastHits)
        {
            Debug.Log("감지된 대상" + hit.name);
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
