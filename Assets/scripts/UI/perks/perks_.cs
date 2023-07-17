using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perks_ : MonoBehaviour
{
    public GameObject speed_prk;
    public static bool speed_prk_bl;
    public GameObject strong_prk;
    public static bool strong_prk_bl;
    public GameObject multip_prk;
    public static bool multip_prk_bl;
    public GameObject lifeshld_prk;
    public static bool lifeshld_prk_bl;
    public GameObject base_prk;
    public static bool base_prk_bl;
    public GameObject add_life_prk;
    public static bool add_life_prk_bl;
    int numb;
    // Start is called before the first frame update
    void Start()
    {
        numb = 0;
        speed_prk_bl = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (speed_prk_bl == true)
        {
            speed_prk.gameObject.SetActive(true);
            numb += 1;
        }
        else
        {
            speed_prk.gameObject.SetActive(false);
            numb += 0;
        }

        if (strong_prk_bl == true)
        {
            strong_prk.gameObject.SetActive(true);
            numb += 1;
        }
        else
        {
            strong_prk.gameObject.SetActive(false);
            numb += 0;
        }

        if (multip_prk_bl == true)
        {
            multip_prk.gameObject.SetActive(true);
            numb += 1;
        }
        else
        {
            multip_prk.gameObject.SetActive(false);
            numb += 0;
        }

        if (lifeshld_prk_bl == true)
        {
            lifeshld_prk.gameObject.SetActive(true);
            numb += 1;
        }
        else
        {
            lifeshld_prk.gameObject.SetActive(false);
            numb += 0;
        }

        if (base_prk_bl == true)
        {
            base_prk.gameObject.SetActive(true);
            numb += 1;
        }
        else
        {
            base_prk.gameObject.SetActive(false);
            numb += 0;
        }

        if (add_life_prk_bl == true)
        {
            add_life_prk.gameObject.SetActive(true);
            numb += 1;
        }
        else
        {
            add_life_prk.gameObject.SetActive(false);
            numb += 0;
        }
    }
}
