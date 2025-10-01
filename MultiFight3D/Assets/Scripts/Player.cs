using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Player : MonoBehaviourPunCallbacks
{

   public PhotonView pv;

   private void Update()
   {

     if(pv.IsMine)
        {
            this.transform.Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * 7, 0, 0));
        }
    }
      
}
