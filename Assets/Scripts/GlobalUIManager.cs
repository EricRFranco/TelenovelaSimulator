using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalUIManager : MonoBehaviour
{
    public static GlobalUIManager instance = null;
    [Header("Card Panel Elements")]
    public GameObject cardPanel;
    public Text titleText;
    public Text subtitleText;
    public Text flavorText;
    public Text priceText;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
            instance = this;
        else
            Destroy(this);
        //DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopulateCardPanel(CardScriptable card)
    {
        titleText.text = card.title;
        subtitleText.text = card.subtitle;
        flavorText.text = card.flavorText;
        priceText.text = "$" + card.cardPrice.ToString() + ".00";
        cardPanel.SetActive(true);
    }

    public void DisableCardPanel()
    {
        cardPanel.SetActive(false);
    }
}
