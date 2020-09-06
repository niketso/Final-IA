using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginState : State
{
    public BeginState(MinerManager minerManager) : base(minerManager)
    {

    }

    public override IEnumerator Start()
    {
       // MinerManager.SetState(new IdleState(MinerManager));
        return base.Start();
    }
}
