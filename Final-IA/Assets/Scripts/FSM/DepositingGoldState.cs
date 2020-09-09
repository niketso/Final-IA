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
        Debug.Log("DeposittingGoldState::Start. Depositing");

        if (MinerManager.miner.DepositGold(MinerManager.deposit))
           {
            
            MinerManager.SetState(new IdleState(MinerManager));
           } 
        
        return base.Start();
    }

    public override IEnumerator Update()
    {
        MinerManager.GetCurrentMine();

        return base.Update();
    }


}
