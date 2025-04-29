using UnityEngine;

public class ResetEx : MonoBehaviour
{

    [SerializeField] Light light;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            light.Reset();
            light.type = LightType.Directional;
        }

    }
}
