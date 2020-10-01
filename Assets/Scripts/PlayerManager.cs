using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance = null;

    public List<SetCard> setCards = new List<SetCard>();
    public List<CharacterCard> characterCards = new List<CharacterCard>();
    public List<PlotCard> plotCards = new List<PlotCard>();

    public float totalMoney = 0f;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
        DontDestroyOnLoad(this.gameObject);
        AddStarterCards();
    }

    void Update()
    {

    }

    public List<PlotCard> playerPlots
    {
        get { return plotCards; }   
    }

    void AddStarterCards()
    {
        SetCard[] starterSets = Resources.LoadAll<SetCard>("Assets / Prefabs / Cards / Sets / Starter");
        PlotCard[] starterPlot = Resources.LoadAll<PlotCard>("Assets / Prefabs / Cards / Plot / Starter");
        CharacterCard[] starterChar = Resources.LoadAll<CharacterCard>("Assets / Prefabs / Cards / Character / Starter");

        for (int i = 0; i < starterSets.Length; i++)
        {
            setCards.Add(starterSets[i]);
        }
        for (int i = 0; i < starterPlot.Length; i++)
        {
            plotCards.Add(starterPlot[i]);
        }
        for (int i = 0; i < starterChar.Length; i++)
        {
            characterCards.Add(starterChar[i]);
        }


    }
}
