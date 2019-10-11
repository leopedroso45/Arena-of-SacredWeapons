using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
    public GameObject objtofollow;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(objtofollow.transform.position.x, objtofollow.transform.position.y + 0.2f, objtofollow.transform.position.z + 0.5f);

    }
}
