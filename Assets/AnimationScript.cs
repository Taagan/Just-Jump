using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator anir;
    int jumpCalled = Animator.StringToHash("JumpCalled");
    // Start is called before the first frame update
    void Start()
    {
        anir.enabled = true;
        anir.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayAnimation()
    {
        anir.SetTrigger(jumpCalled);
    }
}
