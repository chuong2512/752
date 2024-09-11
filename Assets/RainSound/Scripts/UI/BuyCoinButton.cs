using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BuyCoinButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private TextMeshProUGUI _text;

    [SerializeField] private int _index;

    public int Index
    {
        get => _index;
        set
        {
            _index = value;
            SetDataWithIndex();
        }
    }

    private int _coin;

    private void OnValidate()
    {
        _text = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Start()
    {
        _button?.onClick.AddListener(OnClickButton);
    }

    private void SetDataWithIndex()
    {
        switch (_index)
        {
            case 0:
                _coin = 10;
                break;
            case 1:
                _coin = 20;
                break;
            case 2:
                _coin = 30;
                break;
            case 3:
                _coin = 50;
                break;
            case 4:
                _coin = 100;
                break;
        }

        _text.SetText($" + {_coin} <sprite=0>");
    }

    private void OnClickButton()
    {
    }

    private void AddCoin()
    {
        GameDataManager.Instance.playerData.AddDiamond(_coin);
    }
}