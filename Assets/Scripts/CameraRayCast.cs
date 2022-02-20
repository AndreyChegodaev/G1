using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRayCast : MonoBehaviour
{
    public Camera illustrationCamera;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // do we hit the illustration?
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject);

                var localPoint = hit.textureCoord;
                // convert the hit texture coordinates into camera coordinates:
                Ray illustrationRay = illustrationCamera.ScreenPointToRay(new Vector2(localPoint.x * illustrationCamera.pixelWidth, localPoint.y * illustrationCamera.pixelHeight));
                RaycastHit illustrationHit;

                // test these camera coordinates in another raycast test:
                if (Physics.Raycast(illustrationRay, out illustrationHit))
                {
                    Debug.Log(illustrationHit.collider.gameObject);
                }
            }
        }
    }
}
