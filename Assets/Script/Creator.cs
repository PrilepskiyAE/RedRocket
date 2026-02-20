using UnityEngine;

public class Creator : MonoBehaviour
{
    [SerializeField]
    private GameObject coin;

    [SerializeField]
    private GameObject bomb;
   
    void Start()
    {
       for(int i = 0; i < 150; i++) {
            if (Random.Range(0, 3) == 0)
            {
                Vector3 position = new Vector3(i,Random.Range(-15f,15f),0);
                if(Random.Range(0,2)==0) {
                    Instantiate(bomb,position,Quaternion.identity);
                } else {
                    Instantiate(coin,position,Quaternion.identity);
                }
            }       
       }
    }

    
}
