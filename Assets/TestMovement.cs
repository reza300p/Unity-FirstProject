using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    
    public GameObject gObject;
    [Range (0,50.0F)]
    public float speed = 0.5F;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1F || Mathf.Abs(Input.GetAxis("Vertical")) > 0.1F ) {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical")) * speed * Time.deltaTime;
            gObject.transform.Translate(movement);
        }
    }
    
    
}
