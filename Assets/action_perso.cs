using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action_perso : MonoBehaviour


{
    // Start is called before the first frame update
    
    
   private Rigidbody rb;
   public Camera playerCamera;
   public float sensitivity=3f;
   private float yrot=0.0f;
   private float xrot=0.0f;
   public float moveSpeed=5f;
   private float IncliMax=90f;
     
     [SerializeField] private GameObject balle;
    [SerializeField] private Transform cameratransform;
    
void Start(){
    Cursor.lockState=CursorLockMode.Locked;
    rb=GetComponent<Rigidbody>();
    
}
        // Update is called once per frame
    void Update()
    {
       
    if(Input.GetButtonDown("Fire1"))
            SpawnBalle();    
    
    
    yrot=transform.localEulerAngles.y +Input.GetAxis("Mouse X")*sensitivity;
    xrot=xrot-Input.GetAxis("Mouse Y")*sensitivity;
    transform.localEulerAngles=new Vector3(0,yrot,0);
    xrot=Mathf.Clamp(xrot,-IncliMax,IncliMax);
    playerCamera.transform.localEulerAngles=new Vector3(xrot,0,0);

    }
    private void FixedUpdate(){
        Vector3 DirectionPerso=new Vector3(
        Input.GetAxis("Horizontal")*Time.deltaTime*30f,
        0f,
        Input.GetAxis("Vertical")*Time.deltaTime*30f
        );
        //permet de coordonner la rotation et la direction voulu
        DirectionPerso=transform.TransformDirection(DirectionPerso)*moveSpeed;

        Vector3 DeltaVitesse=DirectionPerso -rb.velocity;
        rb.AddForce(DeltaVitesse,ForceMode.VelocityChange);
    }
    private void SpawnBalle ()
    {
         
        GameObject shoot=Instantiate(balle,cameratransform.position,Quaternion.identity);
        Rigidbody balleRigidbody=shoot.GetComponent<Rigidbody>();
        balleRigidbody.AddForce(cameratransform.TransformDirection(Vector3.forward* 3000f));
    }
}
   

