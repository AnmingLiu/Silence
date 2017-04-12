using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

   public float moveSpeed;

   Rigidbody2D body2d;
   Vector3 move = Vector3.zero;
   BoxCollider2D box2d;

   void Start () {
      body2d = GetComponent<Rigidbody2D>();
      box2d = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
      Movement();
	}

   void Movement()
   {
      move.x = Input.GetAxisRaw("Horizontal");
      move.y = Input.GetAxisRaw("Vertical");
      var movement = new Vector3(move.x,move.y, 0);
      body2d.velocity = movement * moveSpeed * Time.deltaTime;
      if (move.x != 0)
      {
         transform.localScale = new Vector3(move.x, 1, 1);
      }
   }
}
