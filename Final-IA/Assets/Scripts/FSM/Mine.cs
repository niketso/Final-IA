using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] private int capacity = 0;

    private void Awake()
    {
        IsActive();
        Debug.Log("Mine::Awake().Activating Mine, current state: " + IsActive());
    }
    private void Update()
    {
        /*if (!IsActive())
        {
            DeactivateMine();
        }*/
    }

    public bool IsActive()
    {
        if (capacity > 0 && gameObject.activeInHierarchy == true)
        {
            Debug.Log("Mine::IsActive(); Mine is not empty");
            return true;
        }
        else
        {
            Debug.Log("Mine::IsActive(); Mine is empty");
            return false;
        }
    }

    public void DeactivateMine()
    {
        gameObject.SetActive(false);
    }

    public void ExtractGold(int quantity)
    {
        if (IsActive())
        {
            capacity -= quantity;
        }
    }
}
