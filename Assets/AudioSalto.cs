using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSalto : MonoBehaviour
{
    AudioSource source;
    public AudioClip Salto;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            source.clip = Salto;
            source.Play();
            Debug.Log("salto");
        }


    }
}
