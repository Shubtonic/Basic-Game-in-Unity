using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereaSwitch : MonoBehaviour {
    [SerializeField]
    Camera FirstPCamera;
    [SerializeField]
    Camera ThirdPCamera;
    [SerializeField]
    Camera BackCamera;
    private bool switchCam = false;
    private bool backCam = false;


	// Use this for initialization
	void Start ()
    {
        FirstPCamera.GetComponent<Camera>().enabled = false;
        ThirdPCamera.GetComponent<Camera>().enabled = true;
        BackCamera.GetComponent<Camera>().enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
    if (Input.GetKeyDown("t"))
        {
            switchCam = !switchCam;
            backCam = false;
        }

        if (Input.GetKeyDown("b"))
        {
            switchCam = false;
            backCam = true;
        }
    if(switchCam == true) 
        {
            FirstPCamera.GetComponent<Camera>().enabled = true;
            ThirdPCamera.GetComponent<Camera>().enabled = false;
            BackCamera.GetComponent<Camera>().enabled = false;
        }
        else if(backCam == true)
        {
            FirstPCamera.GetComponent<Camera>().enabled = false;
            ThirdPCamera.GetComponent<Camera>().enabled = false;
            BackCamera.GetComponent<Camera>().enabled = true;
        }
        else
        {
            FirstPCamera.GetComponent<Camera>().enabled = false;
            ThirdPCamera.GetComponent<Camera>().enabled = true;
            BackCamera.GetComponent<Camera>().enabled = false;
        }
	}
}
