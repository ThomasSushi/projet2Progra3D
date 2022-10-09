using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creation_cible : MonoBehaviour

{
    // Start is called before the first frame update
   
[SerializeField] private GameObject cible;
[SerializeField] private Transform cibletransform;
    // Update is called once per frame
[SerializeField] public int nbrcible; 
private int iter =0;
  void Update()
    {
      if(Input.GetButtonDown("Jump")&& iter==0){
        creation();
        iter-=1;
        }
      }
    

private void creation(){
  for(int i=0;i<nbrcible;i++){
          Instantiate(cible,position:new Vector3(Random.Range(-15,15),Random.Range(2,25),Random.Range(-15,15)),Quaternion.identity);
        }
}
}
