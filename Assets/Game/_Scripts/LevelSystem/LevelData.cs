using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Level Data", menuName = "Custom/LevelData")]
public class LevelData : ScriptableObject
{
    public int expToLevel = 100;
    public int currentExp = 0;
    public int currentLevel = 1;
    public int maxLevel = 100;
    
    public LevelSystem Create()
    {
        return new LevelSystem(this);
    }
}
