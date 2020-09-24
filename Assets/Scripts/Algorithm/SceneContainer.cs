using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneContainer : MonoBehaviour
{
    // No need for these to be public. This is only for testing.
    public SetCard chosenSet;
    public PlotCard chosenPlot;
    public CharacterCard[] chosenChars;
    public DataStorage dataContainer;

    public float calculateTotal()
    {
        float total = 1;
        for (int i = 0; i < chosenChars.Length; i++)
        {
            if (ComparePlot(i)) { total = total * dataContainer.goodBonus; }
            else { total = total * dataContainer.neutralBonus; }
        }
        for (int i = 0; i < chosenChars.Length; i++)
        {
            if (CompareSet(i)) { total = total + dataContainer.setBonus; }
        }
        if (chosenSet.cardTypes == chosenPlot.cardTypes) { total = total + dataContainer.setBonus  ;  }
        return total;
    }
     bool ComparePlot(int c) 
    {
        if (chosenChars[c].cardTypes == chosenPlot.cardTypes)
        {
            return true;
        }
        else return false;
    }
     bool CompareSet (int c)
    {
        if (chosenChars[c].cardTypes == chosenSet.cardTypes)
        {
            return true;
        }
        else return false;
    }
    
}
