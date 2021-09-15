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

        /*
        horiAxis = Input.GetAxis("Horizontal");

        if(horiAxis < 0)
        {
            animator.SetBool("Flip", true);
            animator.SetBool("Walking", true);
        } 
        
        else if (horiAxis > 0)
        {
            animator.SetBool("Flip", false);
            animator.SetBool("Walking", true);
        }
        */

        

        if (Input.GetKey(KeyCode.A))
        {
            spriteRend.flipX = true;

            animator.SetBool("Walking", true);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            spriteRend.flipX = false;
            animator.SetBool("Walking", true);
        }
        

        else
        {
            animator.SetBool("Walking", false);
        }
    }
}
