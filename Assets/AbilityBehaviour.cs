using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class AbilityBehaviour : MonoBehaviour
{
    [SerializeField] private int _requiredPlayerLevel;
    private int _abilityLevel;
    private int _experienceNeededToLevelUp;
    private int _abilityExperience;

    [SerializeField] private string _abilityName;

    public string AbilityName
    {
        get { return _abilityName; }
        set { _abilityName = value; }
    }

    [SerializeField] private string _description;
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    void Start()
    {
        _abilityLevel = 0;
        _abilityExperience = 0;
        _experienceNeededToLevelUp = 10; // change to real number
    }

    public int GetRequiredPlayerLevel()
    {
        return _requiredPlayerLevel;
    }

    public void GainExperience()
    {
        _abilityExperience++;
        if (_abilityExperience >= _experienceNeededToLevelUp)
        {
            LevelUp();
        }
    }

    void LevelUp()
    {
        _abilityLevel++;
        // increase _experienceNeededToLevelUp
    }

    public void ActivateAbility()
    {
        // Passive: Run code that adds effects
        OnActivateAbility();
    }


    public void DeactivateAbility()
    {
        // Passive: run code that removes effects
        OnDeactivateAbility();
    }

    
    public void UseAbility()
    {
        // used for active abilities
        OnUseAbility();
        //GainExperience();
    }

    protected virtual void OnActivateAbility() {}
    protected virtual void OnDeactivateAbility() {}
    protected virtual void OnUseAbility() {}
}
