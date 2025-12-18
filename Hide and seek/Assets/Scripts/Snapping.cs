using UnityEngine;

public class Snapping : MonoBehaviour
{
    LayerMask mask;
    [SerializeField] Transform Body;
    [SerializeField] GameObject Foot;
    float footSpacing;
    private void Awake()
    {
        footSpacing = this.transform.localPosition.x;
        mask = LayerMask.GetMask("Floor");
    }
    private void Update()
    {
        Ray ray = new Ray (Body.position + (Body.right * footSpacing), Vector3.down);
        if(Physics.Raycast(ray, out RaycastHit hitInfo, 1, mask))
        {
            transform.position = new Vector3(hitInfo.point.x, hitInfo.point.y + 0.046f, hitInfo.point.z);
        }
    }
}
