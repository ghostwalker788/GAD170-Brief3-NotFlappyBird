using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    private AudioSource m_AudioScource;
    public List<AudioClip> Hitsounds;
    public List<AudioClip> DEDSounds;
    // Start is called before the first frame update
    void Start()
    {
        m_AudioScource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       






    }
    // audio player for hit sound
    // randomly selects a "hit sound" and slighly ajust pitch 
    // then plays sound
    public void PlayHitSound()
    {
        Debug.Log("Ouch!");
        //slighly ajust pitch
        m_AudioScource.pitch = Random.Range(0.5f,1.5f);
        //selects random audio clip
        AudioClip currentAudioClip = Hitsounds [Random.Range(0,Hitsounds.Count)] ;
        //plays said sound
        m_AudioScource.PlayOneShot(currentAudioClip);

    }
    public void PlayDEDsound()
    {
        Debug.Log("OH NO!");
        //slighly ajust pitch
        m_AudioScource.pitch = Random.Range(0.5f, 1.5f);
        //selects random audio clip
        AudioClip currentAudioClip = DEDSounds[Random.Range(0, DEDSounds.Count)];
        //plays said sound
        m_AudioScource.PlayOneShot(currentAudioClip);
    }
}


