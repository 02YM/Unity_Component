using UnityEngine;
using System.Collections;

public class ResetProjectionMatrix : MonoBehaviour
{
    public Camera cam; // ����� ī�޶�
    public float shakeDuration = 1.0f; // ��鸮�� �� �ð�
    public float shakeIntensity = 0.1f; // �ʱ� ��鸲 ����

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

            float currentIntensity = Mathf.Lerp(shakeIntensity, 0f, progress); // ���� ��������

            // ��¦ �����ϰ� ����
            Matrix4x4 shakenMatrix = originalMatrix;
            shakenMatrix.m01 = Random.Range(-currentIntensity, currentIntensity); // X-Y �� Ʋ��
            shakenMatrix.m10 = Random.Range(-currentIntensity, currentIntensity); // Y-X �� Ʋ��
            cam.projectionMatrix = shakenMatrix;

            yield return null;
        }

        // ����
        cam.ResetProjectionMatrix();
        isShaking = false;
    }
}
