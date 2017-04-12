using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

   public Door[] doors;
   public Sprite normalSprite;
   public Sprite triggeredSprite;

   SpriteRenderer render;

   void Awake()
   {
      render = GetComponent<SpriteRenderer>();
   }
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
   {
      if (other.CompareTag("trigger") || other.CompareTag("Player")){
         Debug.Log("triggered");
         render.sprite = triggeredSprite;
         foreach(var door in doors)
               door.Open = true;
      }
   }

   void OnTriggerExit2D(Collider2D other)
   {
      if (other.CompareTag("trigger") || other.CompareTag("Player")){
         render.sprite = normalSprite;
         foreach (var door in doors)
            door.Open = false;
      }
   }
}
