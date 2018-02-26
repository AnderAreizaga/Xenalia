using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainerInfo : MonoBehaviour {

    //Clase del entrenador
    public enum Clase
    {
        EntrenadorGuay,
        Karateka
    };

    private static string[] nombreClase = new string[]
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
