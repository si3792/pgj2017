using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IObjectDamage {

    // Use this for initialization
    void takeDamage(GameObject inflictor, int damage);

    void doDeath(GameObject inflictor);
}
