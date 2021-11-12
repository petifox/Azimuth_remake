using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchivementManager : MonoBehaviour
{
    [SerializeField] private List<AchivementSO> data;
    [SerializeField] private GameObject achivementObj;
    [SerializeField] private Transform parent;
    void Start()
    {
        foreach(var item in data)
        {
           Instantiate(achivementObj,parent).GetComponent<AchivementSettingUp>().SetFields(item.icon, item.nameTop, item.desc);
           
        }
    }

    
}
