using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour
{public AudioSource soundfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  if(Input.GetKey (KeyCode.Space)){
        soundfx.PlayDelayed(1.5f);
    }
        
    }
}
