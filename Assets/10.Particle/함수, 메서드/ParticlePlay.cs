using UnityEngine;

public class ParticlePlay : MonoBehaviour
{
    [SerializeField] ParticleSystem m_Particle;
    

    void Start()
    {
        m_Particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!m_Particle.isPlaying)
            {
                m_Particle.Play();
            }
            else
            {
                m_Particle.Pause();
            }
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            if(m_Particle.isPlaying)
            {
                m_Particle.Clear();
            }
        }
            
    }
}
