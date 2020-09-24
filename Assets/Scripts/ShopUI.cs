using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _mainMenu = null;
    [SerializeField]
    private GameObject _setPanel = null;
    [SerializeField]
    private GameObject _characterPanel = null;
    [SerializeField]
    private GameObject _plotPanel = null;
    [SerializeField]
    private GameObject _backButton = null;

    // Lets assume that the characters, sets, and plots to spawn are stored in respective lists. 
    // Variables just for testing:  
    public SetCard[] RandomizedSetCards;
    public CharacterCard[] RandomizedCharacterCards;
    public PlotCard[] RandomizedPlotCards;
    public GameObject cardUIPrefab;
    public GameObject[] panels;
    public float initialXPos;
    public float initialYPos;
    public float xOffset;
    public float yOffset;
    void Start()
    {
        createCards(0, RandomizedSetCards);
        createCards(1, RandomizedCharacterCards);
        createCards(2, RandomizedPlotCards);
    }

    void createCards(int c, CardScriptable[] toSpawn) 
    {
        float xPos = initialXPos;
        float yPos = initialYPos;
        for (int i = 0; i < 6; i++)
        {
            GameObject newCard = Instantiate(cardUIPrefab, panels[c].transform);
            if (i == 3) {
                yPos = yPos + yOffset;
                xPos = initialXPos;
            }
            newCard.transform.localPosition = new Vector2(xPos, yPos);
            xPos = xPos + xOffset;
            GameObject cardTitle = newCard.transform.GetChild(0).gameObject;
            cardTitle.GetComponent<Text>().text = toSpawn[i].title;
            GameObject cardSubtitle = newCard.transform.GetChild(1).gameObject;
            cardSubtitle.GetComponent<Text>().text = toSpawn[i].subtitle;
            GameObject cardFlavor = newCard.transform.GetChild(2).gameObject;
            cardSubtitle.GetComponent<Text>().text = toSpawn[i].flavorText;
            /*if (toSpawn[i].GetType() == RandomizedCharacterCards.GetType() || toSpawn[i].GetType() == RandomizedSetCards.GetType()) 
            {
                GameObject cardImage = newCard.transform.GetChild(3).gameObject;
                cardSubtitle.GetComponent<Image>().sprite = toSpawn[i].set;
            } CODE FOR GETTING THE IMAGE */


        }
     
    }
    
    void Update()
    {
        UpdateFundsText();
    }

    public void DisableMainMenu()
    {
        _mainMenu.SetActive(false);
        _backButton.SetActive(true);
    }

    public void EnableMainMenu()
    {
        _mainMenu.SetActive(true);
        _backButton.SetActive(false);
    }

    public void OpenSetPanel()
    {
        _setPanel.SetActive(true);
        _backButton.SetActive(true);
        _mainMenu.SetActive(false);
    }

    public void OpenCharacterPanel()
    {
        _characterPanel.SetActive(true);
        _backButton.SetActive(true);
        _mainMenu.SetActive(false);
    } 

    public void OpenPlotPanel()
    {
        _plotPanel.SetActive(true);
        _backButton.SetActive(true);
        _mainMenu.SetActive(false);
    }

    public void BackToMainMenu()
    {
        if (_plotPanel.activeInHierarchy)
            _plotPanel.SetActive(false);
        else if (_characterPanel.activeInHierarchy)
            _characterPanel.SetActive(false);
        else if (_setPanel.activeInHierarchy)
            _setPanel.SetActive(false);
        EnableMainMenu();
    }

    void UpdateFundsText()
    {

    }

}
