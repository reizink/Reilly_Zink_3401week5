using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOMotor : MonoBehaviour {

    Vector3 targetPosition;

    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update ()
    {
        if(Input.GetMouseButtonDown (0)) //GetMouseButton vs. GetMouseButtonDown
        {
            Ray cameraRay = Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast (cameraRay, out hit))
            {
                //Debug.Log(hit.point);
                targetPosition = new Vector3(hit.point.x, hit.point.y + 5, hit.point.z);
                //transform.position = targetPosition; // warps
            }
        }

        transform.position = Vector3.Lerp(transform.position, targetPosition, 0.1f);
	}


}
