using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public GameObject myCube;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myCube.transform.position += new Vector3(0.1f, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            myCube.transform.position -= new Vector3(0.1f, 0f, 0f);
        }
        
    }

    /*
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("a");
    }
    */
}
