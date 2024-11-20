using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PickUp : MonoBehaviour
{
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Coin"))
        {
            Destroy(other.gameObject);
            score++;
            Debug.Log("Twój wynik to " + score);
        }






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
