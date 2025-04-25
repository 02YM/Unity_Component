using UnityEngine;

public class WorldToScreenPoint : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 2f, 0);
    public RectTransform ui;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(target.position + offset);

        ui.position = screenPos;
    }
}
