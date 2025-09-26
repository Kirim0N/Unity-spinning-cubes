using UnityEngine;
// using System;

public class NewMbhScript : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private int cubesNumber;
    [SerializeField] private Transform cubeParent;
    [SerializeField] private float radius;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        for (var i = 0; i < cubesNumber; i++)
        {
            var x = (float) Mathf.Cos((2 * Mathf.PI / cubesNumber) * i) * radius;
            var z = (float) Mathf.Sin((2 * Mathf.PI / cubesNumber) * i) * radius;
            Instantiate(cubePrefab, new Vector3(x, 0, z), Quaternion.Euler(0, 0, 0), cubeParent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
