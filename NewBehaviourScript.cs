using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;
    public AudioSource audio6;
    public AudioSource audio7;
    public AudioSource audio8; 
    public AudioSource audio9;



    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
            audio1.Play();
        if (Input.GetKeyUp(KeyCode.A))
            audio2.Play();
        if (Input.GetKeyUp(KeyCode.G))
            audio3.Play();
        if (Input.GetKeyUp(KeyCode.C))
            audio4.Play();
        if (Input.GetKeyUp(KeyCode.Q))
            audio5.Play();
        if (Input.GetKeyUp(KeyCode.R))
            audio6.Play();
        if (Input.GetKeyUp(KeyCode.P))
            audio7.Play();
        if (Input.GetKeyUp(KeyCode.Y))
            audio8.Play(); 
        if (Input.GetKeyUp(KeyCode.U))
            audio9.Play();


    }
}
