using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera camera;
    public int zoomTo;
    //public int zoomFactor;
    private float targetZoom, lerpSpeed;
    public string README = "Add the value you wish to make to the camera(7 is default)";
    // Start is called before the first frame update
    void Start()
    {
        targetZoom = camera.orthographicSize;
        lerpSpeed = 4f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            camera.orthographicSize = zoomTo;
            //targetZoom += zoomFactor;
            //camera.orthographicSize = Mathf.Lerp(camera.orthographicSize, targetZoom, Time.deltaTime * lerpSpeed);

        }

    }
}
