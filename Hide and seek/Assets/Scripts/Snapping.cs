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
        if(Physics.Raycast(ray, out RaycastHit hitInfo, 1, mask))
        {
            transform.position =new Vector3(hitInfo.point.x, hitInfo.point.y + 0.01f, hitInfo.point.z);
        }
    }
}
