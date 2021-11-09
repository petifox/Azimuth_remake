using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsMobile : MonoBehaviour
{
    public List<GameObject> MobileObjects;
    // Start is called before the first frame update
    void Start()
    {

#if UNITY_IOS || UNITY_ANDROID
        foreach (var item in MobileObjects)
        {
            item.SetActive(true);
        }
#else
        foreach (var item in MobileObjects)
        {
            item.SetActive(false);
        }

#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
