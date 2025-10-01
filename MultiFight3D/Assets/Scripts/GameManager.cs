using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class GameManager : MonoBehaviourPunCallbacks
{
   
   private void Awake()
   {
      Screen.SetResolution(1920, 1080, true);
      PhotonNetwork.ConnectUsingSettings();
   }

   public override void OnConnectedToMaster() => 
   PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions{MaxPlayers = 8}, null);

   public override void OnJoinedRoom()
   {
      PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);
   }   
}
