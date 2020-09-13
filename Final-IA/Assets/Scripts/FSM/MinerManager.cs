using System.Collections;
using UnityEngine;

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

    private void Update()
    {
        UpdateState();
      
    }
    public void GetCurrentMine()
    {
        for (int i = 0; i < mines.Length; i++)
        {
            if (mines[i].IsActive())
            {
                currentMine = mines[i];
            }            
        }
    }
}
