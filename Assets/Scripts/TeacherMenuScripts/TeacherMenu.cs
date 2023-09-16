using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeacherMenu : MonoBehaviour
{
    public GameObject buttonPrefab;
    public GameObject buttonParent;

    private void OnEnable()
    {
        for (int i = 0; i < GameManager.lessonList.Count; i++)
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent.transform);
            newButton.GetComponent<LessonButton>().lessonText.text =
                GameManager.lessonList[i].LessonName + "\n\n" +
                GameManager.lessonList[i].Description + "\n\n" +
                "Number of Questions: " + GameManager.lessonList[i].Questions.Length;
            newButton.GetComponent<Button>().onClick.AddListener(() => selectLesson(i));
        }
    }
    private void selectLesson(int i)
    {
        Debug.Log("Selected Lesson: " + i);
    }
}
