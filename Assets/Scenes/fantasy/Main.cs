using NUnit.Framework;  
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private List<monsters> monsters = new List<monsters>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hero hero = new Hero("Himmel", 100, 100);
        Hero hero1 = new Hero("John", 1000, 100);

        
        monsters monster = new monsters("Orc", 100, 10 , 20);
        monsters monster1 = new monsters("Woman", 150, 12, 25);
        monsters monster2 = new monsters("GirlInRealLife", 2000, 15, 50);
        monsters.Add(monster);
        monsters.Add(monster1);
        monsters.Add(monster2);
        monsters.Add(new monsters("Demon", 20, 20, 20));


        //show hero stute
        Debug.Log($"Hero name : {hero.Name} | Hero health : {hero.Health} | Gold : {hero.Gold}");
        Debug.Log($"Hero name : {hero1.Name} | Hero health : {hero1.Health} | Gold : {hero1.Gold}");

        
        //Show monster stute
        //Debug.Log($"Monster name : {monster.Name} | Monster health : {monster.Health}");
        //Debug.Log($"Monster name : {monster1.Name} | Monster health : {monster1.Health}");
        //Debug.Log($"Monster name : {monster2.Name} | Monster health : {monster2.Health}");

        hero.ShowStute();
        foreach (var mon in monsters)
        {
            //Debug.Log($"Monster name : {mon.Name} | Monster health : {mon.Health}");
            mon.ShowStute();
        }

        monster2.ShowStute();
        hero.Attack(monster2);
        monster2.ShowStute();

        hero.ShowStute();
        monster.Attack(hero);
        hero.ShowStute();


    }


}
