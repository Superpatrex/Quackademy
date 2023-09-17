using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionController : MonoBehaviour
{
    public Lesson currentLesson;
    public TMP_Text questionTitle;
    public TMP_Text answer1Text;
    public TMP_Text answer2Text;
    public TMP_Text answer3Text;
    public TMP_Text answer4Text;
    public GameObject teacherMenu;
    public GameObject boomBox;
    public uint correctAnswer;
    public int index;
    
    void OnEnable()
    {
        index = 0;
        UpdateQuestion();
    }

    public void UpdateQuestion()
    {
        if (index >= this.currentLesson.Questions.Length)
        {
            boomBox.GetComponent<AudioSource>().Play();
            teacherMenu.SetActive(true);
            GameObject.Find("Question").SetActive(false);
        }
        else
        {
            this.questionTitle.GetComponent<TMP_Text>().text = this.currentLesson.Questions[index].Text;
            answer1Text.text = this.currentLesson.Questions[index].SelectableAnswers[0];
            answer2Text.text = this.currentLesson.Questions[index].SelectableAnswers[1];
            answer3Text.text = this.currentLesson.Questions[index].SelectableAnswers[2];
            answer4Text.text = this.currentLesson.Questions[index].SelectableAnswers[3];
            this.correctAnswer = this.currentLesson.Questions[index].CorrectAnswer + 1;
        }
        
    }

    public void Update()
    {

    }
}
