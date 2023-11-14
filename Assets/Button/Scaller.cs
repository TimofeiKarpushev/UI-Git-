using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Scaller : MonoBehaviour
{
    [SerializeField] private GameObject _button;

    private float _xVector = 5.5f;
    private float _yVector = 5.5f;
    private float _zVector = 5.5f;
    private float _speed = 1;

    private void Start()
    {
        _button.transform.DOScale(new Vector3(_xVector, _yVector, _zVector), _speed).SetLoops(-1, LoopType.Yoyo);
    }

    public void StopAnimateButton()
    {
        DOTween.Kill(_button.transform);
    }
}
