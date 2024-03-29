using UnityEngine;

public class KeepObjectStill : MonoBehaviour
{
    void Start()
    {
        // Freeze position and rotation
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
