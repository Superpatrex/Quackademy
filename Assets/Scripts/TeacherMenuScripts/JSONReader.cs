using UnityEngine;
    using System;
    using System.Collections.Generic;
    using System.IO;
using UnityEngine.UI;

public class JSONReader : MonoBehaviour
    {
        public static UnityEngine.Object[] jsonFileObjects;
        public static List<Lesson> lessonList = new List<Lesson>();
        public Text Lesson1;
        public Text Lesson2;
        public Text Lesson3;

        public GameObject teacherMenu;

        void Start()
        {

        Lesson lessonInJson = JsonUtility.FromJson<Lesson>(Lesson1.text);
        lessonList.Add(lessonInJson);
         lessonInJson = JsonUtility.FromJson<Lesson>(Lesson2.text);
        lessonList.Add(lessonInJson);
         lessonInJson = JsonUtility.FromJson<Lesson>(Lesson3.text);
        lessonList.Add(lessonInJson);

        GameManager.instance.setLessonList(lessonList);

        teacherMenu.SetActive(true);
        //Debug.Log("Game Manager: " + GameManager.lessonList[0].LessonName);

        if (GameManager.lessonList != null && GameManager.lessonList.Count != 0)
        {
        }
        
        /*
            Question[] list1 = new Question[3];
            String[] questions = { "1", "2", "3", "4" };

            list1[0] = new Question("1 + 1 = ", questions, 1, 10, 1);
            list1[1] = new Question("1 + 2 = ", questions, 2, 10, 1);
            list1[2] = new Question("2 + 2 = ", questions, 3, 10, 1);
            

            lessonList.Add(new Lesson("Math Assignment 1", "This is a generic Math lesson", list1));
               
            
        */
        }

        /*
        public TextAsset[] GetAllPath(string path)
        {
            List<TextAsset> myList = new List<TextAsset>();
            String applicationDataPath = Application.streamingAssetsPath + "\\" + path;
            String [] fileNames = Directory.GetFiles(applicationDataPath);
            

            foreach (String file in fileNames)
            {
                int assetPathIndex = file.IndexOf("Text");
                string localPath = file.Substring(assetPathIndex);
                string ending = System.IO.Path.GetExtension(localPath);

                if (ending != ".json")
                {
                    continue;
                }
                
                string result = localPath.Substring(0, localPath.Length - ending.Length);

                TextAsset obj = Resources.Load<TextAsset>(result);

                if (obj != null)
                {
                    myList.Add(obj);
                }
                
            }

            return myList.ToArray();
        }
        */
        
    }