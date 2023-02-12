using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;
    public float speed = 2f;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Player.transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Player.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }

}
