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
        Vector3 CurrentRotation = transform.parent.rotation.eulerAngles;

        float inputV = Input.GetAxis("Vertical");
        float inputH = Input.GetAxis("Horizontal");

        if (inputV > 0)
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
                 else if((CurrentRotation.z > 30) && (CurrentRotation.z < 150))
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
        else if(inputV < 0)
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
        if (inputH > 0)
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
        else if (inputH < 0)
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
        else if ((inputV == 0) && (inputH == 0))
        {
            anim.SetBool("Forward", false);
            anim.SetBool("Right", false);
            anim.SetBool("Left", false);
        }
    }
}
