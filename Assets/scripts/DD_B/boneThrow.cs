using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boneThrow : MonoBehaviour
{
    public Transform bonePref;
    public Transform SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(bonePref, SpawnPoint.position, SpawnPoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
