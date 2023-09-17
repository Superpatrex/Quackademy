using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

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
    public GameObject playerStatistics;
    public uint correctAnswer;
    public int index;
    public int numberWrong;

    private static QuestionController controller;
    
    void OnEnable()
    {
        controller = this;
        this.playerStatistics.GetComponent<StudentStatistic>().SetLessonName();
        this.playerStatistics.GetComponent<StudentStatistic>().SetScoreString(0);
        this.playerStatistics.GetComponent<StudentStatistic>().SetQuestionNumber(1);
        this.playerStatistics.GetComponent<StudentStatistic>().SetPercentCorrect(100);
        index = 0;
        numberWrong = 0;
        UpdateQuestion();
    }

    public void UpdateQuestion()
    {
        if (index >= this.currentLesson.Questions.Length)
        {
            boomBox.GetComponent<AudioSource>().Play();
            teacherMenu.SetActive(true);
            GameObject.Find("Question").SetActive(false);
            CameraView.GoToMenu();
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

    public String GetPercent()
    {
        if (numberWrong == 0)
        {
            return "100";
        }
        
        float temp = ((float)(index - numberWrong) / (float)(index)) * 100.0f;
        return Mathf.Round(temp).ToString(); 
    }

    public int GetNuberRight()
    {
        return this.index - numberWrong;
    }

    public void Update()
    {

    }

    public static void ResetAll()
    {
        controller.playerStatistics.GetComponent<StudentStatistic>().SetLessonName();
        controller.playerStatistics.GetComponent<StudentStatistic>().SetScoreString(0);
        controller.playerStatistics.GetComponent<StudentStatistic>().SetQuestionNumber(1);
        controller.playerStatistics.GetComponent<StudentStatistic>().SetPercentCorrect(100);
    }
}