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
}

[System.Serializable]
public class Question
{
    public String Text;
    public String [] SelectableAnswers;
    public uint CorrectAnswer;
    public uint PointValue;
    public uint Tries;
}
