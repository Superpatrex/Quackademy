using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckFollow : MonoBehaviour
{
    public Camera UserCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new UnityEngine.Vector3(UserCamera.transform.position.x, 0, UserCamera.transform.position.z);
    }
}
