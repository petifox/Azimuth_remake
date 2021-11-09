using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public float InputTreashold;
    // Start is called before the first frame update
    void Start()
    {
        StartTutorial();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartTutorial()
    {
        Debug.Log("Move left");
        StartCoroutine(InvertIfNeeded());
    }
    IEnumerator InvertIfNeeded()
    {
        while(0 - InputTreashold < MasterInput.MovementVector.x && MasterInput.MovementVector.x < 0 + InputTreashold)
        {
            yield return null;
        }
        if(MasterInput.MovementVector.x > 0)
        {
            MasterInput.Invert(true);
            Debug.Log("inverted");
        }
        else
        {
            MasterInput.Invert(false);
            Debug.Log("regular");
        }
        
    }
}
