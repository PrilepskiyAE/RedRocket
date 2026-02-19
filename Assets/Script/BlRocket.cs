using UnityEngine;

public class BlRocket : MonoBehaviour
{
[SerializeField]
private int heatlth=2;
[SerializeField]
private Score score;

void OnTriggerEnter(Collider other)
{
    Bomb bomb = other.gameObject.GetComponent<Bomb>();
        if (bomb)
        {   
            heatlth-=1;
            bomb.DJe();
        }

         Coin coin = other.gameObject.GetComponent<Coin>();
        if (coin)
        {   
            score.AddOne();
            coin.DJe();

        }
}
}
