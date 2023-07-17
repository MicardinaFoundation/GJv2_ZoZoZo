using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_bpk : MonoBehaviour
{
    public GameObject oneWeap;
    public GameObject twoWeap;
    bool changeWeap_bl = false;
    public Transform TDW;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (changeWeap_bl == true)
            {
                oneWeap.gameObject.SetActive(false);
                twoWeap.gameObject.SetActive(true);
                changeWeap_bl = false;
                twoWeap.transform.position = TDW.transform.position;
                Debug.Log("2 weap");
                return;
            }
            else if (changeWeap_bl == false)
            {
                twoWeap.gameObject.SetActive(false);
                oneWeap.gameObject.SetActive(true);
                changeWeap_bl = true;
                oneWeap.transform.position = TDW.transform.position;
                Debug.Log("1 weap");
                return;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (changeWeap_bl == true)
            {
                oneWeap.gameObject.SetActive(false);
                twoWeap.gameObject.SetActive(true);
                changeWeap_bl = false;
                twoWeap.transform.position = TDW.transform.position;
                Debug.Log("2 weap");
                return;
            }
            else if (changeWeap_bl == false)
            {
                twoWeap.gameObject.SetActive(false);
                oneWeap.gameObject.SetActive(true);
                changeWeap_bl = true;
                oneWeap.transform.position = TDW.transform.position;
                Debug.Log("1 weap");
                return;
            }
        }

    }
}
