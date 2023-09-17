using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeacherMenu : MonoBehaviour
{
    public GameObject buttonPrefab;
    public GameObject buttonParent;
    public GameObject questionObject;
    private bool first = true;
    public static string selectedLesson;

    private void OnEnable()
    {
        if (!first) return;
        else first = false;
        for (int i = 0; i < GameManager.lessonList.Count; i++)
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent.transform);
            newButton.GetComponent<LessonButton>().lessonText.text =
                GameManager.lessonList[i].LessonName + "\n\n" +
                GameManager.lessonList[i].Description + "\n\n" +
                "Number of Questions: " + GameManager.lessonList[i].Questions.Length;
            newButton.GetComponent<LessonButton>().lessonNumber = i;
            newButton.GetComponent<Button>().onClick.AddListener(() => selectLesson(GameManager.lessonList[newButton.GetComponent<LessonButton>().lessonNumber]));
        }
    }
    private void selectLesson(Lesson les)
    {
        questionObject.GetComponent<QuestionController>().currentLesson = les;
        questionObject.SetActive(true);
        GameObject.Find("TeacherMenu").SetActive(false);

    }
}
