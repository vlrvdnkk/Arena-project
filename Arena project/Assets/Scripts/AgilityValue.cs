using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AgilityValue : MonoBehaviour
{
    [SerializeField] private Button _AgilityButton;
    [SerializeField] private Character _character;
    [SerializeField] private TextMeshProUGUI _scoreText;
    void Start()
    {
        _AgilityButton.onClick.AddListener(OnClick);
    }
    private void OnClick()
    {
        if (_character.ExpScore > 0)
        {
            _character.Agility++;
            _character.ExpScore--;
            _scoreText.text = _character.ExpScore.ToString();
        }
    }
}
