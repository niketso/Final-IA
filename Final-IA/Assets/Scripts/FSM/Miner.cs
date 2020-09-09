using UnityEngine;
using UnityEngine.AI;

public class Miner : MonoBehaviour
{
    //How much it can carry.
    [SerializeField] private int capacity = 0;
    //How many per action it can mine.
    [SerializeField] private int efficiency = 0;
    public int currentGold = 0;

    public bool CanMine(Mine currentMine)
    {
        
        if (currentMine)
        {
            //Debug.Log("Miner::CanMine(); true");
            return true;
        }

       // Debug.Log("Miner::CanMine(); false");
        return false;
        
    }

    public void Mine(Mine currentMine)
    {
        if (HasCapacity() || currentMine.IsActive())
        {
            if (currentMine.ExtractGold(efficiency))
            {
                currentGold += efficiency;                           
            } 
        }                
    }

    public bool HasCapacity()
    {
        if (capacity > currentGold)
        {
            Debug.Log("Miner::HasCapacity().Can carry.");
            return true;
        }
        else
        {
            Debug.Log("Miner::HasCapacity().Already full.");
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

    public void SetDestination(Vector3 destination)
    {
        gameObject.GetComponent<NavMeshAgent>().SetDestination(destination);
    }

    

}
