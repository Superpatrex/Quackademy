using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quack : MonoBehaviour
{
    private float time;
    private float duration;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        duration = Random.value * 10f + 5f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > duration)
        {
            time = 0;
            duration = Random.value * 10f + 5f;
            transform.position = new Vector3(5, 0.5f, Random.value * 6 - 3);
            source.Play();
        }
    }
}
