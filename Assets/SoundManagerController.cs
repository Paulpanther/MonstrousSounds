using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerController : MonoBehaviour
{

    public static AudioClip stepSound;
    static AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        stepSound = Resources.Load<AudioClip>("step");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void playSound(int soundId)
    {
        switch (soundId)
        {
            case 0:
                audioSource.PlayOneShot(stepSound);
                break;
        }
    }
}
