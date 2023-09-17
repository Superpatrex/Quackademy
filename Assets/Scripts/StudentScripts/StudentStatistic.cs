using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StudentStatistic : MonoBehaviour
{
    public TMP_Text LessonName;
    public TMP_Text QuestionNumber;
    public TMP_Text ScoreString;
    public TMP_Text PercentCorrect;
    public GameObject Question;

    public void SetLessonName()
    {
        this.LessonName.text =  Question.GetComponent<QuestionController>().currentLesson.LessonName;
    }  

    public void SetQuestionNumber()
    {
        this.QuestionNumber.text = "#" + (Question.GetComponent<QuestionController>().index + 1).ToString();
    }

    public void SetQuestionNumber(int start)
    {
        this.QuestionNumber.text = "#" + (start).ToString();
    }

    public void SetScoreString()
    {
        this.ScoreString.text = "[" + (Question.GetComponent<QuestionController>().GetNuberRight()).ToString() + "/" + (Question.GetComponent<QuestionController>().index).ToString() + "]";
    }

    public void SetScoreString(int start)
    {
        this.ScoreString.text = "[" + (start).ToString() + "/" + (Question.GetComponent<QuestionController>().index + 1).ToString() + "]";
    }

    public void SetPercentCorrect()
    {
        this.PercentCorrect.text = (Question.GetComponent<QuestionController>().GetPercent()) + "%";
    }

    public void SetPercentCorrect(int start)
    {
        this.PercentCorrect.text = (start).ToString() + "%";
    }
}
