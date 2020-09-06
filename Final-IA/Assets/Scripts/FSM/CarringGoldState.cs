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
        if (miner && deposit)
        {
            miner.transform.position = Vector3.Lerp(miner.transform.position, deposit.transform.position, miner.speed * Time.deltaTime);
            Debug.Log("CarringGoldState::MoveTD. Moving To Deposit");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Miner"))
        {
            MinerManager.SetState(new DepositingGoldState(MinerManager));
            Debug.Log("CarringGoldState::OTE. Arrived to deposit");
        }
    }
}
