using UnityEngine;

public class CalculateFrustumCorners : MonoBehaviour
{
    public Camera cam;
    public GameObject effectPrefab; // ������ ����Ʈ ������
    public float spawnDistance = 20f; // ī�޶�κ��� �󸶳� ������ �Ÿ����� ��������
    public int effectsPerEdge = 10; // �� ���� �� ���� ������
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

        // �������� �ڳ� ��� (Far Plane)
        cam.CalculateFrustumCorners(
            new Rect(0, 0, 1, 1),
            spawnDistance,
            Camera.MonoOrStereoscopicEye.Mono,
            corners
        );

        // ���� ���� -> ���� ���� ��ȯ
        for (int i = 0; i < 4; i++)
        {
            corners[i] = cam.transform.TransformPoint(corners[i]);
        }

        // 4���� ���� ���� ����Ʈ ��ġ
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
