using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float advanceBullet = -0.3f;

    void Update()
    {
        transform.Translate(0, 0, this.advanceBullet);
        if (transform.position.z < -10.0f)
        {
            Destroy(gameObject);
        }
    }
}
