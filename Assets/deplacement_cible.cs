using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class deplacement_cible : MonoBehaviour

{
  public int vitesse_ennemie=5;
private RaycastHit Hit;
void Update(){
  transform.Translate(Vector3.forward*vitesse_ennemie*Time.deltaTime);
  if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out Hit,2))
  {
    transform.Rotate(Vector3.up*Random.Range(50,200));
    
    
  }
}
}