using UnityEngine;

public class NewMbhScript : MonoBehaviour
{
    [SerializeField] private GameObject cubeToCopy;
    [SerializeField] private int cubesNumber;
    [SerializeField] private Transform cubeToSpawnPlace;
    [SerializeField] private float radius;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        // CubeToSpawnPlace.SetParent(cubeToCopy);
        cubeToSpawnPlace.position += new Vector3(radius, 0, 0);
        for (var i = 0; i < cubesNumber; i++)
        {
            Instantiate(cubeToCopy, cubeToSpawnPlace);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
