using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerChoiceClick : MonoBehaviour
{
    public AudioClip correct;
    public AudioClip incorrect;
    private AudioSource source;
    public GameObject Question;
    public uint QuestionNumber;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Runs when this answer choice is clicked
    public void isClicked()
    {
        
        if (QuestionNumber == Question.GetComponent<QuestionController>().correctAnswer)
        {
           source.PlayOneShot(correct);
        }
        else
        {
           source.PlayOneShot(incorrect);
        }
        Question.GetComponent<QuestionController>().index++;
        Question.GetComponent<QuestionController>().UpdateQuestion();
    }
}
