using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Name: Vasavi Jaladi
/// Project: Cat Assignment
/// Date: 05/06/2019
/// </summary>
public class Spawner : MonoBehaviour
{

    public GameObject myCat;

    public void Spawn(Vector3 position)
    {
        Instantiate(myCat).transform.position = position;
    }

    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //Make Z postion the Z position of prefab Object.
            Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, myCat.transform.position.z);

            Spawn(adjustZ);
        }

    }
}
