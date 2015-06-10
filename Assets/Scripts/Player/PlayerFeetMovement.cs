using UnityEngine;
using System.Collections;

public class PlayerFeetMovement : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
//      Physical Movement
        float inputV = Input.GetAxis("Vertical");
        float inputH = Input.GetAxis("Horizontal");

//      Animation Movement
        Vector3 CurrentRotation = transform.parent.rotation.eulerAngles;
/*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Movement Verticaly
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        if ((inputV > 0) && (inputH == 0))
        {
            if ((CurrentRotation.z >= 330) || (CurrentRotation.z <= 30))
            {
                anim.SetBool("Right", false);
                anim.SetBool("Left", false);
                anim.SetBool("Forward", true);
            }
            else if ((CurrentRotation.z >= 150) && (CurrentRotation.z <= 210))
            {
                anim.SetBool("Right", false);
                anim.SetBool("Left", false);
                anim.SetBool("Forward", true);
            }
            else if ((CurrentRotation.z > 30) && (CurrentRotation.z < 150))
            {
                anim.SetBool("Forward", false);
                anim.SetBool("Left", false);
                anim.SetBool("Right", true);
            }
            else if ((CurrentRotation.z > 210) && (CurrentRotation.z < 330))
            {
                anim.SetBool("Forward", false);
                anim.SetBool("Right", false);
                anim.SetBool("Left", true);
            }
        }
        else if ((inputV < 0) && (inputH == 0))
        {
            if ((CurrentRotation.z >= 330) || (CurrentRotation.z <= 30))
            {
                anim.SetBool("Right", false);
                anim.SetBool("Left", false);
                anim.SetBool("Forward", true);
            }
            else if ((CurrentRotation.z >= 150) && (CurrentRotation.z <= 210))
            {
                anim.SetBool("Right", false);
                anim.SetBool("Left", false);
                anim.SetBool("Forward", true);
            }
            else if ((CurrentRotation.z > 30) && (CurrentRotation.z < 150))
            {
                anim.SetBool("Forward", false);
                anim.SetBool("Right", false);
                anim.SetBool("Left", true);
            }
            else if ((CurrentRotation.z > 210) && (CurrentRotation.z < 330))
            {
                anim.SetBool("Forward", false);
                anim.SetBool("Left", false);
                anim.SetBool("Right", true);
            }
        }
/*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Movement Horizontaly
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        if ((inputH > 0) && (inputV == 0))
        {
            if ((CurrentRotation.z >= 330) || (CurrentRotation.z <= 30))
            {
                anim.SetBool("Right", true);
                anim.SetBool("Left", false);
                anim.SetBool("Forward", false);
            }
            else if ((CurrentRotation.z >= 150) && (CurrentRotation.z <= 210))
            {
                anim.SetBool("Right", false);
                anim.SetBool("Left", true);
                anim.SetBool("Forward", false);
            }
            else if ((CurrentRotation.z > 30) && (CurrentRotation.z < 150))
            {
                anim.SetBool("Forward", true);
                anim.SetBool("Left", false);
                anim.SetBool("Right", false);
            }
            else if ((CurrentRotation.z > 210) && (CurrentRotation.z < 330))
            {
                anim.SetBool("Forward", true);
                anim.SetBool("Right", false);
                anim.SetBool("Left", false);
            }
        }
        else if ((inputH < 0) && (inputV == 0))
        {
            if ((CurrentRotation.z >= 330) || (CurrentRotation.z <= 30))
            {
                anim.SetBool("Right", false);
                anim.SetBool("Left", true);
                anim.SetBool("Forward", false);
            }
            else if ((CurrentRotation.z >= 150) && (CurrentRotation.z <= 210))
            {
                anim.SetBool("Right", true);
                anim.SetBool("Left", false);
                anim.SetBool("Forward", false);
            }
            else if ((CurrentRotation.z > 30) && (CurrentRotation.z < 150))
            {
                anim.SetBool("Forward", true);
                anim.SetBool("Right", false);
                anim.SetBool("Left", false);
            }
            else if ((CurrentRotation.z > 210) && (CurrentRotation.z < 330))
            {
                anim.SetBool("Forward", true);
                anim.SetBool("Left", false);
                anim.SetBool("Right", false);
            }
        }
/*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Movement Diagonaly Left
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        else if((inputV > 0) && (inputH < 0))
        {
            if (((CurrentRotation.z >= 0) && (CurrentRotation.z <= 90)) || ((CurrentRotation.z >= 180) && (CurrentRotation.z <= 270)))
            {
                anim.SetBool("Left", false);
                anim.SetBool("Right", false);
                anim.SetBool("Forward", true);
            }
            else if ((CurrentRotation.z > 90) && (CurrentRotation.z < 180))
            {
                anim.SetBool("Forward", false);
                anim.SetBool("Left", false);
                anim.SetBool("Right", true);
            }
            else if ((CurrentRotation.z > 270) && (CurrentRotation.z < 360))
            {
                anim.SetBool("Forward", false);
                anim.SetBool("Right", false);
                anim.SetBool("Left", true);
            }
        }
        else if ((inputV < 0) && (inputH < 0))
        {
            if(((CurrentRotation.z >= 90) && (CurrentRotation.z <= 180)) || ((CurrentRotation.z >= 270) && (CurrentRotation.z < 360)))
            {
                anim.SetBool("Left", false);
                anim.SetBool("Right", false);
                anim.SetBool("Forward", true);
            }
            else if ((CurrentRotation.z >= 0) && (CurrentRotation.z < 90))
            {
                anim.SetBool("Forward", false);
                anim.SetBool("Right", false);
                anim.SetBool("Left", true);
            }
            else if ((CurrentRotation.z > 180) && (CurrentRotation.z < 270))
            {
                anim.SetBool("Forward", false);
                anim.SetBool("Left", false);
                anim.SetBool("Right", true);
            }
        }
/*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Movement Diagonaly Right
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        else if ((inputV < 0) && (inputH > 0))
        {
            if (((CurrentRotation.z >= 180) && (CurrentRotation.z <= 270)) || ((CurrentRotation.z >= 0) && (CurrentRotation.z <= 90)))
            {
                anim.SetBool("Left", false);
                anim.SetBool("Right", false);
                anim.SetBool("Forward", true);
            }
            else if ((CurrentRotation.z > 90) && (CurrentRotation.z < 180))
            {
                anim.SetBool("Forward", false);
                anim.SetBool("Right", false);
                anim.SetBool("Left", true);
            }
            else if ((CurrentRotation.z > 270) && (CurrentRotation.z < 360))
            {
                anim.SetBool("Forward", false);
                anim.SetBool("Left", false);
                anim.SetBool("Right", true);
            }
        }
        else if ((inputV > 0) && (inputH > 0))
        {
            if (((CurrentRotation.z >= 270) && (CurrentRotation.z < 360)) || ((CurrentRotation.z >= 90) && (CurrentRotation.z <= 180)))
            {
                anim.SetBool("Left", false);
                anim.SetBool("Right", false);
                anim.SetBool("Forward", true);
            }
            else if ((CurrentRotation.z > 180) && (CurrentRotation.z < 270))
            {
                anim.SetBool("Forward", false);
                anim.SetBool("Right", false);
                anim.SetBool("Left", true);
            }
            else if ((CurrentRotation.z >= 0) && (CurrentRotation.z < 90))
            {
                anim.SetBool("Forward", false);
                anim.SetBool("Left", false);
                anim.SetBool("Right", true);
            }
        }
/*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Movement None
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        else if ((inputV == 0) && (inputH == 0))
        {
            anim.SetBool("Forward", false);
            anim.SetBool("Right", false);
            anim.SetBool("Left", false);
        }
    }
}
