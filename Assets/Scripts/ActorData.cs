using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorData : MonoBehaviour
{
    public static ActorData actor;

    public CharacterCard actorSO;
    public bool bought;
    public int morale;
    public Dictionary<string, int> actorChemistries;
    public string ActorName;
    public List<string> traits;

    void Awake()
    {
        if (actor == null)
        {
            DontDestroyOnLoad(gameObject);
            actor = this;
        }
        else if (actor != this) 
        {
            Destroy(gameObject);
        }
        morale = actorSO.morale;
        actorChemistries = actorSO.actorChemistries;
        ActorName = actorSO.actorName;
        traits = actorSO.traits;
        bought = false;
    }

}
