using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerManager : MonoBehaviour
{
    //private double CoolDounTimer;
    [SerializeField] private int _clickCount;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _clickCount++;
        }
    }
}