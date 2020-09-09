using System.Collections;
using UnityEngine;

public class MovingTMState : State
{
    public MovingTMState(MinerManager minerManager) : base(minerManager)
    {
        
    }

    public override IEnumerator Start()
    {
        MoveTM(MinerManager.miner , MinerManager.currentMine);

        return base.Start();
    }

    public void MoveTM(Miner miner, Mine currentMine)
    {
       // miner.transform.position = Vector3.Lerp(currentMine.transform.position,miner.transform.position,miner.speed * Time.deltaTime);
        miner.SetDestination(currentMine.transform.position);
         Debug.Log("MovingTMState::MoveTM. Moving To Mine");
         //MinerManager.SetState(new DepositingGoldState(MinerManager));      
    }
}
