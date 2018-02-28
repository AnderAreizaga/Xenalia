using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainerInfo : MonoBehaviour {

    public string trainerName;
    public Pokemon[] party;
    //Clase del entrenador
    public enum Class
    {
        EntrenadorGuay,
        Karateka
    };

    private static string[] className = new string[]
   {
        "Entrenador Guay",
        "Karateka"
   };

    private static int[] recompensaClase = new int[]
    {
        100,
        60
    };
}
