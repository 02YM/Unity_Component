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

    // 카메라의 시작 방향값입니다.
    private Vector3 forward;
    // 타겟과의 오프셋 값입니다.
    private Vector3 offset;
    private float horizontal = 0;
    private float vertical = 0;
    private float minVerticalAngle = -90;
    private float maxVerticalAngle = 90;

    private float currentDistance = 0;
    void Start()
    {
        // 커서가 이동되지 않도록 처리하는 모드입니다.
        Cursor.lockState = CursorLockMode.Locked;

        // 커서를 보여주지 않도록 처리합니다.
        Cursor.visible = false;

        // 카메라의 시작 방향을 받아둡니다.
        forward = transform.forward;
        // 타겟과의 거리차를 구합니다. (0,0,0) - (3, 5, 0)
        offset = target.position - transform.position;

        // 카메라가 바라보는 방향에서 0,0,1 좌표를 바라보는 회전값을 구합니다.
        // (원점을 향하는 회전값을 구하는 코드입니다. )
        Quaternion rotation = Quaternion.FromToRotation(transform.forward,
                                                        Vector3.forward);
        // 원점상에서의 offset 값으로 변경합니다.
        offset = rotation * offset;
    }
    public Quaternion CalculateRotationMovedByTheXAxis()
    {
        // x축으로 이동되는 값을 누적합니다.
        horizontal += Input.GetAxis("Mouse X"); // -1, 0 1
        return Quaternion.Euler(0, horizontal, 0);
    }
    public Quaternion RotationValueOfTheCamera()
    {
        // 좌표계 연산은 곱셈 처리로 합니다. 
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
        // 최소 범위와 최대 범위내에 있도록 회전값을 고정합니다.
        vertical = Mathf.Clamp(vertical, minVerticalAngle, maxVerticalAngle);
        return Quaternion.Euler(vertical, 0, 0);
    }

    void LateUpdate()
    {
        Freelook();
    }
}


