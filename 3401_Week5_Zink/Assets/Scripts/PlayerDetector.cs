using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour {

    public GameObject raycastObject;

    void Start()
    {
        //targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = raycastObject.transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(raycastObject.transform.position, fwd * 5, Color.green);

        if (Physics.Raycast(raycastObject.transform.position, fwd, out hit, 5))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
        else{
            Debug.Log("NOTHING AHEAD");
        }
    }

}
