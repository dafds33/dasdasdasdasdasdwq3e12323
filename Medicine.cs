using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medicine : MonoBehaviour
{
    public int medicine;

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(medicine > 0)
            {
                //GameObject player = GameObject.FindGameObjectWithTag("Player");
                Player playerInfo = gameObject.GetComponent <Player>();
                playerInfo.health += 1;
                medicine -= 1;
            }
            else
            {
                print("Недостаточно аптечек!");
            }

        }
    }
}
