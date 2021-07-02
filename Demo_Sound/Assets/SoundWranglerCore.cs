using UnityEngine.Audio;
using UnityEngine;

// A sort of "box" 
public class SoundWranglerCore : MonoBehaviour
{
    //This is set through the interface
    [SerializeField] public AudioClip sound;
    private AudioSource sauce;
    // Start is called before the first frame update
    void Start()
    {
        //Use this method to instantiate a sauce
        sauce = gameObject.AddComponent<AudioSource>();
        //Plug the AudioClip into the source
        sauce.clip = sound;
    }

    public void PlayTheSound()
    {
        sauce.Play();
    }
}
