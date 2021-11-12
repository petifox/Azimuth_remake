using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenController : MonoBehaviour
{
    public static OxygenController Instance;
    public Slider slider;
    [Space]
    public bool MovementMatters;
    public float MovementSpeed;
    [Space]
    public bool TimeMatters;
    public float TimeSpeed;
    private void OnEnable()
    {
        DontDestroyOnLoad(this.gameObject);
        if (Instance == null)
            Instance = this;
    }
    private void OnDisable()
    {
        Instance = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeMatters)
            AddRemoveOxygen(Mathf.Abs(Mathf.Sin(Time.time) * TimeSpeed * Time.deltaTime));

        if (MovementMatters)
            AddRemoveOxygen((Mathf.Abs(MasterInput.MovementVector.x) + Mathf.Abs(MasterInput.MovementVector.y)) * -MovementSpeed * Time.deltaTime);
    }

    public void AddRemoveOxygen(float amount)
    {
        slider.value += amount;
    }
}
