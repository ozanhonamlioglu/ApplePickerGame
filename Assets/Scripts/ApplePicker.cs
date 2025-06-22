using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    [SerializeField] private GameObject basketPrefab;

    [SerializeField] private int numBaskets = 3;

    [SerializeField] private float basketBottomY = -14f;

    [SerializeField] private float basketSpacingY = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}