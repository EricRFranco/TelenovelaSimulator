using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStorage : MonoBehaviour
{
    public static CardStorage instance = null;

    public List<SetCard> allSets = new List<SetCard>();
    public List<PlotCard> allPlots = new List<PlotCard>();
    public List<CharacterCard> allCharacters = new List<CharacterCard>();

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
