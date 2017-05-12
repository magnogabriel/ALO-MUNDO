using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class Spwam : MonoBehaviour {
    public float maxHeight;
    public int maxBloco;
    public float minHeight;
    public float ratespwn;
    private float currentRateSapwm;
    public GameObject prefab;
    public List<GameObject> bloco;
    private float randonPosition;
   

	void Start () {
	  for(int i=0;i < maxBloco; i++)
        {
            GameObject tempBloco = Instantiate(prefab) as GameObject;
            bloco.Add(tempBloco);
            tempBloco.SetActive(false);


             
        }


    }


    void Update() {
        currentRateSapwm += Time.deltaTime;

        if(currentRateSapwm > ratespwn)
        {
            currentRateSapwm = 0;
            spwan();
        }
    }
		private void spwan() {



        float rand = Random.Range(0, 9);
        if (   rand < 5)
        {

            randonPosition = minHeight;
        }
        else
        {
            randonPosition = maxHeight;
        }
        float randPosition = minHeight;
            GameObject tempBloco = null;
            for (int i = 0; i < maxBloco; i++) {
                if (bloco[i].activeSelf == false) {
                tempBloco = bloco[i];
                break;
                        
                  }

                }
            if (tempBloco != null)
        {
            tempBloco.transform.position = new Vector3(transform.position.x, randPosition, transform.position.z);
            tempBloco.SetActive(true);
             
        }
             

            }
        }


