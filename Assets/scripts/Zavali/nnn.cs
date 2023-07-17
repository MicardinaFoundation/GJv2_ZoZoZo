using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nnn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject zaval;
    public Transform zaval_underEarth;
    public string zaval_txt;
    public KeyCode key_zaval;
    public Text usi;
    public GameObject use_txt;
    public int price;
    public AudioSource Audio;
    public ParticleSystem zalavps;
    bool rabotai_svoloch;
    public static int mn = Score_money.money_scores;

    private void Start()
    {

    }

    void Update()
    {
        mn = Score_money.money_scores;
        if (Input.GetKeyDown(key_zaval) && Score_money.money_scores >= price &&  rabotai_svoloch == true)
        {
            zaval.transform.position = zaval_underEarth.transform.position;
            moneypr();
            zalavps.Play();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        rabotai_svoloch = true;
        if (other.CompareTag("Player"))
        {
            use_txt.gameObject.SetActive(true);
            usi.text = "Нажмите " + key_zaval + ", чтобы " + zaval_txt + " [Цена:" + price + "]";
            if (Input.GetKeyDown(key_zaval)/* && Score_money.money_scores >= price*/)
            {
                
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        rabotai_svoloch = false;
        use_txt.gameObject.SetActive(false);
    }

    public void moneypr()
    {
        Score_money.money_scores = mn - price;
    }
}
