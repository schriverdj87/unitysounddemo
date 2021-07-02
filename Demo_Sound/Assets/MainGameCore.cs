using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The main class of the "game" 
public class MainGameCore : MonoBehaviour
{
    SoundWranglerCore swc;

    private void Start()
    {
        swc = FindObjectOfType<SoundWranglerCore>();
    }
    // Update is called once per frame
    void Update()
    {
        //If they press F the sound plays
        if (Input.GetKeyDown(KeyCode.F))
        {
            swc.PlayTheSound();
        }
    }
}
