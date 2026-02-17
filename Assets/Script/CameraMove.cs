using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private Transform target;


    void Update()
    {
        if (target != null)
        {
              transform.position = target.position; 
        }
     
    }
}
