using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerChoiceClick : MonoBehaviour
{
    public AudioClip correct;
    public AudioClip incorrect;
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Runs when this answer choice is clicked
    public void isClicked()
    {

        source.PlayOneShot(incorrect);
    }
}
