using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private Transform center;
    [Range(0, 10)] [SerializeField] private float speed;
    [Range(0, 360)] [SerializeField] private float xAngle;
    [Range(0, 360)] [SerializeField] private float zAngle;
    
    void FixedUpdate()
    {
        center.rotation = Quaternion.Euler(xAngle, center.eulerAngles.y + speed, zAngle);
    }
}
