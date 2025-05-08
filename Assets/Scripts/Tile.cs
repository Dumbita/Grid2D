using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    [SerializeField] private Color baseColour, offsetColour;
    [SerializeField] private SpriteRenderer renderer;
    [SerializeField] private GameObject highlight;

    public void Init(bool isOffset)
    {

        renderer.color = isOffset ? offsetColour : baseColour;

    }

    private void OnMouseEnter()
    {

        highlight.SetActive(true);
    
    }

    private void OnMouseExit()
    {

        highlight.SetActive(false);

    }

}
