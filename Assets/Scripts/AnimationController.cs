using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRend;

    private float horiAxis;
    private float vertAxis;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            animator.SetBool("Walking", true);
        } else if (Input.GetAxis("Vertical") == 0)
        {
            animator.SetBool("Walking", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            spriteRend.flipX = false;

            animator.SetBool("Walking", true);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            spriteRend.flipX = true;
            animator.SetBool("Walking", true);
        }
    }
}
