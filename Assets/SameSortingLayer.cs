using UnityEngine;
using System.Collections;

public class SameSortingLayer : MonoBehaviour {

   public int offset;

   GameObject player;
   SpriteRenderer playerRender2d, render2d;

   void Awake()
   {
      player = GameObject.FindGameObjectWithTag("Player");
      render2d = GetComponent<SpriteRenderer>();
      playerRender2d = player.GetComponent<SpriteRenderer>();
   }

   void Update()
   {
      render2d.sortingOrder = playerRender2d.sortingOrder + offset;
   }
}
