using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pokemon : MonoBehaviour {

    public enum Gender
    {
        NONE,
        MALE,
        FEMALE,
        CALCULATE
    }
    public enum Status
    {
        NONE,
        BURNED,
        FROZEN,
        PARALYZED,
        POISONED,
        ASLEEP,
        FAINTED
    }

    private int ID;
    private string nickname;
    private string race;
    private int HP;
    private int currentHP;
    private int ATK;
    private int DEF;
    private int SPD;
    private int SPA;
    private int SPE;
    private string nature { get; set; }
    private string type1 { get; set; }
    private string type2 { get; set; }
    private string OT { get; set; }
    private int IDno { get; set; }
    private string caughtBall { get; set; }
    private string heldItem { get; set; }
    private int level { get; set; }
    private int EXP { get; set; }
    private int nextLevelEXP { get; set; }
    private Gender gender { get; set; }
    private Status statusP {get;set;}
    private int ability { get; set; }
    private string movimientos;

    private string metDate;
    private string metMap;
    private int metLevel;


}
