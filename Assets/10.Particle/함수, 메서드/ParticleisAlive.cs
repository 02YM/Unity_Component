using UnityEngine;

public class ParticleisAlive : MonoBehaviour
{
    ParticleSystem m_Particle;
    void Start()
    {
        m_Particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_Particle.Play();
        }

        if(m_Particle.IsAlive())
        {
            Debug.Log("파티클이 실행중입니다.");
        }
    }
}
