using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Generic Card", menuName = "Cards/Generic", order = 1)]
public class CardScriptable : ScriptableObject
{
    [SerializeField]
    private string _title;
    [SerializeField]
    private string _subtitle;
    [SerializeField]
    [TextArea]
    private string _flavorText;
    [SerializeField]
    private KeyValuePair<CardType, CardType> _cardTypes;
    [SerializeField]
    private int _cardPrice;
    
    public string title
    {
        get { return _title; }
    }

    public string subtitle
    {
        get { return _subtitle; }
    }

    public string flavorText
    {
        get { return _flavorText; }
    }

    public int cardPrice
    {
        get { return _cardPrice; }
    }

    public KeyValuePair<CardType, CardType> cardTypes
    {
        get { return _cardTypes; }
    }
}

public enum CardType
{
    Romantic,
    Confrontational,
    Violent,
    Chisme,
    None
}
