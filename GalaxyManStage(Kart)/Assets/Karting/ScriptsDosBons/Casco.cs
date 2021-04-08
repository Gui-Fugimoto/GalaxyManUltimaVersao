using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casco : MonoBehaviour
{
    public GameObject MetCasco64;
    public GameObject KartClassic_Player;
    public GameObject KartClassic_Player1;

    public float shootVelocity = 30;

    void Start()
    {
        //KartClassic_Player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(MetCasco64, KartClassic_Player.transform.position + KartClassic_Player.transform.forward * 3, KartClassic_Player.transform.rotation);
            go.GetComponent<Rigidbody>().velocity = KartClassic_Player.transform.forward * shootVelocity;
            Destroy(go.gameObject, 3f);
            //Debug.Log("Atirou Casco");
        }
        if (Input.GetMouseButtonDown(1))
        {
            GameObject go2 = Instantiate(MetCasco64, KartClassic_Player1.transform.position + KartClassic_Player1.transform.forward * 3, KartClassic_Player1.transform.rotation);
            go2.GetComponent<Rigidbody>().velocity = KartClassic_Player1.transform.forward * shootVelocity;
            Destroy(go2.gameObject, 3f);
            //Debug.Log("Atirou Casco");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player")) 
        {
            Destroy(gameObject, 0.1f);
            //Debug.Log("acertou player");

        }
        if (other.gameObject.tag.Equals("Player1"))
        {
            Destroy(gameObject, 0.1f);
            //Debug.Log("acertou player1");
        }
    }
}
