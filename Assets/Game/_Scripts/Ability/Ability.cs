using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Ability
{
    public AbilityData data;

    public Ability(AbilityData data)
    {
        this.data = data;
    }
}
