using UnityEngine;

public class CubesAngleChanger : MonoBehaviour
{
    [SerializeField] private Transform center;
    [Range(0, 360)] [SerializeField] private float xAngle;
    [Range(0, 360)] [SerializeField] private float zAngle;

    // Update is called once per frame
    void Awake()
    {
        center.rotation = Quaternion.Euler(xAngle, center.rotation.y, zAngle);
    }
}
