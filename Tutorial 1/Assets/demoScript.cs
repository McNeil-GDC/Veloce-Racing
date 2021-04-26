using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoScript : MonoBehaviour
{
    public Transform cube;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cube.Rotate(20f, 0f, 0f, Space.Self);
        Debug.Log("Hello World!");
    }
}
