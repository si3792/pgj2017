using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData : MonoBehaviour {
	public static bool debug = true;
    public static float gravityFactor = 1.0f;
    public static float gravityCutoffDistance = 100f;
    public static float rotationFactor = 0.02f;
    public static float healthUpgradeFactor = 0.75f;
    public static float speedUpgradeFactor = 0.75f;
    public static float damageUpgradeFactor = 0.75f;
    public static float bounceFactor = 700f;
    public static int dmgOnHit = 100;
    public static float chargeDrainFactor = 1.0f;

    public static int transmissionsSpied = 0;

    public static bool engineOn = false;
    public static bool shake = false;
    public static float shipCharge = 0;
}
