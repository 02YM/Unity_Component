using UnityEngine;

public enum CameraState
{
    Freelook,
    Targeting,
    Blending,
}

public class CameraEX : MonoBehaviour
{
    private Camera gameCamera;
    [SerializeField] private CameraState state = CameraState.Freelook;

    [SerializeField] private Transform target;

    // ī�޶��� ���� ���Ⱚ�Դϴ�.
    private Vector3 forward;
    // Ÿ�ٰ��� ������ ���Դϴ�.
    private Vector3 offset;
    private float horizontal = 0;
    private float vertical = 0;
    private float minVerticalAngle = -90;
    private float maxVerticalAngle = 90;

    private float currentDistance = 0;
    void Start()
    {
        // Ŀ���� �̵����� �ʵ��� ó���ϴ� ����Դϴ�.
        Cursor.lockState = CursorLockMode.Locked;

        // Ŀ���� �������� �ʵ��� ó���մϴ�.
        Cursor.visible = false;

        // ī�޶��� ���� ������ �޾ƵӴϴ�.
        forward = transform.forward;
        // Ÿ�ٰ��� �Ÿ����� ���մϴ�. (0,0,0) - (3, 5, 0)
        offset = target.position - transform.position;

        // ī�޶� �ٶ󺸴� ���⿡�� 0,0,1 ��ǥ�� �ٶ󺸴� ȸ������ ���մϴ�.
        // (������ ���ϴ� ȸ������ ���ϴ� �ڵ��Դϴ�. )
        Quaternion rotation = Quaternion.FromToRotation(transform.forward,
                                                        Vector3.forward);
        // �����󿡼��� offset ������ �����մϴ�.
        offset = rotation * offset;
    }
    public Quaternion CalculateRotationMovedByTheXAxis()
    {
        // x������ �̵��Ǵ� ���� �����մϴ�.
        horizontal += Input.GetAxis("Mouse X"); // -1, 0 1
        return Quaternion.Euler(0, horizontal, 0);
    }
    public Quaternion RotationValueOfTheCamera()
    {
        // ��ǥ�� ������ ���� ó���� �մϴ�. 
        Quaternion xRotation = CalculateRotationMovedByTheXAxis();
        Quaternion yRotation = CalculateRotationMovedByTheYAxis();
        Vector3 lookAt = xRotation * forward;
        Quaternion lookRotation = Quaternion.LookRotation(lookAt) * yRotation;
        return lookRotation;
    }
    public void Freelook()
    {
        transform.rotation = RotationValueOfTheCamera();
    }
    public Quaternion CalculateRotationMovedByTheYAxis()
    {
        vertical += Input.GetAxis("Mouse Y");
        // �ּ� ������ �ִ� �������� �ֵ��� ȸ������ �����մϴ�.
        vertical = Mathf.Clamp(vertical, minVerticalAngle, maxVerticalAngle);
        return Quaternion.Euler(vertical, 0, 0);
    }

    void LateUpdate()
    {
        Freelook();
    }
}


