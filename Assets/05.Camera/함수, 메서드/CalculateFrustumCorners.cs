using UnityEngine;

public class CalculateFrustumCorners : MonoBehaviour
{
    public Camera cam;
    public GameObject effectPrefab; // 생성할 이펙트 프리팹
    public float spawnDistance = 20f; // 카메라로부터 얼마나 떨어진 거리에서 생성할지
    public int effectsPerEdge = 10; // 한 변에 몇 개를 만들지
 //   [Particle]--[Particle]--[Particle]--[Particle]
 //   |                                       |
 //   [Particle][Particle]
 //   |                                       |
 //   [Particle]--[Particle]--[Particle]--[Particle]


    private void Start()
    {
        SpawnEdgeEffects();
    }

    void SpawnEdgeEffects()
    {
        if (cam == null || effectPrefab == null)
            return;

        Vector3[] corners = new Vector3[4];

        // 프러스텀 코너 계산 (Far Plane)
        cam.CalculateFrustumCorners(
            new Rect(0, 0, 1, 1),
            spawnDistance,
            Camera.MonoOrStereoscopicEye.Mono,
            corners
        );

        // 로컬 공간 -> 월드 공간 변환
        for (int i = 0; i < 4; i++)
        {
            corners[i] = cam.transform.TransformPoint(corners[i]);
        }

        // 4개의 변을 따라 이펙트 배치
        for (int i = 0; i < 4; i++)
        {
            Vector3 start = corners[i];
            Vector3 end = corners[(i + 1) % 4];

            for (int j = 0; j <= effectsPerEdge; j++)
            {
                float t = (float)j / effectsPerEdge;
                Vector3 spawnPos = Vector3.Lerp(start, end, t);

                Instantiate(effectPrefab, spawnPos, Quaternion.identity);
            }
        }
    }
}
