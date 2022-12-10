using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;

public class aaaa : MonoBehaviour
{

    public float RotationAmount;
    public float Speed;
    public float JumpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.GetComponent<Transform>().position += new Vector3(0, JumpSpeed, 0);
        }

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    gameObject.GetComponent<Transform>().position += new Vector3(0, -Speed, 0);
        //}

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Transform>().position += new Vector3(Speed, 0f, 0);
            gameObject.transform.Rotate(0, 0, -RotationAmount);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Transform>().position += new Vector3(-Speed, 0f, 0);
            gameObject.transform.Rotate(0, 0, RotationAmount);
        }
    }
}
