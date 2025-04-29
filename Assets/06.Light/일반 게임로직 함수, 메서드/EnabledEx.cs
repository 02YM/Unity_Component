using UnityEngine;

public class EnabledEx : MonoBehaviour
{
    [SerializeField] Light light;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            light.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            light.enabled = false;
        }
    }
}
