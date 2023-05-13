using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MainLogic : MonoBehaviour
{
    public Tilemap placedShapeTileMap;
    public List<Vector2> placedShapePos;
    public Tilemap baseTileMap;
    public Tilemap activeTileMap;
    public Tile baseTile;
    public Tile activeTile;
    private Vector3 mouseWorldPos;
    private Vector3Int mouseCellPos;
    bool isPlacementValid = true;
    public ShapePlacement shapePlacement;

    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool CheckValidPlacement(Tilemap tilemap, Vector3 mousePos){
        mouseCellPos = baseTileMap.WorldToCell(mousePos);
        placedShapePos = shapePlacement.GetAllTiles(tilemap);
        isPlacementValid = true;
        foreach(Vector2 shapePos in placedShapePos){
            Vector3Int currentTilePos = new Vector3Int((int)(shapePos.x + mouseCellPos.x), (int)(shapePos.y + mouseCellPos.y), 0);

            if(baseTileMap.GetTile(currentTilePos) == baseTile){
                if(activeTileMap.GetTile(currentTilePos) != null){
                    isPlacementValid = false;
                }
            }
            else{
                isPlacementValid = false;
            }
        }
        if(isPlacementValid){
            foreach(Vector2 shapePos in placedShapePos){
                Vector3Int currentTilePos = new Vector3Int((int)(shapePos.x + mouseCellPos.x), (int)(shapePos.y + mouseCellPos.y), 0);
                activeTileMap.SetTile(currentTilePos, activeTile);
            }
        }
        return isPlacementValid;
    }
    

}
