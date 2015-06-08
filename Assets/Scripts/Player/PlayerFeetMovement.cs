using UnityEngine;
using System.Collections;

public class PlayerFeetMovement : MonoBehaviour {

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float inputV = Input.GetAxis("Vertical");
        if ((inputV > 0) || (inputV < 0))
        {
            anim.SetBool("Forward", true);
        }
        else
        {
            anim.SetBool("Forward", false);
        }

        float inputH = Input.GetAxis("Horizontal");
        if(inputH > 0)
        {
            anim.SetBool("Right", true);
        }
        else if (inputH < 0)
        {
            anim.SetBool("Left", true);
        }
        else
        {
            anim.SetBool("Right", false);
            anim.SetBool("Left", false);
        }

    }
}
