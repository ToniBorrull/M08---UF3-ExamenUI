using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FirstPersonController))]
public class FirstPersonController_Input : MonoBehaviour
{
    FirstPersonController controller;
    Inputs inputs;
    // Start is called before the first frame update
    void Start()
    {
        inputs = new Inputs();
        inputs.Player.Enable();
        controller = GetComponent<FirstPersonController>();
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        //controller.Move(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")), Time.fixedDeltaTime);
        controller.Move(inputs.Player.Move.ReadValue<Vector2>(), Time.fixedDeltaTime);
    }
    private void LateUpdate()
    {
        controller.Look(inputs.Player.Look.ReadValue<Vector2>());
    }
}
