using UnityEngine;
using System.Collections;

public class NetworkPlayer : Photon.MonoBehaviour {

    Animator bodyAnim;

    Vector3 realPosition = Vector3.zero;
    Quaternion realRotation = Quaternion.identity;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if(photonView.isMine)
        {
            bodyAnim = GetComponent<Animator>();
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
        }
        else
        {
            realPosition = (Vector3) stream.ReceiveNext();
            realRotation = (Quaternion) stream.ReceiveNext();
            bodyAnim.SetBool("ForwardMovement", ((bool)stream.ReceiveNext()));
        }
    }
}
