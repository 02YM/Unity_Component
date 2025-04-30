using UnityEngine;

public class AudioSourceEx : MonoBehaviour
{
    AudioSource m_AudioSource;
    [SerializeField] float AudioVolume = 0.5f;
    [SerializeField] float AudioBlend = 1;
    [SerializeField] float AudioDistnace = 1;

    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_AudioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            m_AudioSource.volume += AudioVolume;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            m_AudioSource.volume -= AudioVolume;
        }

        m_AudioSource.spatialBlend = AudioBlend;

        if (m_AudioSource.isPlaying) Debug.Log("오디오가 재생중입니다.");

        m_AudioSource.maxDistance = AudioDistnace;
    }
}
