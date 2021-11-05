using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
[CreateAssetMenu(fileName ="Credits",menuName ="Scriptable Objects/Credits")]

public class CreditsDescription : ScriptableObject
{
    [TextArea(30,1000)]
    public string desc;
}
