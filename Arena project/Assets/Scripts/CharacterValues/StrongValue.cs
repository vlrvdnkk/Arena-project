using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StrongValue : MonoBehaviour
{
    [SerializeField] private Button _StrongButton;
    [SerializeField] private Character _character;
    [SerializeField] private TextMeshProUGUI _scoreText;
    void Start()
    {
        _StrongButton.onClick.AddListener(OnClick);
    }
    private void OnClick()
    {
        if (_character.ExpScore > 0) 
        {
            _character.Strong++;
            _character.ExpScore--;
            _scoreText.text = _character.ExpScore.ToString();
        }
        
    }
}
