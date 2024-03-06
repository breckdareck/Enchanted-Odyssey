using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ability", menuName = "Custom/AbilityData")]
public class AbilityData : ScriptableObject
{
    public string abilityName;
    public AnimationClip animationClip;
    public int animHash;
    public float duration;
    public Sprite icon;

    public Ability Create()
    {
        return new Ability(this);
    }
}
