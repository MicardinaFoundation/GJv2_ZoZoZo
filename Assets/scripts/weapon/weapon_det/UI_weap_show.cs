using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_weap_show : MonoBehaviour
{
    public Text ammo_ui;
    public Text name_weap_UI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ammo_ui.text = weap_shoot.F;
    }
}
