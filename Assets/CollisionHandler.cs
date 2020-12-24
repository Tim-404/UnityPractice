using System.Collections;
using UnityEngine;

class CollisionHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D o)
    {
        if (o.tag == "particle")
            Destroy(o.gameObject);
    }
}