using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Runtime.Versioning;
using UnityEngine;
using UnityEngine.SceneManagement;
=======
using UnityEngine;
>>>>>>> ShopUI

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance = null;

<<<<<<< HEAD

    public static List<SetCard> setCards = new List<SetCard>();
    public static List<CharacterCard> characterCards = new List<CharacterCard>();
    public static List<PlotCard> plotCards = new List<PlotCard>();

    public static float totalMoney = 0f;

=======
    public List<SetCard> setCards = new List<SetCard>();
    public List<CharacterCard> characterCards = new List<CharacterCard>();
    public List<PlotCard> plotCards = new List<PlotCard>();

    public float totalMoney = 0f;
    // Start is called before the first frame update
>>>>>>> ShopUI
    void Start()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
        DontDestroyOnLoad(this.gameObject);
        AddStarterCards();
    }
<<<<<<< HEAD
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //Is this redundant since we have the DontDestroy in the void start?
    }

    void Update()
    {

    }
    public List<PlotCard> playerPlots()
    {
        return plotCards;   
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
=======

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddStarterCards()
    {

>>>>>>> ShopUI
    }
}
