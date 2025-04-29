using UnityEngine;

public class BlendEx : MonoBehaviour
{

    Animation anime;
    [SerializeField] float Duration1 = 0.5f, Duration2 = 0.5f;

    void Start()
    {
        anime = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        anime.Blend("Run", Duration1);
        anime.Blend("Attack", Duration2);
    }
}
