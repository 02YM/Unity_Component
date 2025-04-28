using UnityEngine;

public class ScreenToWorldPoint : MonoBehaviour
{
    Vector2 mousePos;
    Camera Camera;

    void Start()
    {
        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {                   
        if(Input.GetMouseButton(0))
        {
            mousePos = Input.mousePosition.normalized;
            mousePos = Camera.ScreenToWorldPoint(Input.mousePosition);
            
            transform.position = Input.mousePosition;
            Debug.Log(Input.mousePosition);
        }                
    }
}
