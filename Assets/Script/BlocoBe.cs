﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlocoBe : MonoBehaviour {
    public float speed;
    public GameObject bloco;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        if (transform.position.x < -9.2f)
        {
            bloco.SetActive(false);
        }

    }
   
}
