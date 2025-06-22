using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class AppleTree : MonoBehaviour
{
    [SerializeField]
    private GameObject applePrefab;

    [SerializeField]
    private float speed = 1f;
    
    [SerializeField]
    private float leftAndRightEdge = 10f;
    
    [SerializeField]
    private float chanceToChangeDirections = 0.1f;
    
    [SerializeField]
    private float secondsBetweenAppleDrops = 1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = applePrefab.transform.position;
        Invoke("DropApple", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if ( pos.x < -leftAndRightEdge ) {
            speed = Mathf.Abs(speed);
        } else if ( pos.x > leftAndRightEdge ) {
            speed = -Mathf.Abs(speed);
        }

    }

    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections ) {
            speed *= -1;
        }
    }

    private void DropApple()
    {
        GameObject apple = Instantiate(applePrefab);
        apple.transform.position = new Vector3(x: transform.position.x, y: transform.position.y, z: -1f);
        Invoke("DropApple", secondsBetweenAppleDrops);
    }
}
