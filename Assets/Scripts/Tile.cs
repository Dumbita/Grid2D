using UnityEngine;

public class Tile : MonoBehaviour
{

    [SerializeField] private Color baseColour, offsetColour;
    [SerializeField] private SpriteRenderer renderer;

    public void Init(bool isOffset)
    {

        renderer.color = isOffset ? offsetColour : baseColour;

    }

}
