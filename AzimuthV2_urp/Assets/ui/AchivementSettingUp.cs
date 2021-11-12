using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AchivementSettingUp : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TMP_Text nameTop;
    [SerializeField] private TMP_Text description;

    public void SetFields(Sprite sprite,string name,string desc)
    {
        icon.sprite = sprite;
        nameTop.text = name;
        description.text = desc;
    }
}
