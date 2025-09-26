using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private Transform center;
    [Range(0, 10)] [SerializeField] private float speed;
    
    void FixedUpdate()
    {
        center.Rotate(0, speed, 0);
    }
}
