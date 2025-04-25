using UnityEngine;

public class WorldToViewportPoint : MonoBehaviour
{
    public Transform enemy;
    public RectTransform ui;
    public Canvas canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewportPos = Camera.main.WorldToViewportPoint(enemy.position);

        
        if(viewportPos.z < 0f || (viewportPos.x >= 0 && viewportPos.x <= 1 && viewportPos.y >=0 && viewportPos.y<=1))
        {
            ui.gameObject.SetActive(false);
            Debug.Log("화면 안에 적이 있습니다.");
            return;
        }

        // 화면 안에 적이 없습니다.
        ui.gameObject.SetActive(true);
        Debug.Log("화면 안에 적이 없습니다.");

        // 뷰포트 범위를 벗어난 방향 정규화
        Vector2 direction = new Vector2(viewportPos.x - 0.5f, viewportPos.y - 0.5f).normalized;

        // 화살표를 캔버스 가운데에서 방향대로 위치시키기
        Vector2 canvasCenter = canvas.GetComponent<RectTransform>().sizeDelta / 2f;
        ui.anchoredPosition = direction * 250f; // 250은 거리 (UI 기준)

        // 회전
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        ui.rotation = Quaternion.Euler(0, 0, angle - 90f);

        /*
         * WorldToViewportPoint는 오브젝트가 화면 어디쯤 있는지 비율로 반환해줘.
            (0.5, 0.5): 화면 정중앙
            (0, 0): 좌하단
            (1, 1): 우상단

            만약 (x < 0 || x > 1 || y < 0 || y > 1)이면 화면 밖에 있음!
            이걸로 경고 화살표, 미니맵 위치 표시, HUD 추적기 등을 만들 수 있어.
         */
    }
}
