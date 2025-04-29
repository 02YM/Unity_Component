using UnityEngine;

public class CrossFadeEx : MonoBehaviour
{

    Animation anime;
    [SerializeField] float duration = 3f;

    void Start()
    {
        anime = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            anime.Play("Attack");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            anime.CrossFade("Run", duration);
        }
    }
}
