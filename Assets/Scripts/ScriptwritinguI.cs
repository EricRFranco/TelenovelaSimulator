using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ScriptWritingUI : MonoBehaviour
{
    public GameObject cardPrefab;
    public deckManager plotDeck;
    public PlayerManager player;
    public GameObject PlotButton;
    public GameObject SetButton;
    public GameObject CharacterButton;
    public float yOffset;

    private bool plotActive;
    private bool setActive;
    private bool charActive;
    public void LoadUI()
    {
        int plotCardLength = player.playerPlots.Count;
        int setCardLength = player.playerSets.Count;
        int charCardLength = player.playerChars.Count;
        for (int i = 0; i < plotCardLength; i++)
        {
            GameObject newButton = Instantiate(cardPrefab, PlotButton.transform);
            newButton.GetComponentInChildren<Text>().text = player.playerPlots[i].title;
            Vector2 newPos = newButton.transform.position;
            newPos.y = newPos.y - i * yOffset;
            newButton.transform.position = newPos;
            newButton.GetComponent<SingleCardDataContainer>().thisPlotCard = player.playerPlots[i];
            newButton.gameObject.SetActive(false);
        }
        for (int i = 0; i < setCardLength; i++)
        {
            GameObject newButton = Instantiate(cardPrefab, SetButton.transform);
            newButton.GetComponentInChildren<Text>().text = player.playerSets[i].title;
            Vector2 newPos = newButton.transform.position;
            newPos.y = newPos.y - i * yOffset;
            newButton.transform.position = newPos;
            newButton.GetComponent<SingleCardDataContainer>().thisSetCard = player.playerSets[i];
            newButton.gameObject.SetActive(false);
        }
        for (int i = 0; i < charCardLength ; i++)
        {
            GameObject newButton = Instantiate(cardPrefab, CharacterButton.transform);
            newButton.GetComponentInChildren<Text>().text = player.playerChars[i].title;
            Vector2 newPos = newButton.transform.position;
            newPos.y = newPos.y - i * yOffset;
            newButton.transform.position = newPos;
            newButton.GetComponent<SingleCardDataContainer>().thisCharCard = player.playerChars[i];
            newButton.gameObject.SetActive(false);
        }
        plotActive = false;
        setActive = false;
        charActive = false;
    }
    public void ClickPlot() 
    {
        if (setActive) { ClickSet(); }
        if (charActive) { ClickChar() ; }

        Transform[] plotChildren = new Transform[PlotButton.transform.childCount - 1];
        for (int i = 1; i < PlotButton.transform.childCount; i++)
        {
            plotChildren[i - 1]  = PlotButton.transform.GetChild(i);
        }
        if (!plotActive)
        {
            
            foreach (Transform child in plotChildren)
            {
                child.gameObject.SetActive(true);
            }
            Vector2 newSetPos = new Vector2(SetButton.transform.position.x, plotChildren[plotChildren.Length - 1].transform.position.y);
            newSetPos.y = newSetPos.y - yOffset;
            SetButton.transform.position = newSetPos;
            Vector2 newCharPos = new Vector2(SetButton.transform.position.x, SetButton.transform.position.y);
            newCharPos.y = newCharPos.y - yOffset;
            CharacterButton.transform.position = newCharPos;

            plotActive = true;
        }
        else if (plotActive) 
        {
            foreach (Transform child in plotChildren)
            {
                child.gameObject.SetActive(false);
            }
            
            Vector2 newSetPos = new Vector2(PlotButton.transform.position.x, PlotButton.transform.position.y);
            newSetPos.y = newSetPos.y - yOffset;
            SetButton.transform.position = newSetPos;
            Vector2 newCharPos = new Vector2(SetButton.transform.position.x, SetButton.transform.position.y);
            newCharPos.y = newCharPos.y - yOffset;
            CharacterButton.transform.position = newCharPos;

            plotActive = false;
            
        }
    }

    public void ClickSet() 
    {
        if (plotActive) { ClickPlot(); }
        if (charActive) { ClickChar(); }
        Transform[] setChildren = new Transform[SetButton.transform.childCount - 1];
        for (int i = 1; i < SetButton.transform.childCount; i++)
        {
            setChildren[i - 1] = SetButton.transform.GetChild(i); 
        }
        if (!setActive)
        {
            foreach (Transform child in setChildren)
            {
                child.gameObject.SetActive(true);
            }
            Vector2 newCharPos = new Vector2(CharacterButton.transform.position.x, setChildren[setChildren.Length - 1].transform.position.y);
            newCharPos.y = newCharPos.y - yOffset;
            CharacterButton.transform.position = newCharPos;
            setActive = true;
        }
        else if (setActive)
        {
            foreach (Transform child in setChildren)
            {
                child.gameObject.SetActive(false);
            }

            Vector2 newSetPos = new Vector2(PlotButton.transform.position.x, PlotButton.transform.position.y);
            newSetPos.y = newSetPos.y - yOffset;
            SetButton.transform.position = newSetPos;
            Vector2 newCharPos = new Vector2(SetButton.transform.position.x, SetButton.transform.position.y);
            newCharPos.y = newCharPos.y - yOffset;
            CharacterButton.transform.position = newCharPos;

            setActive = false;
        }
    }
    public void ClickChar()
    {
        if (plotActive) { ClickPlot(); }
        if (setActive) { ClickSet(); }
        Transform[] charChildren = new Transform[CharacterButton.transform.childCount - 1];
        for (int i = 1; i < CharacterButton.transform.childCount; i++)
        {
            charChildren[i - 1] = CharacterButton.transform.GetChild(i);
        }
        if (!charActive)
        {
            foreach (Transform child in charChildren)
            {
                child.gameObject.SetActive(true);
            }
            charActive = true;
        }
        else if (charActive)
        {
            foreach (Transform child in charChildren)
            {
                child.gameObject.SetActive(false);
            }

            charActive = false;
        }
    }
}
