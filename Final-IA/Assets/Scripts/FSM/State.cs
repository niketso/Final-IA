using System.Collections;
using UnityEngine;

public abstract class State 
{
    protected MinerManager MinerManager;

    public State(MinerManager minerManager)
    {
        MinerManager = minerManager;
    }

    public virtual IEnumerator Start()
    {
        yield break;
    }

}
