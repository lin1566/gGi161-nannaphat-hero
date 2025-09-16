using UnityEngine;

public class monsters : Character
{
    [SerializeField] private int lootReward;

    public int LootReward
    {
        get { return lootReward; }
        set
        {
            if (value < 0) { lootReward = 0; }
            else { lootReward = value; }
        }
    }
    [SerializeField] private bool defeated = false;
    public int DropReward()
    {
        return LootReward;
    }
}

