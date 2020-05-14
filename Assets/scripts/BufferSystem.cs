using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BufferSystem : MonoBehaviour
{
    bool active;
    int bufferTimerLength = 100;
    public BufferSystem()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //public void Buffer(GameObject go,string playerScript)
    //{

    //    if (playerScript == "BottomPlayerScript")
    //    {
    //        for (int timer = 0; timer <= bufferTimerLength; timer++)
    //        {
    //            if (go.GetComponent<BottomPlayerScript>().canJump)
    //            {
    //                GetComponent<MovementPlayer>().FullJump();
    //                go.GetComponent<BottomPlayerScript>().canJump = false;
    //                timer = bufferTimerLength;
    //            }
    //        }
                
            
    //    }
    //    else if (playerScript == "MiddlePlayerScript")
    //    {

    //    }
    //    else if (playerScript == "TopPlayerScript")
    //    {

    //    }
    //    else
    //    {
    //        Debug.Log("wrong script name");
    //    }

    //}
}
