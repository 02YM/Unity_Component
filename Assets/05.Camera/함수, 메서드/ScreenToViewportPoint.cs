using UnityEngine;

public class ScreenToViewportPoint : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

        Vector3 mouseViewportPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);

        if (mouseViewportPos.x < 0.5f)
            Debug.Log("왼쪽 절반");
        else
            Debug.Log("오른쪽 절반");

        if (mouseViewportPos.y < 0.5f)
            Debug.Log("아래쪽 절반");
        else
            Debug.Log("위쪽 절반");

    }
}
