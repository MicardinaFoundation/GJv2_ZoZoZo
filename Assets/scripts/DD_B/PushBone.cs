using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushBone : MonoBehaviour
{
    Rigidbody rb;
    public GameObject boneref;
    Vector3 Lastpos;
    public Transform point6;
    public Transform point5;
    public Transform point4;
    public Transform point3;
    public Transform point2;
    public Transform point1;

    public Text pointtr1;
    public Text pointtr2;
    public Text pointtr3;
    public Text pointtr4;
    public Text pointtr5;
    public Text pointtr6;
    public Text pointss;
    public static float points;
    // Start is called before the first frame update
    void Start()
    {

        //bonePref.transform.position = SpawnPoint.transform.position;
        //bonePref.transform.rotation = Random.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos1 = point1.transform.position;
        Vector3 pos2 = point2.transform.position;
        Vector3 pos3 = point3.transform.position;
        Vector3 pos4 = point4.transform.position;
        Vector3 pos5 = point5.transform.position;
        Vector3 pos6 = point6.transform.position;

        

        pointtr1.text = pos1.y.ToString();
        pointtr2.text = pos2.y.ToString();
        pointtr3.text = pos3.y.ToString();
        pointtr4.text = pos4.y.ToString();
        pointtr5.text = pos5.y.ToString();
        pointtr6.text = pos6.y.ToString();



        points = Mathf.Max(pos1.y, pos2.y, pos3.y, pos4.y, pos5.y, pos6.y);
        if (points == pos1.y)
        {
            pointss.text = "Первая";
        }
        else if (points == pos2.y)
        {
            pointss.text = "Вторая";
        }
        else if (points == pos3.y)
        {
            pointss.text = "Третья";
        }
        else if (points == pos4.y)
        {
            pointss.text = "Четвертая";
        }
        else if (points == pos5.y)
        {
            pointss.text = "Пятая";
        }
        else if (points == pos6.y)
        {
            pointss.text = "Шестая";
        }
    }

    public void BonePush()
    {
        //Instantiate(bonePref, SpawnPoint.position, SpawnPoint.rotation = Random.rotation);
        //rb = GetComponent<Rigidbody>();
        //rb.AddForce(transform.forward * forceBone);
    }
}
