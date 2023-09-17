using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswerChoiceClick : MonoBehaviour
{
    public AudioClip correct;
    public AudioClip incorrect;
    private AudioSource source;
    public GameObject Question;
    public GameObject playerStatistics;
    public uint QuestionNumber;
    private bool isClickedButton = false;
    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Runs when this answer choice is clicked
    public void isClicked()
    {
        if (!isClickedButton)
        {
            if (QuestionNumber == Question.GetComponent<QuestionController>().correctAnswer)
            {
                source.PlayOneShot(correct);
                TMP_FontAsset tempFont;//
                Question.GetComponent<QuestionController>().questionTitle.text = "CORRECT";
            }
            else
            {
                Question.GetComponent<QuestionController>().numberWrong++;
                source.PlayOneShot(incorrect);
                Question.GetComponent<QuestionController>().questionTitle.text = "INCORRECT";
            }    
            isClickedButton = true;
        }
        
    }

    public void UpdateStatistics()
    {
        this.playerStatistics.GetComponent<StudentStatistic>().SetQuestionNumber();
        this.playerStatistics.GetComponent<StudentStatistic>().SetScoreString();
        this.playerStatistics.GetComponent<StudentStatistic>().SetPercentCorrect();
    }

    void Update()
    {
        if(isClickedButton)
        {
            this.time += Time.deltaTime;

            if (time > 2.0f)
            {
                time = 0;
                isClickedButton = false;
                Question.GetComponent<QuestionController>().index++;
                Question.GetComponent<QuestionController>().UpdateQuestion();
                UpdateStatistics();
            }
        }
    }
}