using System.Collections;
using UnityEngine;

public class Moveoff : MonoBehaviour {

    private Material currentMaterial;
    public float speed;
    private float offset;


    void Start () {
        currentMaterial = GetComponent<Renderer>().material;
        
	}
	
	
	void Update () {        
        offset += 0.001f;

        currentMaterial.SetTextureOffset("_MainTex", new Vector2 (offset * speed,0 ));
	}
}
