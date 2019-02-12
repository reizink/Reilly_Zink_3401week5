using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour {

    public GameObject BombPrefab;
    public Transform SpawnPos;
	
	// Update is called once per frame
	void Update ()
    {

		if(Input.GetKeyDown (KeyCode.Space)) 
        {
            Instantiate(BombPrefab, SpawnPos.position, Quaternion.identity);
        }
	}
}
