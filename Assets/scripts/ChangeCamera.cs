using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera camera;
    public int zoomTo;
    private float targetZoom;
    public float rotationSpeed;
    public float angleToRotateTo;
    Transform targetRotVec;
    Transform startRot;
    bool rotate;
    [SerializeField]
    string README = "Add the value you wish to make to the camera(7 is default)";
    // Start is called before the first frame update



        //TO USE ROTATIONCHANGER!
        //Set angleToRotateTo to whatever rotation unit you want!
        //Set RotationSpeed!
        //READY TO USE


        //If angleToRotateTo is negative the object will tilt to the left, if its positive the camera will tilt to the right.
       //putting in a negative value for rotationSpeed stops the camera from rotating at all.
       //leaving rotationSpeed at 0 stops the rotation method from being called.
    void Start()
    {
        camera = Camera.main;
        GameObject emptyGo = new GameObject();
        startRot = camera.transform;
        targetZoom = camera.orthographicSize;
        emptyGo.transform.rotation = Quaternion.Euler(0, 0, angleToRotateTo);
        targetRotVec = emptyGo.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
            tiltCamera();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            camera.orthographicSize = zoomTo;
        }
        if (rotationSpeed != 0)
        {
            rotate = true;
        }
    }

    private void tiltCamera()
    {
        Debug.Log("TRIGGERED");
        camera.transform.rotation = Quaternion.Slerp(startRot.rotation, targetRotVec.transform.rotation, rotationSpeed * Time.deltaTime);
        if (camera.transform.rotation == targetRotVec.transform.rotation)
        {
            rotate = false;
        }
    }
}
