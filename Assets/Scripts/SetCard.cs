using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Set Card", menuName = "Cards/Set", order = 1)]
public class SetCard : CardScriptable
{
    [SerializeField]
    private Sprite _setIllustration = null;

    public Sprite setIllustration
    {
        get { return _setIllustration; }
    }
}
