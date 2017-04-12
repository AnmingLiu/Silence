using UnityEngine;
using System.Collections;

public class TorchTrigger : MonoBehaviour {
   public GameObject torch;

   void OnTriggerEnter2D(Collider2D other)
   {
      if (other.CompareTag("Player"))
      {
         GetComponent<BoxCollider2D>().enabled = false;
         other.transform.FindChild("base").gameObject.SetActive(true);
         other.transform.FindChild("fire").gameObject.SetActive(true);
         torch.SetActive(true);
         transform.localScale = Vector3.zero;
         Destroy(gameObject, 2f);
      }
   }
}
