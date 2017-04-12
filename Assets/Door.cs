using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

   public Vector3 offset;
   public float speed;

   public bool Open {
      get { return activated; }
      set { activated = value; }}

   Vector3 origin;
   Vector3 endPos;
   Vector3 pos;
   bool activated;
	// Use this for initialization
	void Start () {
      origin = transform.position;
      endPos = origin - offset;
      activated = false;

    }

   void Update()
   {
      float step = speed * Time.deltaTime;

      if (activated)
         pos = endPos;
      else
         pos = origin;

         Debug.Log("moving");
         transform.position = Vector3.MoveTowards(transform.position, pos, step);
   }
}
