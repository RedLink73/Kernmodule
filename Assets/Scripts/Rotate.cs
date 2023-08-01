using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Rotate : MonoBehaviour
    {
        [SerializeField] float rotSpeed = 10f;

        void Update()
        {
            transform.Rotate(0f, 0f, rotSpeed * Time.deltaTime);
        }
    }


