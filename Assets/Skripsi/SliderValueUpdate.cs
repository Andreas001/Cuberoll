using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueUpdate : MonoBehaviour
{
    public Text value;

    public void OnValueChanged(float newValue)
    {
         value.text = newValue.ToString();
    }
}
