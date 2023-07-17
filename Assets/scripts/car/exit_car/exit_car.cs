using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit_car : MonoBehaviour
{
    public GameObject cars_colider_use;
    public GameObject player_off;
    public GameObject place_player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            player_off.transform.position = place_player.transform.position;
            player_off.gameObject.SetActive(true);
            cars_colider_use.gameObject.SetActive(false);
        }
    }
}
