using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (CharacterController))]
public class Player : MonoBehaviour {


    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

}
