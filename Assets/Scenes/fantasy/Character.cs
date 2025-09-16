using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknow hero"; }
            else { name = value; }
        }
    }



    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0) health = value;
            else health = 0;
        }
    }


    

    private int attackPower;
    public int AttackPower
    {
        get; private set;
    }


    //create an object
    public virtual void Init(string newName, int newHp, int newAttackPower)
    {
        Name = newName;
        Health = newHp;
        AttackPower = newAttackPower;
    }
    //Init

    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
    }

    public void ShowStute()
    {
        Debug.Log($"Hero name : {Name} | Hero health : {Health}|AttackPower : {AttackPower} | Gold : ");
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

    public void initmon(string newName, int newHp, int newAttackPower, int newLootReward)
    {
        Name = newName;
        Health = newHp;
        AttackPower = newAttackPower;
        
    }
}
