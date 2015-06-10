using UnityEngine;
using System.Collections;

public class NetworkPlayer : Photon.MonoBehaviour {

    Animator bodyAnim;
    Animator feetAnim;

    GameObject feetObject;

    Vector3 realPosition = Vector3.zero;
    Quaternion realRotation = Quaternion.identity;

	// Use this for initialization
	void Start () 
    {
        bodyAnim = GetComponent<Animator>();
        feetObject = gameObject.transform.Find("Feet").gameObject;
        feetAnim = feetObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if(photonView.isMine)
        {
            if(bodyAnim == null)
            {
                Debug.Log("bodyAnim = NULL!");
            }
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, realPosition, 0.1f);
            transform.rotation = Quaternion.Lerp(transform.rotation, realRotation, 0.1f);
        }
	}

    void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if(stream.isWriting)
        {
            stream.SendNext(transform.position);
            stream.SendNext(transform.rotation);
            stream.SendNext(bodyAnim.GetBool("ForwardMovement"));
            stream.SendNext(feetAnim.GetBool("Forward"));
            stream.SendNext(feetAnim.GetBool("Left"));
            stream.SendNext(feetAnim.GetBool("Right"));
        }
        else
        {
            realPosition = (Vector3) stream.ReceiveNext();
            realRotation = (Quaternion) stream.ReceiveNext();
            bodyAnim.SetBool("ForwardMovement", ((bool)stream.ReceiveNext()));
            feetAnim.SetBool("Forward", ((bool)stream.ReceiveNext()));
            feetAnim.SetBool("Left", ((bool)stream.ReceiveNext()));
            feetAnim.SetBool("Right", ((bool)stream.ReceiveNext()));
        }
    }
}
