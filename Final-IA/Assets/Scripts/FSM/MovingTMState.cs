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
        // miner.GetComponent<NavMeshAgent>().destination = mine;

        if (miner && currentMine)
        {
            //miner.transform.position = Vector3.Lerp(currentMine.transform.position,miner.transform.position,miner.speed * Time.deltaTime);
            Debug.Log("MovingTMState::MoveTM. Moving To Mine");
            //MinerManager.SetState(new DepositingGoldState(MinerManager));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Miner"))
        {
            Debug.Log("MovingTMState::OTE. Arrived to Mine");
            MinerManager.SetState(new MiningState(MinerManager));   
        }
    }

}
