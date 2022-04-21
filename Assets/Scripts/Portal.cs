using UnityEngine;

public class Portal : MonoBehaviour
{
    Vector3 position;

    private void OnTriggerStay(Collider other)
    {

        print(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            //position = other.gameObject.transform.position;
            //position.y = 11.5f;
            //other.gameObject.transform.position = position;
        }
    }
}
