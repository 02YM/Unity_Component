using UnityEngine;
using UnityEngine.Rendering;

public class StopEx : MonoBehaviour
{

    Animation anime;

    void Start()
    {
        anime = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        anime.Play("Attack");

        if(Input.GetKeyDown(KeyCode.S))
        {
            anime.Stop("Attack");
            anime.wrapMode = WrapMode.ClampForever;
        }
    }
}
