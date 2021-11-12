using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Achivement",menuName ="Scriptable Objects/Achivement")]
public class AchivementSO : ScriptableObject
{
    public Sprite icon;
    public string nameTop;
    [TextArea(0,6)]
    public string desc;
}
