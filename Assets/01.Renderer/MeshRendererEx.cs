using UnityEngine;

public class MeshRendererEx : MonoBehaviour
{
    MeshRenderer m_meshRenderer;
    
    void Start()
    {
        m_meshRenderer = GetComponent<MeshRenderer>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            m_meshRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
            m_meshRenderer.receiveShadows = false;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            m_meshRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            m_meshRenderer.receiveShadows = true;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            foreach(var go in m_meshRenderer.materials)
            {
                Debug.Log($"{go}");
            }
        }
    }
}
