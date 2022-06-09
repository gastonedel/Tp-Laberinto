using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSalto : MonoBehaviour
{
    AudioSource source;
    AudioClip salto;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            source.clip = salto;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            source.Play();
        }
        else
        {
            source.Stop();
        }
    }
}
