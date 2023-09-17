using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerChoiceClick : MonoBehaviour
{
    public AudioClip correct;
    public AudioClip incorrect;
    private AudioSource source;
    public GameObject Question;
    public GameObject playerStatistics;
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
            Question.GetComponent<QuestionController>().numberWrong++;
           source.PlayOneShot(incorrect);
        }
        Question.GetComponent<QuestionController>().index++;
        Question.GetComponent<QuestionController>().UpdateQuestion();
        UpdateStatistics();
    }

    public void UpdateStatistics()
    {
        this.playerStatistics.GetComponent<StudentStatistic>().SetQuestionNumber();
        this.playerStatistics.GetComponent<StudentStatistic>().SetScoreString();
        this.playerStatistics.GetComponent<StudentStatistic>().SetPercentCorrect();
    }
}