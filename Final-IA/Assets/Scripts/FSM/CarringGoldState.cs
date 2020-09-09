using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarringGoldState : State
{
    public CarringGoldState(MinerManager minerManager) : base(minerManager)
    {

    }
    public override IEnumerator Start()
    {
        MoveTD(MinerManager.miner, MinerManager.deposit);
        return base.Start();
    }

    public void MoveTD(Miner miner, Deposit deposit)
    {
        if (deposit)
        {
            Debug.Log("CarringGoldState::MoveTD. Moving To Deposit");
            //miner.transform.position = Vector3.Lerp(miner.transform.position, deposit.transform.position, miner.speed * Time.deltaTime);
            miner.SetDestination(deposit.transform.position);
          
        }
    } 
}
