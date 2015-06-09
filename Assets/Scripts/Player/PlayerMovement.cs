using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        GetComponent<Rigidbody2D>().angularVelocity = 0;

        float inputV = Input.GetAxis("Vertical");
        if(inputV > 0)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed * inputV);

            anim.SetBool("ForwardMovement", true);
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed * inputV);
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
