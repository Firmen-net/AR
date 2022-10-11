using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 0.1f;
    [SerializeField] private float rotorSpeed = 1f;
    public GameObject rotor1;
    public GameObject rotor2;
    public bool isMoving;
    public bool isRotorMoving;

    private Vector3 startposition;

    private void Start()

    {
        startposition = transform.position;
        isMoving = false;
        isRotorMoving = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (isMoving)
        {
            transform.position = transform.position + new Vector3(0, movementSpeed * Time.deltaTime, 0);
        }
        if (transform.position.y > 0.3f)
        {
            isMoving = false;
        }
        if (isRotorMoving)
        {
            rotor1.transform.Rotate(0, rotorSpeed * Time.deltaTime, 0);
            rotor2.transform.Rotate(0, 0, rotorSpeed * Time.deltaTime);
        }
    }

    public void StartMoving()
    {
        isRotorMoving = true;
        isMoving = true;
    }

    public void StopMoving()
    {
        isRotorMoving = false;
        isMoving = false;
    }

    public void Reset()
    {
        if (!isMoving)
        {
            StopMoving();
            transform.position = new Vector3(transform.position.x, startposition.y, transform.position.z);
        }
    }
}