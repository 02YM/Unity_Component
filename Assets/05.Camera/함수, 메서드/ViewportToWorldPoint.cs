using UnityEngine;

public class ViewportToWorldPoint : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        Vector3 viewportPos = new Vector3(0.1f, 0.9f, 10f);

        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewportPos);

        Instantiate(player, worldPos, Quaternion.identity);
    }
}
