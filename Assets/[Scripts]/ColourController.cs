using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ColourController : MonoBehaviour
{
    public Color platformColour;

    private List<SpriteRenderer> tileSpriteRenderers;
    // Start is called before the first frame update
    void Start()
    {
        tileSpriteRenderers = GetComponentsInChildren<SpriteRenderer>().ToList();
        SetColour();
    }

    public void SetColour()
    {
        foreach (var renderer in tileSpriteRenderers)
        {
            renderer.material.SetColor("_Color", platformColour);
        }
    }

    public void SetColour(Color color)
    {
        foreach (var renderer in tileSpriteRenderers)
        {
            renderer.material.SetColor("_Color", color);
        }
    }
}
