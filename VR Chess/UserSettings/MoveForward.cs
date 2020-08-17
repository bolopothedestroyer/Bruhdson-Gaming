using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 10f;
    public bool canMove = false;
    public Transform forwardMarch;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {//control pressed = movement
        if (Input.GetButtonDown("Fire1"))
        {
            canMove = !canMove;
        }
        if (canMove) // if can move is true, then it will do this!!
        {
            //movement is based on CAMERA DIRECTION for this line
            //Vector3 cameraForward = Camera.main.transform.forward;

            //movement is guided by the object you place into forward march (this case, the cube in Player)
            this.gameObject.transform.Translate(forwardMarch.forward * Time.deltaTime);
            //just by itself this line allwos you to move forward, but that's all. almost like a roller coaster
            //this.gameObject.transform.Translate(Vector3.forward * Time.deltaTime);
        }

    }
    private void OnCollisionEnter(Collision otherObject)
    //this sets up a private function that belongs to the script saying that if it hits any object that has been given the tag "stopper",
    // then canMove will be registered as false, and the ^^above if statement will be rednered false
    { 
        if (otherObject.transform.tag == "stopper")
        //{
            canMove = false;
            //Debug.Log("Collision Detected. " + otherObject.gameObject.name);
        
        //}
        //will list the name of the objet that its detecting the collision of...
       }
        
}
