using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningState : State
{
    public MiningState(MinerManager minerManager) : base(minerManager)
    {

    }

    public override IEnumerator Start()
    {

        MinerManager.miner.Mine(MinerManager.currentMine);
        
        Debug.Log("MiningState::Start(). Start mining");
       
        return base.Start();
    }

    public override IEnumerator Update()
    {
        if (!MinerManager.miner.HasCapacity())
        {
            MinerManager.SetState(new CarringGoldState(MinerManager));
        }
        else 
        {
            MinerManager.miner.Mine(MinerManager.currentMine);
        }

        return base.Update();
    }

}
