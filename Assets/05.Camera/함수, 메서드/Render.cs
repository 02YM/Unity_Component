using UnityEngine;

public class Render : MonoBehaviour
{
    [SerializeField] Camera myCamera;

    void Start()
    {
        Camera myCamera = Camera.main;
        RenderTexture rt = new RenderTexture(1920, 1080, 24);
        rt.Create();

        Texture2D captureImage = CaptureCameraImage(myCamera, rt);
        byte[] bytes = captureImage.EncodeToPNG();
        System.IO.File.WriteAllBytes(Application.dataPath + "/Captured.png", bytes);
    }

    // Update is called once per frame
    void Update()
    {

    }

    Texture2D CaptureCameraImage(Camera cam, RenderTexture targetTexture)
    {
        // ���
        RenderTexture currentRT = RenderTexture.active;

        // Ÿ�� ����
        cam.targetTexture = targetTexture;
        RenderTexture.active = targetTexture;

        // ���� ����
        cam.Render();

        // ����� �ؽ�ó2D�� ������ ���� ����
        Texture2D image = new Texture2D(targetTexture.width, targetTexture.height, TextureFormat.RGB24, false);
        image.ReadPixels(new Rect(0, 0, targetTexture.width, targetTexture.height), 0, 0);
        image.Apply();

        // ����
        cam.targetTexture = null;
        RenderTexture.active = currentRT;

        return image;
    }
}
