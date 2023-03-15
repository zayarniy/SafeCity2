using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void OnMouseDown()
    {
        //print("Animation control"+animator.isActiveAndEnabled);
        
        if (animator != null)
            animator.enabled=!animator.enabled;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
