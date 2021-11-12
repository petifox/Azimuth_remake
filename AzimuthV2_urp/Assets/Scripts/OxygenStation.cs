using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class OxygenStation : MonoBehaviour
{
    [Layer] public int PlayerLayer;
    public float TimeToLoad;
    public float AmountToGive;
    public bool CanBeCollected;
    float resetTime;
    public float visibility;

    public Material material;
    // Start is called before the first frame update
    void Start()
    {
        resetTime = -TimeToLoad;
        CanBeCollected = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.gameObject.layer == PlayerLayer)
        {
            if(CanBeCollected)
            {
                //play audio
                OxygenController.Instance.AddRemoveOxygen(AmountToGive);
                StartCoroutine(Timer());
            }
            else
            {
                //play audio
            }
        }
    }
    IEnumerator Timer()
    {
        CanBeCollected = false;
        resetTime = Time.time;
        yield return new WaitForSeconds(TimeToLoad);
        CanBeCollected = true;
    }
    private void Update()
    {
        visibility = (Time.time - resetTime) / TimeToLoad;
        GetComponent<Renderer>().material.SetFloat("amount", visibility);
    }
}
