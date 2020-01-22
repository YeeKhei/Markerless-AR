using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        GameObject explosion = Instantiate(Resources.Load("DustExplosion", typeof(GameObject))) as GameObject;
        explosion.transform.position = transform.position;
        Destroy(other.gameObject);
        Destroy(explosion, 2);

        if(GameObject.FindGameObjectsWithTag("Player").Length==0)
        {
            GameObject enemy1=Instantiate(Resources.Load("enemy 1",typeof(GameObject)))as GameObject;
            GameObject enemy2=Instantiate(Resources.Load("enemy 2",typeof(GameObject)))as GameObject;
            GameObject enemy3=Instantiate(Resources.Load("enemy 3",typeof(GameObject)))as GameObject;
            GameObject enemy4=Instantiate(Resources.Load("enemy 4",typeof(GameObject)))as GameObject;
        }
        Destroy(gameObject);
    }
}
