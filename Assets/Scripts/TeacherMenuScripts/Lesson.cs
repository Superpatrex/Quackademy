using UnityEngine;
using System;

[System.Serializable]
public class Lesson
{
    public String LessonName;
    public String Description;
    public Question [] Questions;

    public static Lesson CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<Lesson>(jsonString);
    }

    public Lesson(string LessonName, string Description, Question [] Questions)
    {
        this.LessonName = LessonName;
        this.Description = Description;
        this.Questions = Questions;
    }
}

[System.Serializable]
public class Question
{
    public String Text;
    public String [] SelectableAnswers;
    public uint CorrectAnswer;
    public uint PointValue;
    public uint Tries;

    public Question(string Text, string[] SelectableAnswers, uint CorrectAnswer, uint PointValue, uint Tries)
    {
        this.Text = Text;
        this.SelectableAnswers = SelectableAnswers;
        this.CorrectAnswer = CorrectAnswer;
        this.PointValue = PointValue;
        this.Tries = Tries;
    }
}
