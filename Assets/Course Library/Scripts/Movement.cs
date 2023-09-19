using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed;
    public int turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var hSpeed = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed*hSpeed);
        var vSpeed = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed*vSpeed);
    }
}
