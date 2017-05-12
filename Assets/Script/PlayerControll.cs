using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour {
    public GameObject player;
    public float maxHeight;
    public float minHeight;
    public float speed;
    void Start () {
		
	}
	
	// Update is  called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") *speed;
        player.transform.Translate(0, translation, 0);
        if (player.transform.position.y > maxHeight)
        {
            player.transform.position = new Vector2(0 , maxHeight);
             
        }
        if (player.transform.position.y < minHeight)
        { 
            player.transform.position = new Vector2(0, minHeight);

        }
    }
}
