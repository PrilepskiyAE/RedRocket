using UnityEngine;

public class Bullet : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
{
    Bomb bomb = other.gameObject.GetComponent<Bomb>();
        if (bomb)
        {   
            bomb.DJe();
            Destroy(gameObject);
        }

}
}
