using UnityEngine;

public class AudioSourceMethod : MonoBehaviour
{

    AudioSource m_AudioSource;
    [SerializeField] AudioClip m_Resource;
    [SerializeField] AudioClip m_Clip;

    [SerializeField] bool isPlay = false;
    [SerializeField] bool isPlayOnShot = false;
    [SerializeField] bool isPlayDelayed = false;
    [SerializeField] float isPlayDelayedDuration = 2.0f;
    [SerializeField] bool isStop = false;
    
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_AudioSource.clip = m_Resource;
    }

    // Update is called once per frame
    void Update()
    {        
        if(isPlay && !m_AudioSource.isPlaying)
        {
            m_AudioSource.Play();
        }
        else if(!isPlay && m_AudioSource.isPlaying)
        {
            m_AudioSource.Pause();
        }

        if(isPlayOnShot && !m_AudioSource.isPlaying)
        {
            m_AudioSource.PlayOneShot(m_Clip);
            Invoke("OnSouce", 1f);
        }
        if(isPlayDelayed && !m_AudioSource.isPlaying)
        {
            m_AudioSource.PlayDelayed(isPlayDelayedDuration);
        }

        if(isStop && m_AudioSource.isPlaying)
        {
            m_AudioSource.Stop();
        }        
        
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AudioSource.PlayClipAtPoint(m_Clip, transform.position, 0.5f);
        }
    }

    void OnSouce()
    {
        isPlayOnShot = false;
    }
}
