using UnityEngine;

public class AddExplosionForce : MonoBehaviour
{

    private Rigidbody rigid;

    public Transform target;

    public float explosionRadius = 20;
    public float upwardsModifier = 5;
    public float explosionFoce = 2000;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            //���߷�, ���� ��ġ, ���� �ݰ�, ������,
            rigid.AddExplosionForce(explosionFoce,
                                    target.position,
                                    explosionRadius,
                                    upwardsModifier,
                                    ForceMode.Impulse);
        }
    }

}
