using UnityEngine;

    public class monsters : MonoBehaviour
{
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknow Monster"; }
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

    private int lootReward;
    public int LootReward
    {
        get { return lootReward; }
        set { if (value < 0) { lootReward = 0; }
            else { lootReward = value; }
        } 
    }

    bool IsDefeated;

    public monsters(string newName, int newHp,int newAttackPower,int newLootReward)
    {
        Name = newName;
        Health = newHp;
        AttackPower = newAttackPower;
        LootReward = newLootReward;
        IsDefeated = false;
    }

    //show stute
    public void ShowStute()
    {
        Debug.Log($"Monster name : {Name} | Monster health : {Health} , Monster ATK : {AttackPower} , | Monster LootReward : {lootReward}");
    }

    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
    }

    public void Attack(Hero target)
    {
        Debug.Log($"{Name} attack {target.Name} for {AttackPower} damage");
        target.TakeDamage(AttackPower);
    }

    public bool IsAlive()
    {
        return health > 0;
    }

    public int DropReward()
    {
        return lootReward;
    }
   public monsters Monster;
}
