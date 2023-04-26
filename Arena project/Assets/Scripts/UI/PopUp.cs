using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class PopUp : MonoBehaviour
{
    ////[SerializeField] private Canvas canvas;
    //[SerializeField] private GameObject panel;
    //private bool a = false;
    //public void CallPopUp()
    //{
    //    if (a == false)
    //    {
    //        a = true;
    //        //canvas.enabled = true;
    //        transform.position = new Vector3(0, 0, 0) * Time.deltaTime;
    //    }
    //    else if (a == true)
    //    {
    //        a = false;
    //        //canvas.enabled = false;
    //        panel.transform.Translate(0, -10, 0);
    //    }
    //}
    [SerializeField] private Transform[] _mass = new Transform[2];
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _panel;
    int i = 0;

    public void MovePopUp()
    {
        _panel.position = Vector3.MoveTowards(_panel.position, _mass[i].position, _speed);
        i++;
        if (i == 2)
        {
            i = 0;
        }
    }
}
