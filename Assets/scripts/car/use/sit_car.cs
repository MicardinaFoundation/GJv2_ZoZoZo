using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sit_car : MonoBehaviour
{
    GameObject player_colider_use;


    public GameObject cars_colider_use;
    public GameObject use_canvas;
    bool bb;
    public GameObject car_use_dev;
    public GameObject player_off;
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
        if (bb == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                player_off.gameObject.SetActive(false);
                cars_colider_use.gameObject.SetActive(true);
            }
        }
    }

    private void OnTriggerStay(Collider collider_car)
    {
        bb = true;
        use_canvas.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider collider_car)
    {
        bb = false;
        use_canvas.gameObject.SetActive(false);
    }
}
