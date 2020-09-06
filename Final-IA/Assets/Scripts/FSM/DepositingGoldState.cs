using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositingGoldState : State
{
    public DepositingGoldState(MinerManager minerManager) : base(minerManager)
    {

    }

    public override IEnumerator Start()
    {
       /* while (MinerManager.miner.DepositGold(MinerManager.deposit))
        {
        }*/
            Debug.Log("DeposittingGoldState::Start. Depositing");
        MinerManager.SetState(new IdleState(MinerManager));
       
        return base.Start();
    }
    
    
}
