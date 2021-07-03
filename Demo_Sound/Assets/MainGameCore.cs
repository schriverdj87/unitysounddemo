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
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            swc.PlayTheSound(SndLibrary.SND1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            swc.PlayTheSound(SndLibrary.SND2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            swc.PlayTheSound(SndLibrary.SND3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            swc.PlayTheSound(SndLibrary.SND4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            swc.PlayTheMusic(SndLibrary.SONG);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            swc.ShutUp();
        }


    }
}
