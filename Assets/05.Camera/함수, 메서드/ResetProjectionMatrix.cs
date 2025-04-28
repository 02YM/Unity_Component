using UnityEngine;
using System.Collections;

public class ResetProjectionMatrix : MonoBehaviour
{
    public Camera cam; // 사용할 카메라
    public float shakeDuration = 1.0f; // 흔들리는 총 시간
    public float shakeIntensity = 0.1f; // 초기 흔들림 강도

    private bool isShaking = false;

    private void Start()
    {
        TriggerExplosionShake();
    }

    public void TriggerExplosionShake()
    {
        if (!isShaking)
        {
            StartCoroutine(ShakeCoroutine());
        }
    }

    private IEnumerator ShakeCoroutine()
    {
        isShaking = true;

        float elapsed = 0f;
        Matrix4x4 originalMatrix = cam.projectionMatrix;

        while (elapsed < shakeDuration)
        {
            elapsed += Time.deltaTime;
            float progress = elapsed / shakeDuration;

            float currentIntensity = Mathf.Lerp(shakeIntensity, 0f, progress); // 점점 약해지게

            // 살짝 랜덤하게 흔들기
            Matrix4x4 shakenMatrix = originalMatrix;
            shakenMatrix.m01 = Random.Range(-currentIntensity, currentIntensity); // X-Y 축 틀기
            shakenMatrix.m10 = Random.Range(-currentIntensity, currentIntensity); // Y-X 축 틀기
            cam.projectionMatrix = shakenMatrix;

            yield return null;
        }

        // 복구
        cam.ResetProjectionMatrix();
        isShaking = false;
    }
}
