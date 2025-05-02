using UnityEngine;

public class ParticleSimulate : MonoBehaviour
{
    ParticleSystem m_Particle;
    [SerializeField] int time;
    [SerializeField] bool withChildren;
    [SerializeField] bool restart;
    [SerializeField] bool fixedTimeStep;

    void Start()
    {
        m_Particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_Particle.Simulate(time, withChildren, restart, fixedTimeStep);            
            m_Particle.Play();
        }
    }
}
