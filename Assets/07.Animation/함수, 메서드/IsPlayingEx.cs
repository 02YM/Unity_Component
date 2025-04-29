using UnityEngine;

public class IsPlayingEx : MonoBehaviour
{
    Animation anime;
    [SerializeField] bool active = false;

    void Start()
    {
        anime = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        anime.Play("Attack");
        if(anime.IsPlaying("Attack"))
        {
            active = true;
            Debug.Log("Attack �ִϸ��̼� ������");
        }        

        if (Input.GetKeyDown(KeyCode.S))
        {
            active = false;
            anime.Stop();
            Debug.Log("Attack �ִϸ��̼� ����");
        }
    }
}
