using System;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;
    private ApplePicker apScript;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        apScript = Camera.main.GetComponent<ApplePicker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(gameObject);
            apScript.AppleDestroyed(); 
        }
    }
}
