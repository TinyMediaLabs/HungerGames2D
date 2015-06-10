using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Connect();
	}

    void Connect()
    {
        PhotonNetwork.ConnectUsingSettings("V.Alpha.0.0.1");
    }

    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }
    
    void OnJoinedLobby()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    void OnPhotonRandomJoinFailed()
    {
        PhotonNetwork.CreateRoom(null);
    }

    void OnJoinedRoom()
    {
        SpawnMyPlayer();
    }

    void SpawnMyPlayer()
    {
        GameObject myPlayerObject = (GameObject) PhotonNetwork.Instantiate("TopDownPlayerController", Vector3.zero, Quaternion.identity, 0);

        myPlayerObject.transform.FindChild("PlayerCamera").gameObject.SetActive(true);

        GameObject myPlayerBody = myPlayerObject.transform.Find("PlayerObject").gameObject;
        GameObject myPlayerFeet = myPlayerBody.transform.Find("Feet").gameObject;

        ((MonoBehaviour)myPlayerBody.GetComponent("PlayerMovement")).enabled = true;
        ((MonoBehaviour)myPlayerFeet.GetComponent("PlayerFeetMovement")).enabled = true;
    }
}
