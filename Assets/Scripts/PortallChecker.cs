using UnityEngine;

public class PortallChecker : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Portal")
        {
            transform.position = new Vector3(transform.position.x, 12f, transform.position.z);
        }
    }

}
