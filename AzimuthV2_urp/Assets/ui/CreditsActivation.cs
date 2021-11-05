using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsActivation : MonoBehaviour
{
    public Animator animator;

    public void BeginAnimation()
    {
        animator.SetBool("Start", true);
    }
    public void EndAnimation()
    {
        animator.SetBool("Start", false);
    }
}
