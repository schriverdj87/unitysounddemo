using UnityEngine.Audio;
using UnityEngine;

// A sort of "box" 
public class SoundWranglerCore : MonoBehaviour
{
    //This is set through the interface
    [SerializeField] public AudioClip[] sounds;
    [SerializeField] public AudioClip[] music;
    private AudioSource sauce;
    private AudioSource sauceMusic;
    // Start is called before the first frame update
    [Range(0f,1f)]
    [SerializeField] public float volumeMaster = 1f;
    [Range(0f, 1f)]
    [SerializeField]public float volume  = 0.5f;
    [Range(0f, 1f)]
    [SerializeField] public float volumeMusic = 0.1f;
    void Start()
    {
        //Use this method to instantiate a sauce
        sauce = gameObject.AddComponent<AudioSource>();
        sauceMusic = gameObject.AddComponent<AudioSource>();
        sauceMusic.loop = true;

    }


    private AudioClip GetFromArray(string getthis, AudioClip[] fromthis)
    {
        foreach (AudioClip ac in fromthis)
        {

            if (ac.name == getthis)
            {
                //Debug.Log(ac.name + " : " + getthis);
                return ac;
            }
        }


        return null;
    }

    public AudioClip GetSound(string getthis)
    {

        return GetFromArray(getthis, sounds);
    }

    public AudioClip GetMusic(string getthis)
    {

        return GetFromArray(getthis, music);
    }

    private void Play(AudioClip playthis, AudioSource inthis)
    {
  
        if (playthis != null)
        {
            inthis.PlayOneShot(playthis, volumeMusic * volumeMaster);
        }
        else
        {
            Debug.Log("SoundWranglerCore: Can't find that sound!");
        }
    }

    public void PlayTheMusic(string getthis)
    {

        Play(GetMusic(getthis), sauceMusic);
       
    }
    public void PlayTheSound(string getthis)
    {

        Play(GetSound(getthis), sauceMusic);
        
    }

    public void StopSounds()
    {
        sauce.Stop();
    }
    
    public void StopMusic()
    {
        sauceMusic.Stop();
    }

    public void ShutUp()
    {
        sauce.Stop();
        sauceMusic.Stop();
    }

    
}
