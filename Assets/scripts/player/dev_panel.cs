using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dev_panel : MonoBehaviour
{
    public GameObject de_panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            de_panel.gameObject.SetActive(true);
        }
    }


}
