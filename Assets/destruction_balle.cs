using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruction_balle : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnCollisionEnter(Collision collision){
      
            if(collision.gameObject.layer==LayerMask.NameToLayer("balle"))
                
                 Destroy(collision.gameObject);
             if(collision.gameObject.layer==LayerMask.NameToLayer("balle"))
                gameObject.GetComponent<Renderer>().material.color= Color.red;
                 
          }

}
