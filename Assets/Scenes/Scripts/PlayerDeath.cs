using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
            Debug.Log("zhi is a big baby");
    }
}
