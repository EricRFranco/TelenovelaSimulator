using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgorithmTesting : MonoBehaviour
{
    // This script should not be in the final build. It's just for testing.
    public Algorithm algorithm;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            print("Total Audience: " + algorithm.getTotalAudience());
            print("Rating: " + algorithm.getRating());
            print("Income: " + algorithm.getIncome());
        }
    }
}

