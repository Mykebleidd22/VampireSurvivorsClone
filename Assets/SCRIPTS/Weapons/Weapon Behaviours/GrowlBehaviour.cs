using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GrowlBehaviour : MeleeWeaponBehaviour
{
    protected override void Start()
    {
        base.Start();
        Debug.Log("Growl Start partito! Distruzione tra: " + destroyAfterSeconds);
    }

}
