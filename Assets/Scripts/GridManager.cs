// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class GridManager : MonoBehaviour
// {
//     private Camera _mainCamera;
//     private Vector3 _mouseWorldPos;
//     private Ray _ray;
//     [SerializeField] private float _rayCastDistance;
//     [SerializeField] private LayerMask _rayCastLayerMask;
//     private Collider _hitCollider;
//     private Vector3 _hitNormal;
//     private Vector3 _hitPoint;

//     private void Awake() {
//         _mainCamera = Camera.main;
//     }

//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         CursorSelect();
//     }

//     private void CursorSelect() {
//         Vector2 mousePos = Input.mousePosition;
//         //_mouseWorldPos = _mainCamera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, _mainCamera.nearClipPlane)); 
//         _ray = _mainCamera.ScreenPointToRay(mousePos);
//         RaycastHit hit;
//         Physics.Raycast(_ray, out hit, _rayCastDistance, _rayCastLayerMask);
//         //Debug.Log(_mouseWorldPos);
//         //_sphere.position = _mouseWorldPos;
//         //Debug.Log(_ray.direction);
//         Vector3 hitPoint = hit.point;
//         _hitCollider = hit.collider;
//         _hitNormal = hit.normal;
//         _hitPoint = hit.point;
//     }

//     private void OnDrawGizmos() {
//         Gizmos.DrawRay(_ray);
//         if (_hitCollider!= null) {
//             //Gizmos.DrawRay(_hitCollider.transform.position, _hitNormal);
//             Gizmos.DrawLine(_mainCamera.gameObject.transform.position, _hitPoint);                
//         }
//     }
// }
