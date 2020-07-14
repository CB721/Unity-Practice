using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank
{
    public string branchName;
    public string location;
    public string cashInVault;
    public void CheckBalance()
    {
        Debug.Log($"Checking balance at {branchName} bank");
    }
    public void Withdraw()
    {
        Debug.Log($"Withdrawing money from {branchName} bank");
    }
    public void Deposit()
    {
        Debug.Log($"Depositing money to {branchName} bank");
    }
}
