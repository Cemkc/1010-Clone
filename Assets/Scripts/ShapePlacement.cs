using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ShapePlacement : MonoBehaviour
{

    public GameObject shape;
    public Tilemap shapeTilemap;
    private List<Vector2> shapeTileBaseList;

    // Start is called before the first frame update
    void Start()
    {

        shapeTileBaseList = GetAllTiles(shapeTilemap);

        for (int i = 0; i < shapeTileBaseList.Count; i++){
            Debug.Log(shapeTileBaseList[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public List<Vector2> GetAllTiles(Tilemap tilemap)
    {
        List<Vector2> resArray;
        resArray = new List<Vector2>();

        var bounds = tilemap.cellBounds;
        for (int x = bounds.min.x; x < bounds.max.x; x++)
        {
            for (int y = bounds.min.y; y < bounds.max.y; y++)
            {
            
                var cellPosition = new Vector3Int(x, y, 0);
                var tile = tilemap.GetTile(cellPosition);

                if (tile == null) continue;

                resArray.Add(new Vector2(x, y));
            }

        }
        return resArray;
    }
    

}
