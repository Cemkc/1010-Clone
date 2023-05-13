using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ObjectDrag : MonoBehaviour
{
    private Vector3 pos;
    private Vector3 initialPos;
    private MainLogic mainLogic;
    private Tilemap shapeTilemap;


    private void Awake(){
        shapeTilemap = GetComponentInChildren<Tilemap>();
        mainLogic = FindObjectOfType<MainLogic>();
    } 

    private void OnEnable() 
    {
        initialPos = transform.position;
        OnMouseDown();
    }

    private void Update() 
    {
        // OnMouseDrag();
    }

    private void OnMouseDown() 
    {
        
    }

    private void OnMouseDrag() 
    {
        pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 transferPos = new Vector3(pos.x, pos.y, initialPos.z);
        transform.position = transferPos;
    }

    private void OnMouseUp()
    {   
        if(mainLogic.CheckValidPlacement(shapeTilemap, pos)){
            Debug.Log("HELLO");
            Destroy(gameObject);
        }
        else{
            transform.position = initialPos;
        }
    }

}
