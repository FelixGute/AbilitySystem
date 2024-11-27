using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AbilitySelectionScreen : MonoBehaviour
{
    [SerializeField] private AbilityManager abilityManager;
    [SerializeField] private UIDocument UIDocument;
    private VisualElement root;
    
    private int playerLevel = 0; // only temporary for testing

    private void OnEnable()
    {
        root = UIDocument.rootVisualElement;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ShowScreen();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            playerLevel++;
            abilityManager.OnPlayerLevelUp(playerLevel);
        }
    }

    private void ShowScreen()
    {
        root.Clear();

        List<AbilityBehaviour> availableAbilities = abilityManager.GetAvailableAbilities(); // Can also use GetActive or GetPassive
        foreach (AbilityBehaviour availableAbility in availableAbilities)
        {
            ShowCard(availableAbility);
        }
    }

    private void ShowCard(AbilityBehaviour ability)
    {
        VisualElement card = new VisualElement();
        
        
        card.Add(CreateLabel(ability.AbilityName));
        root.Add(card);
        
        // Todo: Add in code that allows selecting ability
        // Button needs to link to code that links KeyPress with ActiveAbility
    }

    private Label CreateLabel(string text)
    {
        Label newLabel = new Label();
        newLabel.text = text;
        return newLabel;
    }
}
