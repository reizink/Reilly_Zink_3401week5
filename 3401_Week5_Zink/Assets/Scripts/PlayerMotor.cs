using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

    // move forward each frame
    void Update()
    {
        transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + .01f);
        transform.rotation = Quaternion.identity;

        if (Input.GetMouseButton(0))
        {
            transform.position = new Vector3(transform.position.x - .01f, transform.position.y, transform.position.z);        
        }
        else if (Input.GetMouseButton(1))
        {
            transform.position = new Vector3(transform.position.x + .01f, transform.position.y, transform.position.z);
        }
    }


}
