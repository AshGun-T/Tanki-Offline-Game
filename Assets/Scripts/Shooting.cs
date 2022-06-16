using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject theBullet;
    public Transform barrelEnd;
    public AudioSource sound;
   // public AudioSource boom; 
    public int bulletSpeed;
    public float despawnTime = 3.0f;

    public bool shootAble = true;
    public float waitBeforeNextShot = 0.5f;
     
    void Start()
    {sound= GetComponent<AudioSource>();
   // boom= GetComponent<AudioSource>();
     }
    private void Update ()
    {  if (Input.GetKey (KeyCode.Space))
        {
            if (shootAble)
            { shootAble = false;
                Shoot ();
                StartCoroutine (ShootingYield ());
                //boom.PlayDelayed(1.5f);
               
            }
        }
    }

    IEnumerator ShootingYield ()
    {
        yield return new WaitForSeconds (waitBeforeNextShot);
        shootAble = true;
    }
    void Shoot ()
    {
        var bullet = Instantiate (theBullet, barrelEnd.position, barrelEnd.rotation);
        bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * bulletSpeed;
        sound.Play();
        Destroy (bullet, despawnTime);
    }
}

