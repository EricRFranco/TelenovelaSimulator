using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScriptable : ScriptableObject
{
    [SerializeField]
    private string _title = "";
    [SerializeField]
    private string _subtitle = "";
    [SerializeField]
    [TextArea]
    private string _flavorText = "";
    [SerializeField]
    private CardType[] _cardTypes = null;
    [SerializeField]
    private int _cardPrice = 0;
    
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

    public CardType[] cardTypes
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
    Expository,
    None
}
