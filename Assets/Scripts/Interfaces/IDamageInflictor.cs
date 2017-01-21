using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IDamageInflictor {
    void dealDamage(GameObject victim, float damage);
    void kill(GameObject victim);
}
