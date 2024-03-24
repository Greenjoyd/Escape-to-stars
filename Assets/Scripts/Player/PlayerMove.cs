using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    private Rigidbody rb;
    private PlayerInputActions playerInputActions;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
         playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();

    }

    private Vector3 GetMovementVector()
    {
        Vector3 inputVector = playerInputActions.Player.Move.ReadValue<Vector3>();

        return inputVector;
    }


    private void FixedUpdate()
    {
        Vector3 inputVector = GetMovementVector();

        inputVector = inputVector.normalized;

        rb.MovePosition(rb.position+inputVector*(_speed*Time.fixedDeltaTime));
    }

}
