using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DDUI : MonoBehaviour
{
    public Text usi;
    public KeyCode key;
    public GameObject bonePref;
    public Transform SpawnPoint;
    public GameObject use_txt;
    public GameObject DDavaizer;
    public GameObject[] gunDDB_msv;
    public int time_dice;
    public int count;
    bool un = false;

    void Start()
    {

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) && un == true)
        {
            bonePref.transform.position = SpawnPoint.transform.position;
            bonePref.transform.rotation = Random.rotation;
        }

    }


    private void OnTriggerEnter(Collider col)
    {
        un = true;
        if (col.CompareTag("Player") && DDavaizer.CompareTag("DDt"))
        {
            use_txt.gameObject.SetActive(true);
            usi.text = "Удержиавйту " + key + ", чтобы крутануть Дайс-Давайзер";
            if (Input.GetKeyDown(KeyCode.E))
            {
                Score_money.money_scores -= count;
            }
        }
    }

    private void OnTriggerExit(Collider col)
    {
        un = false;
        use_txt.gameObject.SetActive(false);
    }
}
