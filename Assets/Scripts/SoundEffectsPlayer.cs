using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1,sfx2,sfx3,sfx4;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.W))
    {
        src.clip = sfx1;
        src.Play();
    }

        if (Input.GetKeyDown(KeyCode.Space))
        {
        src.clip = sfx2;
        src.Play();
        }
       


    }

}
