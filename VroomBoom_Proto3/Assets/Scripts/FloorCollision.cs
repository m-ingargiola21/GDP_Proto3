using UnityEngine;
using System.Collections;

public class FloorCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            Destroy(other.gameObject);
        }

    }
}
