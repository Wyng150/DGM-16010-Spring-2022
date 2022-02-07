using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour

{
    public float speed = 40f;
    public float turnSpeed = 60f;
    public float hInput;
    public float fInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput );
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * hInput );

    }
}
