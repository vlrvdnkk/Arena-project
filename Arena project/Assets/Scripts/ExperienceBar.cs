using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceBar : MonoBehaviour
{
    [SerializeField] private double _experience = 0;
    [SerializeField] private int _level = 0;
    [SerializeField] private int _strong = 0;
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI _levelText;

    void Start()
    {

    }

    void Update()
    {
        if (_experience >= 100)
        {
            _experience = 0;
            _level++;
            _levelText.text = _level.ToString();
        }
        else if (Input.GetMouseButtonDown(0))
            _experience += 1 + _strong * 0.5;
        slider.value = Convert.ToSingle(_experience);

    }

}
