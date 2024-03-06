using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Job
{
    public JobData data;

    public Job(JobData data)
    {
        this.data = data;
    }
}
