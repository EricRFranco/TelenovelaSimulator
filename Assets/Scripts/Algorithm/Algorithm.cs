using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algorithm : MonoBehaviour
{
    // This script only needs to be present and active on ScreenWriting phase, and its values are shown only in the aftermath phase. It's irrelevant in other phases.
    // It must contain the Scenes of the current phase (so it can call the calculateTotal method for each scene)
    // We need to define where we'll store the player's money and audience.
    public  SceneContainer[] currentScenes;
    public DataStorage dataC; // Short for dataContainer.
    int TotalAudience;
    public float multiplier;

    public int getTotalAudience() 
    {
        multiplier = dataC.episodeBonus[dataC.currentEpisode]; // The base value of the multiplier depends on the current level.
        TotalAudience = dataC.baseAudience;
        for (int k = 0; k < currentScenes.Length; k++) 
        {
            multiplier = multiplier + currentScenes[k].calculateTotal();
        }
        TotalAudience = TotalAudience * (int)multiplier;
        return TotalAudience;
    }
    // The following two functions should only be called after getTotalAudience has been executed at least once. (I can refactor this  if it becomes a problem).
    public double getRating() 
    {
        double rating;            //Maybe this can be an integer for simplicity? if it stays as a double we should only display the first decimal I believe (0.0 format)
        rating = multiplier / dataC.audienceToRating;
        return rating;

    }
    public int getIncome() // I'll set an extremely placeholder formula here so we can get an idea of the numbers. I'll adapt it once we get the final prices for the items.
    {
        int income;
        income = (int)(TotalAudience * dataC.audienceToIncome);
        return income;
    }
}
