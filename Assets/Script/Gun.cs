using UnityEngine;

public class Gun : MonoBehaviour
{
   [SerializeField]
   GameObject bulletPrefab;
   
    [SerializeField]
    private float speed = 15f;
    [SerializeField]
    private AudioSource shotSound;
    [SerializeField]
    private float ShotPeriod=0.15f;
    private float _timer;


    void Update()
    {
        _timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            if (_timer > ShotPeriod)
            {
                _timer = 0f;
                   CreateBullet();
            }

        }     
    }

    void CreateBullet()
    {
        GameObject newBullet = Instantiate(bulletPrefab,transform.position,transform.rotation);
            newBullet.GetComponent<Rigidbody>().linearVelocity = transform.forward * speed;
            shotSound.pitch=Random.Range(0.8f,1.3f);
            shotSound.Play();
    }
}
