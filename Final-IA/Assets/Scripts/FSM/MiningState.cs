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
        Debug.Log("MiningState::Start(). Start mining");

       /* while (MinerManager.miner.Mine(MinerManager.currentMine))
        {
        }*/

            Debug.Log("MiningState::Start(). Mining");


        MinerManager.SetState(new CarringGoldState(MinerManager));
        return base.Start();
    }
   

}
