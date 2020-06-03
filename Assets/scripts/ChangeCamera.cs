using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera camera;
    public int zoomTo;
    private float targetZoom;
    [SerializeField]
    string README = "Add the value you wish to make to the camera(7 is default)";
    // Start is called before the first frame update
    void Start()
    {
        targetZoom = camera.orthographicSize;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            camera.orthographicSize = zoomTo;
        }
    }
}
