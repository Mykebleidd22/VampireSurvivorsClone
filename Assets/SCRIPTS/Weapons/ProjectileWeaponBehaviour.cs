using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeaponBehaviour : MonoBehaviour
{
    protected Vector3 direction;
    public float destroyAfterSeconds;


    protected virtual void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }

    public void DirectionChecker(Vector3 dir)
    {
        direction = dir;

        if (dir == Vector3.zero) return;

        // Calcolo l'angolo automaticamente in base alla direzione
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        // Applica la rotazione
        transform.rotation = Quaternion.Euler(0, 0, angle - 90);

        // Reset della scala
        transform.localScale = new Vector3(1, 1, 1);
    }


}
