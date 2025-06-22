using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Basket : MonoBehaviour
{
    private Camera _mainCamera;

    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        // Use Mouse.current from the new Input System
        if (Mouse.current == null) return; // Safety check

        Vector2 mousePosition = Mouse.current.position.ReadValue();

        // Convert screen position to world position
        Vector3 screenPosition = new Vector3(mousePosition.x, mousePosition.y, -_mainCamera.transform.position.z);
        Vector3 worldPosition = _mainCamera.ScreenToWorldPoint(screenPosition);

        // Move the basket's x-position
        Vector3 newPosition = transform.position;
        newPosition.x = worldPosition.x;
        transform.position = newPosition;
    }
}