using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
