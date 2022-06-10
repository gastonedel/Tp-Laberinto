using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collider : MonoBehaviour
{
    AudioSource source;
    public AudioClip golpe;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
   void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "pared")
        {
            source.clip = golpe;
            source.Play();
            Debug.Log("Choca");
        }
        if (collision.gameObject.tag == "victoria")
        {
            SceneManager.LoadScene("Victoria");
        }
    }
}
