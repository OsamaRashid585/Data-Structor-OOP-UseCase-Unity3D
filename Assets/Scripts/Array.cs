using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
   public Transform[] waypoints;
   public float Time;
   int i = 0;
   void Start() {
   }
   private void Update() {
    
    transform.position = Vector3.MoveTowards(transform.position,waypoints[i].position,Time);

    if(i < waypoints.Length && transform.position == waypoints[i].position){
        i++;
    }
   }

}
