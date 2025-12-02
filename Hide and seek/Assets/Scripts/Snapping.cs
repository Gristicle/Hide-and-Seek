using UnityEngine;

public class Snapping : MonoBehaviour
{
    LayerMask mask;
    private void Awake()
    {
        mask = LayerMask.GetMask("Floor");
    }
    private void Update()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        if(Physics.Raycast(ray, out RaycastHit hitInfo, 0.01f, mask))
        {
            transform.position = hitInfo.point;
        }
    }
}
