using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private GameObject _button;
    [SerializeField] private Color _color;

    public void OnButtonClick()
    {
        _button.GetComponent<Image>().color = _color;
    }
}
