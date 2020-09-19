using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneContainer : MonoBehaviour
{
    SetCard chosenSet;
    PlotCard chosenPlot;
    CharacterCard[] chosenChars;
    float sceneTotal;

    void calculateTotal() 
    {
        CardType[] setTypes = chosenSet.cardTypes;
        CardType[] character1Type = chosenChars[0].cardTypes;
        if (chosenPlot.charactersRequired > 1) { CardType[] character2Type = chosenChars[1].cardTypes; }
        if (chosenPlot.charactersRequired > 2) { CardType[] character2Type = chosenChars[2].cardTypes; }

    }
    
}
