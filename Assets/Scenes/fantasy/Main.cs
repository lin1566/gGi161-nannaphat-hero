using NUnit.Framework;  
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Hero hero1 ;
    public List< monsters> monstersPrefab;//for monster
    public List< monsters> Monsters = new List<monsters>();//monster
    public monsters cerrentmonster;
    void Start()
    {
        hero1.Init("Bocchi Yusha",50,10);
        hero1.ShowStute();

        cerrentmonster = Instantiate(monstersPrefab[0]);
        cerrentmonster.initmon("Nichiga evil",10,20,20);
        Monsters.Add(cerrentmonster);
        cerrentmonster.ShowStute();

        cerrentmonster =  Instantiate(monstersPrefab[1]);
        cerrentmonster.initmon("Dragon yamada",20,20,15);
        Monsters.Add(cerrentmonster);
        cerrentmonster.ShowStute();

        cerrentmonster =  Instantiate(monstersPrefab[2]);
        cerrentmonster.initmon("Bigdoor kita",30,20,50);
        Monsters.Add(cerrentmonster);
        cerrentmonster.ShowStute();




























        /* Hero hero = new Hero("bocchi yusha", 100, 100);
        Hero hero1 = new Hero("Nichiga Evil", 1000, 100);

        
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
        hero.ShowStute();*/


    }


}
