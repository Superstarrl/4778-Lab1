using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PieceMovement : MonoBehaviour
{

    public enum PieceTypes
    {
        Knight,
        Rook,
        Bishop,
        Pawn,
        Queen,
        King
    }

    public PieceTypes currentPiece;

    void Start()
    {
        
    }

#if UNITY_EDITOR

    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.blueViolet;
        switch (currentPiece)
        {

            case PieceTypes.King:

                Gizmos.DrawRay(transform.position, transform.up);
                Gizmos.DrawRay(transform.position, transform.up * -1);
                Gizmos.DrawRay(transform.position, transform.right);
                Gizmos.DrawRay(transform.position, transform.right * -1);
                Gizmos.DrawRay(transform.position, (transform.right + transform.up));
                Gizmos.DrawRay(transform.position, (transform.right + (transform.up * -1)));
                Gizmos.DrawRay(transform.position, ((transform.right * -1) + transform.up));
                Gizmos.DrawRay(transform.position, (transform.right + transform.up) * -1);

                break;

            case PieceTypes.Queen:

                Gizmos.DrawRay(transform.position, transform.up * 8);
                Gizmos.DrawRay(transform.position, transform.up * -1 * 8);
                Gizmos.DrawRay(transform.position, transform.right * 8);
                Gizmos.DrawRay(transform.position, transform.right * -1 * 8);
                Gizmos.DrawRay(transform.position, (transform.right + transform.up) * 8);
                Gizmos.DrawRay(transform.position, (transform.right + (transform.up * -1)) * 8);
                Gizmos.DrawRay(transform.position, ((transform.right * -1) + transform.up) * 8);
                Gizmos.DrawRay(transform.position, (transform.right + transform.up) * -1 * 8);
                break;

            case PieceTypes.Bishop:

                Gizmos.DrawRay(transform.position, (transform.right + transform.up) * 8);
                Gizmos.DrawRay(transform.position, (transform.right + (transform.up * -1)) * 8);
                Gizmos.DrawRay(transform.position, ((transform.right * -1) + transform.up) * 8);
                Gizmos.DrawRay(transform.position, (transform.right + transform.up) * -1 * 8);
                break;

            case PieceTypes.Rook:
                Gizmos.DrawRay(transform.position, transform.up * 8);
                Gizmos.DrawRay(transform.position, transform.up * -1 * 8);
                Gizmos.DrawRay(transform.position, transform.right * 8);
                Gizmos.DrawRay(transform.position, transform.right * -1 * 8);
                break;

            case PieceTypes.Knight:

                Gizmos.DrawRay(transform.position, transform.up * 2);
                Gizmos.DrawRay(transform.position, transform.up * -1 * 2);
                Gizmos.DrawRay(transform.position, transform.right * 2);
                Gizmos.DrawRay(transform.position, transform.right * -1 * 2);
                Gizmos.DrawRay(transform.position - new Vector3(2, 0, 0), transform.up);
                Gizmos.DrawRay(transform.position - new Vector3(2, 0, 0), -transform.up);
                Gizmos.DrawRay(transform.position - new Vector3(-2, 0, 0), transform.up);
                Gizmos.DrawRay(transform.position - new Vector3(-2, 0, 0), -transform.up);
                Gizmos.DrawRay(transform.position - new Vector3(0, 2, 0), transform.right);
                Gizmos.DrawRay(transform.position - new Vector3(0, 2, 0), -transform.right);
                Gizmos.DrawRay(transform.position - new Vector3(0, -2, 0), transform.right);
                Gizmos.DrawRay(transform.position - new Vector3(0, -2, 0), -transform.right);

                break;

            case PieceTypes.Pawn:
                Gizmos.DrawRay(transform.position, transform.up);
                break;

            default:
                break;


        }
    }
#endif


}
