using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStorage : MonoBehaviour
{
    public static CardStorage instance = null;

    public List<SetCard> allSets = new List<SetCard>();
    public List<PlotCard> allPlots = new List<PlotCard>();
    public List<CharacterCard> allCharacters = new List<CharacterCard>();

    public List<SetCard> starterSets = new List<SetCard>();
    public List<PlotCard> starterPlots = new List<PlotCard>();
    public List<CharacterCard> starterCharacters = new List<CharacterCard>();
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
}
