using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using UnityEngine;

public class deckManager : MonoBehaviour
{
    public PlayerManager player;
    public PlotCard[] deck;
    public int playerHand = 5; // We can dinamically change this in runtime, but for the demo it's fine to just set it at 5 manually.
    void Start()
    {
        LoadAllPlots();
        if (player.playerPlots.Count < playerHand + 1)
        {
            int boughtCards = player.playerPlots.Count;
            GenerateRandomCards(boughtCards);
        }
    }

    void LoadAllPlots()
    {
        PlotCard[] notStarterDeck;
        notStarterDeck = Resources.LoadAll<PlotCard>("Assets/Prefabs/Cards/Plots");
        int totalNotStarterCards = notStarterDeck.Length;
        PlotCard[] starterDeck;
        starterDeck = Resources.LoadAll<PlotCard>("Assets / Prefabs / Cards / Plots / Starter");
        int totalStarterCards = starterDeck.Length;
        for (int i = totalNotStarterCards; i < totalNotStarterCards + totalStarterCards; i++)
        {
            notStarterDeck[i] = starterDeck[i - totalNotStarterCards];
        }
        deck = notStarterDeck;
    }

    public void GenerateRandomCards(int x)
    {
        PlotCard[] newHand = new PlotCard[playerHand];
        for (int y = x; y <= x; y++) 
        {
            newHand[y - x] = player.playerPlots[y - x];
        }
        for (int t = x; t <= playerHand; t++) 
        {
            
        }
    }
    
}
