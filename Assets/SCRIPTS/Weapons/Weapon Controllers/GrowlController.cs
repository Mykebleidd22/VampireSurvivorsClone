using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowlController : WeaponController
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Attack()
    {
        base.Attack();
        GameObject spawnedGrowl = Instantiate(prefab);
        spawnedGrowl.transform.position = transform.position;
        spawnedGrowl.transform.parent = transform;
    }
}
