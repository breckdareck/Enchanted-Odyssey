using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LevelSystem
{
    public LevelData data;

    public LevelSystem(LevelData data)
    {
        this.data = data;
    }
}
