using UnityEngine;

public class Miner : MonoBehaviour
{
    //How much it can carry.
    [SerializeField] private int capacity = 0;
    //How many per action it can mine.
    [SerializeField] private int efficiency = 0;
    [SerializeField] public float speed;
    public int currentGold;

    private void Start()
    {
        currentGold = 0;
    }

    public bool CanMine(Mine currentMine)
    {
        
        if (currentMine)
        {
            Debug.Log("Miner::CanMine(); true");
            return true;
        }

        Debug.Log("Miner::CanMine(); false");
        return false;
        
    }
    public bool Mine(Mine currentMine)
    {
        if (capacity < currentGold)
        {
            currentMine.ExtractGold(efficiency);
            currentGold = efficiency;
            return true;
        }
        else
        {
            Debug.Log("Miner::Mine().Already full.");
            return false;
        }
    }

    public bool DepositGold(Deposit deposit)
    {
        if (deposit)
        {
            if (deposit.DepositGold(this))
            {
                Debug.Log("Miner::Deposit. Depositing");
                return true;
            }
            else
            {
                Debug.Log("Miner::Deposit. Couldn't deposit.");
                return false;
            }

        }
        else
        {
            return false;
        }
        
    }

    

}
