using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float speed;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
/*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Rotation By Mouse Position
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);

        Vector3 CurrentRotation = transform.rotation.eulerAngles;

        GetComponent<Rigidbody2D>().angularVelocity = 0;
/*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Body Movement
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        float inputV = Input.GetAxis("Vertical");
        if ((inputV > 0) || (inputV < 0))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed * inputV);

            if ((CurrentRotation.z >= 330) || (CurrentRotation.z <= 30))
            {
                anim.SetBool("ForwardMovement", true);
            }
            else if ((CurrentRotation.z >= 150) && (CurrentRotation.z <= 210))
            {
                anim.SetBool("ForwardMovement", true);
            }
            else if ((CurrentRotation.z > 30) && (CurrentRotation.z < 150))
            {
                anim.SetBool("ForwardMovement", true);

            }
            else if ((CurrentRotation.z > 210) && (CurrentRotation.z < 330))
            {
                anim.SetBool("ForwardMovement", true);
            }
        }
        else
        {
            anim.SetBool("ForwardMovement", false);
        }

        float inputH = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed * inputH);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("MeleeAttackTrigger");
        }
    }
}
