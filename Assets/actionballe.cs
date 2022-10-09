using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionballe : MonoBehaviour{
    private void OnCollisionEnter(Collision collision){
       if(collision.gameObject.layer==LayerMask.NameToLayer("cible"))
            Destroy(collision.gameObject);
    }
}
            // GetComponent<Renderer>().material.color = Color.red;
            
