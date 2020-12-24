using System.Collections;
using UnityEngine;
//comment by brandon and timmmmmmmm
class CollisionHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D o)
    {
        if (o.tag == "particle")
            Destroy(o.gameObject);
    }
}
