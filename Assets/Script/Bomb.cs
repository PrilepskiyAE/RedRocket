using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField]
    private GameObject dueEffectPrefab;
public void DJe()
    {
        Instantiate(dueEffectPrefab,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }
}
