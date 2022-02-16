using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class congrats : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource pop;
    public AudioSource Bg;
    void Start()
    {
        pop.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Bg.Stop();
        
    }
}
