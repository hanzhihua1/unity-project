using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name != "Ground")
            Debug.Log("zhi is a big baby");
    }
}
