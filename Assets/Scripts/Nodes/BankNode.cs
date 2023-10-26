using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankNode : INode
{
    int MaxMoney;
    public int Money = 100;

    

    public override void Interface()
    {
        Debug.Log("Bank Node");
        
        if(Money - 30 > 0)
        {
            Money -= 30;
            GameManager.instance.Money += 30;
        }else
        {
            GameManager.instance.Money += Money;
           Money = 0;
        }

       

    }

    public override void Update2()
    {
        Description = $"{Desc} Money in Bank {Money}/{MaxMoney}";
    }

    public override void Start2()
    {
        MaxMoney = Money;
    }
}
