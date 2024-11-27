using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : ActiveAbility
{
    protected override void OnActivateAbility()
    {
        Debug.Log("I didn't ask how small the room is, I said; I Cast Fireball.");
    }
}
