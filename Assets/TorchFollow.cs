using UnityEngine;
using System.Collections;

public class TorchFollow : MonoBehaviour {

   public Vector3 offset;

   GameObject player;
   
   void Awake()
   {
      player = GameObject.FindGameObjectWithTag("Player");
   }
	
	void Update () {
      this.transform.position = player.transform.position + offset;
	}
}
