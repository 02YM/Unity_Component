using UnityEngine;

public class SpriteRendererEX : MonoBehaviour
{
    SpriteRenderer m_spriteRenderer;

    void Start()
    {
        m_spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N))// enabled on
        {
            m_spriteRenderer.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.F))// enabled off
        {
            m_spriteRenderer.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.C))// color
        {
            m_spriteRenderer.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.M))// material
        {
            Debug.Log($"{m_spriteRenderer.material.name}"); 
        }

        if (Input.GetKeyDown(KeyCode.B)) // bounds
        {
            Debug.Log($"{m_spriteRenderer.bounds}");
        }

        if (Input.GetKeyDown(KeyCode.S)) // SortingOrder
        {
            Debug.Log($"{m_spriteRenderer.sortingOrder}");
        }


    }
}
