using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotCard : MonoBehaviour
{
    [SerializeField]
    private int _charactersRequired;

    public int charactersRequired
    {
        get { return _charactersRequired; }
    }
}
