using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
   void OnTriggerEnter2D(Collider2D other)
   {
      if (other.CompareTag("Collectable"))
      {
         other.gameObject.GetComponent<BoxCollider2D>().enabled = false;
         other.gameObject.SetActive(false);
         Destroy(other.gameObject, 2f);
      }
   }

}
