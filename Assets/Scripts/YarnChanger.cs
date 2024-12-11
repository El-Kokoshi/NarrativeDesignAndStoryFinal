using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Yarn.Unity;

public class YarnChanger : MonoBehaviour
{
    public Sprite sp1,sp2,sp3,sp4,sp5;
    public AudioClip ac1,ac2,ac3,ac4,ac5;
    public DialogueRunner dialogueRunner;
    [YarnCommand("change1")]
    public void SpriteChanger1()
    {
        GetComponent<SpriteRenderer>().sprite = sp1;
    }

    [YarnCommand("change2")]
    public void SpriteChanger2()
    {
        GetComponent<SpriteRenderer>().sprite = sp2;
    }

    [YarnCommand("change3")]
    public void SpriteChanger3()
    {
        GetComponent<SpriteRenderer>().sprite = sp3;
    }

    [YarnCommand("change4")]
    public void SpriteChanger4()
    {
        GetComponent<SpriteRenderer>().sprite = sp4;
    }

    [YarnCommand("change5")]
    public void SpriteChanger5()
    {
        GetComponent<SpriteRenderer>().sprite = sp5;
    }
    
    [YarnCommand("audio1")]
    public void AudioPlayer1()
    {
        GetComponent<AudioSource>().clip = ac1;
        AudioSource.PlayClipAtPoint (ac1, transform.position);
    }

    [YarnCommand("audio2")]
    public void AudioPlayer2()
    {
        GetComponent<AudioSource>().clip = ac2;
        AudioSource.PlayClipAtPoint (ac2, transform.position);
    }

    [YarnCommand("audio3")]
    public void AudioPlayer3()
    {
        GetComponent<AudioSource>().clip = ac3;
        AudioSource.PlayClipAtPoint (ac3, transform.position);
    }

    [YarnCommand("audio4")]
    public void AudioPlayer4()
    {
        GetComponent<AudioSource>().clip = ac4;
        AudioSource.PlayClipAtPoint (ac4, transform.position);
    }

    [YarnCommand("audio5")]
    public void AudioPlayer5()
    {
        GetComponent<AudioSource>().clip = ac5;
        AudioSource.PlayClipAtPoint (ac5, transform.position);
    }
        
}