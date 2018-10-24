using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    Vector3 moveDirection;
    CharacterController characterController;
	// Use this for initialization
	void Start () {
        characterController = gameObject.GetComponent<CharacterController>();
        moveDirection = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        moveDirection = new Vector3(Input.GetAxisRaw("Vertical"), 0, Input.GetAxisRaw("Horizontal"));


	}
}
