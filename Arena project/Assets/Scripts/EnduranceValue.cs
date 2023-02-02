using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnduranceValue : MonoBehaviour
{
    [SerializeField] private Button _EnduranceButton;
    [SerializeField] private Character _character;
    [SerializeField] private TextMeshProUGUI _scoreText;
    void Start()
    {
        _EnduranceButton.onClick.AddListener(OnClick);
    }
    private void OnClick()
    {
        if (_character.ExpScore > 0)
        {
            _character.Endurance++;
            _character.ExpScore--;
            _scoreText.text = _character.ExpScore.ToString();
        }
    }
}

