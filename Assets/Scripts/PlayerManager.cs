using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance = null;

    public List<SetCard> setCards = new List<SetCard>();
    public List<CharacterCard> characterCards = new List<CharacterCard>();
    public List<PlotCard> plotCards = new List<PlotCard>();

    public float totalMoney = 0f;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
        DontDestroyOnLoad(this.gameObject);
        AddStarterCards();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddStarterCards()
    {

    }
}
