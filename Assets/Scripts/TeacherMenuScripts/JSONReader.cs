    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class JSONReader : MonoBehaviour
    {
        public static UnityEngine.Object[] jsonFileObjects;
        public static List<Lesson> lessonList = new List<Lesson>();
        public GameObject teacherMenu;

        void Start()
        {
            jsonFileObjects = GetAllPath("Lessons");

            foreach (TextAsset item in jsonFileObjects)
            {
                Lesson lessonInJson = JsonUtility.FromJson<Lesson>(item.text);
                lessonList.Add(lessonInJson);
                Debug.Log(lessonInJson.LessonName);
            }
        GameManager.instance.setLessonList(lessonList);
        Debug.Log("Game Manager: " + GameManager.lessonList[0].LessonName);
        teacherMenu.SetActive(true);
        }

        public static TextAsset[] GetAllPath(string path)
        {
            List<TextAsset> myList = new List<TextAsset>();
            String applicationDataPath = Application.dataPath + "/" + path;
            String [] fileNames = Directory.GetFiles(applicationDataPath);

            foreach (String file in fileNames)
            {
                int assetPathIndex = file.IndexOf("Assets");
                string localPath = file.Substring(assetPathIndex);

                TextAsset obj = (UnityEngine.TextAsset)UnityEditor.AssetDatabase.LoadAssetAtPath(localPath, typeof(TextAsset));

                if (obj != null)
                {
                    myList.Add(obj);
                } 
            }


            return myList.ToArray();
        }
    }

