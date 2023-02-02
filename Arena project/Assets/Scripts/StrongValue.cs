using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrongValue : MonoBehaviour
{
    [SerializeField] private Button _StrongButton;
    [SerializeField] private Character _character;
    void Start()
    {
        _StrongButton.onClick.AddListener(OnClick);
    }
    private void OnClick()
    {
        _character.Strong++;
    }
}
