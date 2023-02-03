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
    [SerializeField] private double _maxexperience = 100;
    [SerializeField] private Character _character;
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI _levelText;
    [SerializeField] private TextMeshProUGUI _maxexpText;
    [SerializeField] private TextMeshProUGUI _scoreText;

    void Start()
    {

    }

    void Update()
    {
        if (_experience >= _maxexperience)
        {
            _experience = 0;
            _maxexperience *= 1.2;
            slider.maxValue = Convert.ToSingle(_maxexperience);
            _character.Level++;
            _character.ExpScore++;
            _levelText.text = _character.Level.ToString();
            _scoreText.text = _character.ExpScore.ToString();
            _maxexpText.text = Math.Round(_maxexperience, 0).ToString();
        }
        else if (Input.GetMouseButtonDown(0))
            _experience += 1 + _character.Strong * 0.5;
        slider.value = Convert.ToSingle(_experience);

    }
}
