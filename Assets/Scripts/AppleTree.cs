using UnityEngine;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
