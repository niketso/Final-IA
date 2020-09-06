using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deposit : MonoBehaviour
{
    [SerializeField] private int maxCapacity = 0;
    private int currentGold = 0;

    public bool DepositGold(Miner miner)
    {
        if (currentGold < maxCapacity)
        {
            currentGold = miner.currentGold;
            miner.currentGold = 0;
            Debug.Log("Deposit::DepositGold. Gold deposited");
            return true;
        }
        else
        {
            Debug.Log("Deposit::DepositGold. Not enought capacity to store in the deposit");
            return false;
        }
    }
}
