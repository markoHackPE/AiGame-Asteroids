using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGAsteroidsScreenWrap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 viewportCoords =
        Camera.main.WorldToViewportPoint(transform.position);
        bool changed = false;
        if (viewportCoords.x > 1f)
        {
            viewportCoords = new Vector2(viewportCoords.x - 1f, viewportCoords.y);
            changed = true;
        }
        if (viewportCoords.x < 0f)
        {
            viewportCoords = new Vector2(viewportCoords.x + 1f, viewportCoords.y);
            changed = true;
        }
        if (viewportCoords.y > 1f)
        {
            viewportCoords = new Vector2(viewportCoords.x, viewportCoords.y - 1f);
            changed = true;
        }
        if (viewportCoords.y < 0f)
        {
            viewportCoords = new Vector2(viewportCoords.x, viewportCoords.y + 1f);
            changed = true;
        }
        if(changed)
        {
            transform.position = Camera.main.ViewportToWorldPoint(viewportCoords);
        }
    }
}
