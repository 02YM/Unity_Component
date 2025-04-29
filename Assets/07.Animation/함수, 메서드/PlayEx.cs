using UnityEngine;

public class PlayEx : MonoBehaviour
{
    Animation anime;

    void Start()
    {
        anime = GetComponent<Animation>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anime.Play("Attack");
        }
    }
}
