using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator anir; // Animations objektet
    int jumpCalled = Animator.StringToHash("JumpCalled");


    // Start is called before the first frame update
    void Start()
    {
        anir.enabled = true;
        anir.GetComponent<Animator>();

    }

    public void PlayAnimation()
    {
        //Play animation when called
        anir.SetTrigger(jumpCalled);
    }
}
