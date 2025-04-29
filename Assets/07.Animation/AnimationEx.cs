using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class AnimationEx : MonoBehaviour
{
    Animation anime;
    List<string> animArray;
    [SerializeField] int randomNum = 0;
    int index = 0;
    [SerializeField] AnimationClip myClip;

    void Start()
    {
        anime = GetComponent<Animation>();
        animArray = new List<string>();                
    }

    // Update is called once per frame
    void Update()
    {        
        anime.playAutomatically = true;
        anime.animatePhysics = true;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AnimationArray();
            if (anime.isPlaying)
            {
                Debug.Log("애니메이션이 실행 중입니다.!");
            }
        }                                
    }

    private void AnimationArray()
    {
        foreach(AnimationState state in anime)
        {
            animArray.Add(state.name);
            index++;
            Debug.Log($"{animArray.ToString()}");
        }
        randomNum = Random.Range(0, index);
    }
}
