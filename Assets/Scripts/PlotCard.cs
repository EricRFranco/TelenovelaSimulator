using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Plot Card", menuName = "Cards/Plot", order = 2)]
public class PlotCard : CardScriptable
{
    [SerializeField]
    private int _charactersRequired = 0;

    public int charactersRequired
    {
        get { return _charactersRequired; }
    }
}
