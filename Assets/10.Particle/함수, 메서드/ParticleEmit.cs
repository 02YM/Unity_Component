using UnityEngine;

public class ParticleEmit : MonoBehaviour
{
    ParticleSystem m_Particle;

    [SerializeField] int particleCount = 0;
    void Start()
    {
        m_Particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_Particle.Emit(particleCount);
        }
    }
}
