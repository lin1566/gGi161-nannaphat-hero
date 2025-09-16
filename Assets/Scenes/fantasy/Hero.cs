
using UnityEngine;
 public class Hero
{
    //Attributes
    private string name;
    public string Name 
    { 
        get { return name; }
        set { if (string.IsNullOrEmpty(value)) { name = "Unknow hero"; }
              else { name = value; }
        }
    }

    
    
    private int health;
    public int Health
    {
        get { return health; }
        set { if (value >= 0)health = value;
            else health = 0;  
        }
    }
    
    
    private int gold;
    public int Gold
    {
        get { return gold; }
        set { 
              if (value > 999) { gold = 999; }
              else if (value <= 0) { gold = 0; }
              else { gold = value; }
            }
    }

    private int attackPower;
    public int AttackPower
    {
        get; private set;
    }


    //create an object
    public Hero(string newName, int newHp, int newAttackPower)
    {
        Name = newName;
        Health = newHp;
        Gold = 0;
        AttackPower = newAttackPower;
    }
    public void ShowStute()
    {
        Debug.Log($"Hero name : {Name} | Hero health : {Health} | Gold : {Gold}");
    }


    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
    }

    public void Attack(monsters target)
    {
        Debug.Log($"{Name} attack {target.Name} for {AttackPower} damage");
        target.TakeDamage(AttackPower);
    }

    public bool IsAlive()
    {
        return health > 0;                                                 
    }

    public void EarnGold(int amount)
    {
        if(amount > 0)
        {
            Gold += amount;
        }
        
    }
}
