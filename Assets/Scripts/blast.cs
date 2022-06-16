using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blast : MonoBehaviour
{   
    public GameObject explosionEffect;
    public float delay =1.5f;
    float countdown;
    public float radius = 5.0f;
    public float force = 300f;

    bool hasexploded=false;
    void Start()
    {countdown= delay;  
    }

    // Update is called once per frame
    void Update()
    {countdown-=Time.deltaTime;
        if(countdown<=0f && !hasexploded){
            Explode();
            hasexploded=true;
          
        }
    }   
    void Explode(){
         var explode=Instantiate(explosionEffect, transform.position, transform.rotation);
         Collider[] colliders= Physics.OverlapSphere(transform.position, radius);
         foreach (Collider nearbyObject in colliders)
          {    Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
                if(rb!=null){
                    rb.AddExplosionForce(force, transform.position,radius);
                    }
                Destructible dest = nearbyObject.GetComponent<Destructible>();        
                if(dest!=null) {
                   dest.Destroy();
                }  

          }
         Destroy(gameObject);
         Destroy(explode,delay);
    }
}


