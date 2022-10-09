using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changement_cible : MonoBehaviour
{
     
     private void OnCollisionEnter(Collision collision){
      
            if(collision.gameObject.layer==LayerMask.NameToLayer("balle"))
                
                 Destroy(collision.gameObject);
                 
        
    
}

    }

