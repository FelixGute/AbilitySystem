using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : PassiveAbility
{
    protected override void OnActivateAbility()
    {
        Debug.Log("Shield activated");
    }

    protected override void OnDeactivateAbility()
    {
        Debug.Log("Shield deactivated");
    }
}
