using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Songs : MonoBehaviour {

    private AudioSource audioS;

    [SerializeField]
    private List<AudioClip> songs;

    public bool wantHear = true, dWantHear = false;
    
	// Use this for initialization
	void Awake () {
        this.audioS = GetComponent<AudioSource>();
        audioS.clip = songs[0] as AudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (wantHear == true)
            {
                if (!audioS.isPlaying)
                    PlayRandomMusic();
            }
    }

    void PlayRandomMusic()
    {
        int n = songs.Capacity;
        audioS.clip = songs[Random.Range(0, n)] as AudioClip;
        audioS.Play();
    }


    public void StopSong()
    {
        audioS.Stop();
        wantHear = false;
        dWantHear = true;
    }

    public void StartSong()
    {
        wantHear = true;
        dWantHear = false;
    }
}
