using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    public Camera OverheadCamera;
    public Camera FloorCamera;
    public Camera SpectatorCamera;
    public GameObject TeacherMenu;

    private Camera CurrentCamera;
    private float oRotation = -90;
    private float fRotation = -90;

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
            CurrentCamera = SpectatorCamera;
            CurrentCamera.enabled = true;
        }

        if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha2))
        {
            CurrentCamera.enabled = false;
            CurrentCamera = OverheadCamera;
            CurrentCamera.enabled = true;
        }

        if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha3))
        {
            CurrentCamera.enabled = false;
            CurrentCamera = FloorCamera;
            CurrentCamera.enabled = true;
        }

        if (UnityEngine.Input.GetKeyDown(KeyCode.Q))
            CurrentCamera.cullingMask ^= (1 << 6);

        if (OverheadCamera.enabled)
        {
            if (UnityEngine.Input.GetKey(KeyCode.LeftArrow))
            {
                oRotation += 45f * (Time.deltaTime);
            }

            if (UnityEngine.Input.GetKey(KeyCode.RightArrow))
            {
                oRotation -= 45f * (Time.deltaTime);
            }

            OverheadCamera.transform.position = Quaternion.Euler(0, oRotation, 0) * new Vector3(0, 5.2f, -5.5f);
            OverheadCamera.transform.rotation = Quaternion.LookRotation(SpectatorCamera.transform.position - OverheadCamera.transform.position);
        }

        if (FloorCamera.enabled)
        {
            if (UnityEngine.Input.GetKey(KeyCode.LeftArrow))
            {
                fRotation += 45f * (Time.deltaTime);
                if (fRotation > 0)
                    fRotation = 0;
            }

            if (UnityEngine.Input.GetKey(KeyCode.RightArrow))
            {
                fRotation -= 45f * (Time.deltaTime);
                if (fRotation < -180)
                    fRotation = -180;
            }

            FloorCamera.transform.position = Quaternion.Euler(0, fRotation, 0) * new Vector3(0, 1.5f, -3.5f);
            FloorCamera.transform.rotation = Quaternion.LookRotation(SpectatorCamera.transform.position - FloorCamera.transform.position + new Vector3(-2, 0, 0));
        }

        TeacherMenu.transform.position = CurrentCamera.transform.position + CurrentCamera.transform.forward * 1;
        TeacherMenu.transform.rotation = CurrentCamera.transform.rotation;
    }
}
