using UnityEngine;

public class WallCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(other.gameObject);
        }
    }
}
