﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

[CreateAssetMenu(fileName = "Character Card", menuName = "Cards/Character", order = 3)]
public class CharacterCard : CardScriptable
{
    [SerializeField]
    private int _startingMorale; // Will go from 0 to 100. We can initialize this at whatever value we want.
    [SerializeField]
    private string _actorName;

    [SerializeField]
    private Dictionary<string, int> _startingActorChemistries = new Dictionary<string, int>(); // Will go from -50 to 50. We can initialize this at whatever value we want for each actor.
                                                                                   // The string is the name of the other actor and the integer is the value of their relationship.
    [SerializeField]
    public List<string> _traits; //Can be changed into a special type of datatype. Have to discuss: will these change dynamically at runtime?

    [SerializeField]
    public Sprite _actorSprite;

    public int morale
    {
        get { return _startingMorale; }
    }
    public string actorName
    {
        get { return _actorName; }
    }
    public Dictionary<string, int> actorChemistries
    {
        get { return _startingActorChemistries; }
    }
    public List<string> traits 
    {
        get { return _traits; }
    }
    public Sprite actorSprite
    {
        get { return _actorSprite; }
    }
}
