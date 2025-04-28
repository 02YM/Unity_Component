using UnityEngine;
using UnityEngine.InputSystem;

public class ScreenPoinToRay : MonoBehaviour
{
    public Camera cam;
    public GameObject effectPrefab; // 소환할 이펙트 프리팹
    public LayerMask layerMask;     // 쏠 레이가 맞출 레이어 선택
    public bool isClick = false;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && isClick == false) // 마우스 왼쪽 클릭
        {
            isClick = true;
            Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());

            if (Physics.Raycast(ray, out RaycastHit hitInfo, 100f, layerMask))
            {
                // 충돌 지점에 이펙트 소환
                Instantiate(effectPrefab, hitInfo.point, Quaternion.identity);

                Debug.Log($"Effect spawned at {hitInfo.point} on {hitInfo.collider.name}");
            }
            isClick = false;
        }
    }
}
