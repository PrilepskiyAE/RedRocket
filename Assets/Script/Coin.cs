using UnityEngine;

public class Coin : MonoBehaviour
{
[SerializeField]
    private GameObject dueEffectPrefab;
public void DJe()
    {
        Instantiate(dueEffectPrefab,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }
}
