using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    private Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("jump");
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", false);
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", true);
        }
        else if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isAttacking", false);
        }
        else
        {
            anim.ResetTrigger("jump");
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", false);
        }
    }
}