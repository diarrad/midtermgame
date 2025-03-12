using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour

{
    //The player calls this function on the coin whenever they bump into it
    //You can change its contents if you want something different to happen on collection
    //For example, what if the coin teleported to a new location instead of being destroyed?
    public void GetBumped()
    {
        //This destroys the coin
        Destroy(gameObject);
    }
    public float coinspeed = 2.5f;
    public float range = 5f;
    public Vector2 startposition;
    public Rigidbody2D coin;

    

    

    void Update()
    {
        
        transform.position += new Vector3(2*Time.deltaTime,1*Time.deltaTime,0 );
        
    }

    
        
    
}
