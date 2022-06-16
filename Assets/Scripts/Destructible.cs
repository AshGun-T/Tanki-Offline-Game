using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{  public GameObject destroyedVersion;
    public float countzom = 0f;
     
    public void Destroy()
    { Instantiate(destroyedVersion, transform.position, transform.rotation);
      Destroy(gameObject);
      zsf.scoreAmount+=1;
    }
}
