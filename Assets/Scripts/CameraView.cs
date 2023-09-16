using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    public Camera MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha1))
        {
            MainCamera.enabled = false;
        }
        if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha2))
        {
            MainCamera.enabled = true;
        }
    }
}
