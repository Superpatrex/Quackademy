using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    public Camera OverheadCamera;
    public Camera SpectatorCamera;
    public GameObject TeacherMenu;

    private Camera CurrentCamera;
    private float rotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        CurrentCamera = OverheadCamera;
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha1))
        {
            CurrentCamera.enabled = false;
            CurrentCamera = OverheadCamera;
            CurrentCamera.enabled = true;
        }

        if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha2))
        {
            CurrentCamera.enabled = false;
            CurrentCamera = SpectatorCamera;
            CurrentCamera.enabled = true;
        }

        if (UnityEngine.Input.GetKeyDown(KeyCode.Q))
            CurrentCamera.cullingMask ^= (1 << 6);

        if (OverheadCamera.enabled)
        {
            if (UnityEngine.Input.GetKey(KeyCode.LeftArrow))
            {
                rotation += 45f * (Time.deltaTime);
            }

            if (UnityEngine.Input.GetKey(KeyCode.RightArrow))
            {
                rotation -= 45f * (Time.deltaTime);
            }

            OverheadCamera.transform.position = Quaternion.Euler(0, rotation, 0) * new Vector3(0, 5.2f, -5.5f);
            OverheadCamera.transform.rotation = Quaternion.LookRotation(SpectatorCamera.transform.position - OverheadCamera.transform.position);
        }

        TeacherMenu.transform.position = CurrentCamera.transform.position + CurrentCamera.transform.forward * 1;
        TeacherMenu.transform.rotation = CurrentCamera.transform.rotation;
    }
}
