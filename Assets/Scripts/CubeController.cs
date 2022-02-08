using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speed;
    //public GameObject target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float vInput = Input.GetAxis("Vertical");
        float hInput = Input.GetAxis("Horizontal");


        Debug.Log("position: " + transform.position);
        //Debug.Log("target: " + target.transform.position);
        Debug.Log("deltaTime: " + Time.deltaTime);


        transform.Translate(Vector3.forward * vInput * speed * Time.deltaTime, Space.World);
        //transform.Translate(Vector3.right * hInput * speed * Time.deltaTime);
        transform.Rotate(Vector3.up, hInput * speed * Time.deltaTime);
    }
}
