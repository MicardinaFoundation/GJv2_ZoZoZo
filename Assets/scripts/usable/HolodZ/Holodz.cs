using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Holodz : MonoBehaviour
{

    public Text usi;
    public KeyCode key;
    public GameObject use_txt;
    public GameObject Holodzilnik;
    public int speed_count;
    bool pes;

    private void Start()
    {
        pes = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player") && Holodzilnik.CompareTag("SpeedHDZ"))
        {
            use_txt.gameObject.SetActive(true);
            usi.text = "Нажмите " + key + ", чтобы купить напиток " + "Скорялка";
            if (Input.GetKey(KeyCode.E) )
            {
                perks_.speed_prk_bl = true;
                pes = true;
                Score_money.money_scores -= 1500;
            }
        }
    }

    private void OnTriggerExit(Collider col)
    {

        use_txt.gameObject.SetActive(false);
    }
}
