using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    public IdleState(MinerManager minerManager) : base(minerManager)
    {
        
    }

    public override IEnumerator Start()
    {
        MinerManager.GetCurrentMine();

        if (MinerManager.miner.CanMine(MinerManager.currentMine))
        {
            Debug.Log("IdleState::Start(); Able to mine");
            MinerManager.SetState(new MovingTMState(MinerManager));
        }
        else
        {
            Debug.Log("IdleState::Start(); Unable to Mine");
        }

        /*if (MinerManager.mines.Length == 0)
        {
            Debug.Log("IdleState::Update(); No Mines Left, just rest");
        }*/

        return base.Start();
    }
}
