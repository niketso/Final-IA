using System.Collections;
using UnityEngine;

public enum MinerStates {Idle, MovingTM, Mining, CarringGold, DepositingGold}

public class MinerManager : StateMachine
{
    [SerializeField] public Miner miner;
    [SerializeField] public Deposit deposit;
    [SerializeField] public Mine[] mines;
    public Mine currentMine;

    private void Start()
    {
        SetState(new IdleState(this));
    }

    public void GetCurrentMine()
    {
        for (int i = 0; i < mines.Length; i++)
        {
            if (mines[i].IsActive())
            {
                currentMine = mines[i];
            }
            else
            {
                mines[i].DeactivateMine();
                Debug.Log("MinerManager::GetCurrentMine; Deactivating Mine");
            }
        }
    }

}
