using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{

    public List<Transform> shapeSpawnPos;
    private List<GameObject> deckOfShapes;
    private List<GameObject> dynamicDeck;
    private List<GameObject> handOfShapes;

    // Start is called before the first frame update
    void Start()
    {
        deckOfShapes = new List<GameObject>();
        handOfShapes = new List<GameObject>();
        dynamicDeck = deckOfShapes;
        deckOfShapes.AddRange(LoadResources<GameObject>("BlockShapes/"));
        InitializeHand();
        foreach (GameObject shape in handOfShapes)
        {
            Debug.Log(shape.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    // void InitializeHand(){
    //     List<int> selectedIndexes = new List<int>();
    //     int loopUpperBound = 3;
    //     bool sameShapeDrawed = false;
    //     for(int i = 0; i < loopUpperBound; i++){

    //         int index = Random.Range(0, deckOfShapes.Count-1);

    //         for(int j = 0; j < selectedIndexes.Count; j++){
    //             if(index == selectedIndexes[j]){
    //                 loopUpperBound++;
    //                 sameShapeDrawed = true;
    //             }
    //         }

    //         if(sameShapeDrawed) continue;

    //         selectedIndexes.Add(index);

    //         handOfShapes.Add(deckOfShapes[index]);
    //     }
    // }

    void InitializeHand(){
        for(int i = 0; i < 3; i++){
            int index = Random.Range(0, deckOfShapes.Count - 1);
            dynamicDeck.RemoveAt(index);
            handOfShapes.Add(Instantiate(dynamicDeck[index], shapeSpawnPos[i].position, Quaternion.identity));
        }
        dynamicDeck = deckOfShapes;
    }

    public static T[] LoadResources<T>(string Path) where T : class {
        T[] list = Resources.LoadAll(Path, typeof(T)).Cast<T>().ToArray();
        return list;
    } 

    public static T LoadResource<T>(string Path) where T : class {
        T obj = Resources.Load(Path, typeof(T)) as T;
        return obj;
    }
}
