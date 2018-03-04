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
    private string Nature { get; set; }
    private string Type1 { get; set; }
    private string Type2 { get; set; }
    private string OT { get; set; }
    private int IDno { get; set; }
    private string CaughtBall { get; set; }
    private string HeldItem { get; set; }
    private int Level { get; set; }
    private int EXP { get; set; }
    private int NextLevelEXP { get; set; }

    private int Ability { get; set; }
    private string movimientos;

    private string MetDate { get; set; }
    private string MetMap { get; set; }
    private int MetLevel { get; set; }

    private Gender GenderP { get; set; }
    private Status StatusP { get; set; }


}
