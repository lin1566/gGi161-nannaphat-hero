using UnityEngine;

public class Hero : Character
{
    private int gold;
    public int Gold 
    { 
        get { return gold; }
        set 
        {
            if (gold > 999) { gold = 999; }
            else if (value <= 0) { gold = 0; }
            else {gold = value; }

        }
    }
    public void EranGold(int amount)
    {
        if(amount > 0)
        { 
            gold += amount;
        }
    }

}
