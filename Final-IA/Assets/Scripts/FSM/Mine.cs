using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] private int capacity = 0;
    [SerializeField] public MinerManager minerManager;
   
    private void Update()
    {
        if (!IsActive())
        {
            DeactivateMine();
        }
    }

    public bool IsActive()
    {
        if (capacity > 0 && gameObject.activeInHierarchy == true)
        {
            //Debug.Log("Mine::IsActive(); true");
            return true;
        }
        else
        {
           // Debug.Log("Mine::IsActive(); false");
            return false;
        }
    }

    public void DeactivateMine()
    {
        gameObject.SetActive(false);
    }

    public bool ExtractGold(int quantity)
    {
        if (IsActive())
        {
            capacity -= quantity;
            return true;
        }
        else
        {            
            return false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            Debug.Log("Mine::OTE. Arrived to Mine");
            minerManager.SetState(new MiningState(minerManager));
        }
    }
}
