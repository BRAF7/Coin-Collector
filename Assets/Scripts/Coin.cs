using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public static int coins_count = 0;

    // Start is called before the first frame update
    void Start()
    {   
        Coin.coins_count++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag ("Player"));
            Destroy (gameObject);
            
    }

    void OnDestroy()
    {
        Coin.coins_count--;
        if(Coin.coins_count <= 0)
        {
            GameObject timer  = GameObject.Find ("GameTimer");  
            Destroy (timer);
            GameObject[] fire_works = GameObject.FindGameObjectsWithTag ("FireWork");
            foreach (GameObject firework in fire_works){
                firework.GetComponent<ParticleSystem>().Play();
            }
        }
    }
}
