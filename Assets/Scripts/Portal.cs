using UnityEngine;

public class Portal : MonoBehaviour
{
    Vector3 position;

    private void OnTriggerStay(Collider other)
    {
            position = other.gameObject.transform.position;
            position.y = 11.5f;
            other.gameObject.transform.position = position;
    }
}
