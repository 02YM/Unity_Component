using UnityEngine;

public class ViewportToScreenPoint : MonoBehaviour
{
    public RectTransform ui;
    public Canvas canvas;

    void Start()
    {
        Vector3 viewportPos = new Vector3(0.5f, 0.5f, 0);

        Vector3 screenPos = Camera.main.ViewportToScreenPoint(viewportPos);

        ui.position = screenPos;
    }
}
