using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float maxTime = 60.0f;
    private float countdown = 0.0f;

    void Start()
    {
        countdown = maxTime;
    }

    void Update()
     {
        countdown -= Time.deltaTime;
        if (countdown <= 0){
               Coin.coins_count = 0;
               Application.LoadLevel (Application.loadedLevel);
        }
    }
}
