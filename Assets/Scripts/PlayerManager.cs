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

    public ScriptWritingUI scriptUIManager;

    public float totalMoney = 0f;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
        DontDestroyOnLoad(this.gameObject);
        AddStarterCards();
        scriptUIManager.LoadUI();
    }

    public List<PlotCard> playerPlots
    {
        get { return plotCards; }   
    }
    public List<SetCard> playerSets
    {
        get { return setCards; }
    }
    public List<CharacterCard> playerChars
    {
        get { return characterCards; }
    }
    public void AddStarterCards()
    {
        List<SetCard> starterSets = CardStorage.instance.starterSets;
        List<PlotCard> starterPlot = CardStorage.instance.starterPlots; ;
        List<CharacterCard> starterChar = CardStorage.instance.starterCharacters;

        for (int i = 0; i < starterSets.Count; i++)
        {
            setCards.Add(starterSets[i]);
        }
        for (int i = 0; i < starterPlot.Count; i++)
        {
            plotCards.Add(starterPlot[i]);
        }
        for (int i = 0; i < starterChar.Count; i++)
        {
            characterCards.Add(starterChar[i]);
        }


    }
}
