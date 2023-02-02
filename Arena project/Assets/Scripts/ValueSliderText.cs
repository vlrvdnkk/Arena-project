using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ValueSliderText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _valueText;
    private void ValueChange (float value)
    {
        _valueText.text = value.ToString();
    }

}
