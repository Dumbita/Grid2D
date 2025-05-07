using UnityEngine;

public class GridManager : MonoBehaviour
{
    //coordinates of tiles
    [SerializeField] private int width, height;
    //tile itself
    [SerializeField] private Tile tilePrefab;
    //camera position
    [SerializeField] private Transform cam;

    void Start()
    {

        GenerateGrid();

    }
    //makes the board
    void GenerateGrid()
    {
        //position x where tiles have to be spawned
        for (int i = 0; i < width; i++)
        {
            //position y where tiles has to be spwaned
            for (int j = 0; j < height; j++)
            {
                //spawns the tiles
                var spawnedTile = Instantiate(tilePrefab, new Vector3(i, j), Quaternion.identity);
                //spawns tile with its nameon its coordinates
                spawnedTile.name = $"Tile {i} {j}";
                //chacking tiles if they are odd or even to make the chess pattern
                var isOffset =(i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0);
                spawnedTile.Init(isOffset);

            }
            
        }

        cam.transform.position = new Vector3((float)width / 2f - 0.5f,(float) height / 2f - 0.5f, cam.transform.position.z);

    }

}
