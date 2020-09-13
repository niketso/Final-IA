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
        //Debug.Log("MovingTMState::MoveTM. Moving To Mine");            
        miner.SetDestination(currentMine.transform.position);
    }
}
