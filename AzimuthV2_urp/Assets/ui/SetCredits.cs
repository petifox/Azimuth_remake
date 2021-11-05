using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;
public class SetCredits : MonoBehaviour
{
    private TMP_Text description;
    public CreditsDescription textToLoad;

    void Start()
    {
        description = this.gameObject.GetComponent<TMP_Text>();
        description.text = textToLoad.desc;
    }

}
