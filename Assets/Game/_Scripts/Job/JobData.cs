using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "New Job", menuName = "Custom/JobData")]
public class JobData : ScriptableObject
{
    public string jobName;
    public List<Ability> abilities;
    public LevelSystem levelSystem;

    public Job Create()
    {
        return new Job(this);
    }
}
