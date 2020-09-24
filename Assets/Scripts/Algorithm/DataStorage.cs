using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStorage : MonoBehaviour
{
    // I'd love to serialize all these fields so it isn't just hardcoded. From what I know it can't be done with static values tho. Any ideas?
     public int baseAudience;
     public float goodBonus = 1.5f;
     public float neutralBonus = 0.9f;
     public float setBonus = 1f;
     public int currentEpisode = 1; //I set it to 1 just to test. We haven't defined where we're gonna store the episode number just yet.
     public float audienceToIncome;
     public float audienceToRating;
     
     public float[] episodeBonus = { 3, 2.5f, 2.5f, 2, 1.7f, 1.5f, 1.2f, 0.9f };

   
}
