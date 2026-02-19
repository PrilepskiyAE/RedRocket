using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
[SerializeField]
private int coin;
[SerializeField]
Text coinsText;

public void AddOne()
    {
        coin +=1; 
        coinsText.text = "Score "+coin;
    }

}
