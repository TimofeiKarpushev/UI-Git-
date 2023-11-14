using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destroer : MonoBehaviour
{
    [SerializeField] private GameObject[] _buttons;

    private int _buttonIndex = 3;

    public void DestroyAllButtons()
    {
        for(int i = 0; i < _buttonIndex; i++)
        {
            Destroy(_buttons[i]);
        }
    }
}
