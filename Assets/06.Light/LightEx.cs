using UnityEngine;

public class LightEx : MonoBehaviour
{
    public Light directionalLight;
    public float dayDuration = 10f;

    private float currentTime = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (directionalLight == null) return;

        currentTime += Time.deltaTime;

        float timePercent = (currentTime % dayDuration) / dayDuration; // 0~1

        directionalLight.transform.rotation = Quaternion.Euler(new Vector3((timePercent * 360f) - 90f, 170f, 0));

        if(timePercent <= 0.25F)
        {
            directionalLight.intensity = Mathf.Lerp(0f, 1f, timePercent * 4f);
        }
        else if(timePercent <= 0.75f)
        {
            directionalLight.intensity = 1f;
        }
        else
        {
            directionalLight.intensity = Mathf.Lerp(1f, 0f, (timePercent-0.75f) * 4f);
        }
    }
}
