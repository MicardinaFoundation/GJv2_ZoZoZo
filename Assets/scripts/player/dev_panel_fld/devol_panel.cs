using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devol_panel : MonoBehaviour
{
    public GameObject dv_panel;
    // Start is called before the first frame update
    void Start()
    {
        dv_panel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            dv_panel.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

    public void CloseDevPanel()
    {
        dv_panel.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
