using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 dir;

    //Animator anim;
    CharacterController cc;

    private AudioClip footstep;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
      //  anim = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // ĳ���Ͱ� ���鿡 �ִ� ���
        if (cc.isGrounded)
        {
            var h = Input.GetAxis("Horizontal");
            var v = Input.GetAxis("Vertical");

            dir = new Vector3(h, 0, v) * speed;

            if (dir != Vector3.zero)
            {
                // ���� �������� ĳ���� ȸ��
                transform.rotation = Quaternion.Euler(0, Mathf.Atan2(h, v) * Mathf.Rad2Deg, 0);
            }

            // Space �� ������ ����
            if (Input.GetKeyDown(KeyCode.Space))
                dir.y = 7.5f;
        }

        dir.y += Physics.gravity.y * Time.deltaTime;
        cc.Move(dir * Time.deltaTime);
    }

    void FootStep()
    {
        AudioSource.PlayClipAtPoint(footstep, Camera.main.transform.position);
    }
}
