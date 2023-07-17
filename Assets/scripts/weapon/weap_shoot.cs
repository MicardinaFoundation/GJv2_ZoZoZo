using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weap_shoot : MonoBehaviour
{
    public float damage;
    public float range = 100f;
    public float fireRate = 15f;
    public float impactForce = 30f;
    public ParticleSystem boom;

    public GameObject dulo;
    public string weapon_name;
    private float nextTimeToFire = 0f;

    int i = 1;
    public int fullCurrentAmmo;
    int CurrentAmmo;
    public int fullAllAmmo;
    int AllAmmo;
    public static string F;

    void Start()
    {
        CurrentAmmo = fullCurrentAmmo;
        AllAmmo = fullAllAmmo;
        Debug.Log(AllAmmo);
        Debug.Log(CurrentAmmo + " f");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire && CurrentAmmo > 0)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
            ammoLose();
            Debug.Log(AllAmmo);
        }
        if (Input.GetKeyDown(KeyCode.R) && AllAmmo > 0)
        {
            Reload();
        }
        
        F = CurrentAmmo + " / " + AllAmmo;
    }

    void Shoot()
    {
        boom.Play();
        RaycastHit hit;
        if (Physics.Raycast(dulo.transform.position, dulo.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            target target = hit.transform.GetComponent<target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
    void ammoLose()
    {
        CurrentAmmo -= 1;
    }

    void Reload()
    {
        int reason = fullCurrentAmmo - CurrentAmmo;
        int result = AllAmmo - reason;
        AllAmmo = result;
        CurrentAmmo = fullCurrentAmmo;

        if (AllAmmo < 0)
        {
            CurrentAmmo += AllAmmo;
            AllAmmo = 0;
        }
    }
}
