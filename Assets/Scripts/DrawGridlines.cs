using UnityEngine;
using UnityEditor;


[ExecuteInEditMode]
public class DrawGridlines1 : MonoBehaviour
{
    public int lineSize = 8;
  
    private void Update()
    {
        
    }

    #if UNITY_EDITOR
    private void OnDrawGizmos()
    {

        for (int i = 0; i < 9; i++)
        {
            Vector3 startPoint = new Vector3(0, i, 0);
            Gizmos.color = Color.white;
            Vector3 direction = transform.TransformDirection(Vector3.right) * lineSize;
            Gizmos.DrawRay(startPoint, direction);
        }

        for (int i = 0; i < 9; i++)
        {
            Vector3 startPoint = new Vector3(i, 0, 0);
            Gizmos.color = Color.white;
            Vector3 direction = transform.TransformDirection(Vector3.up) * lineSize;
            Gizmos.DrawRay(startPoint, direction);
        }
    }
    #endif 
}