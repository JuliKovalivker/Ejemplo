using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public GameObject myCube;
    private Vector3 pos; //(0.0f, 0.0f. 0.0f)

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");

    }

    // Update is called once per frame
    void Update()
    {

        myCube.transform.position += new Vector3(0.1f, 0.1f, 0.1f);
    }
}
