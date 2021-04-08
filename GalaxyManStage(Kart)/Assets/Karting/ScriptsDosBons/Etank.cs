using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Etank : MonoBehaviour
{
    public GameObject Egirl;
    public GameObject KartClassic_Player;
    public GameObject KartClassic_Player1;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            {
            GameObject go = Instantiate(Egirl, KartClassic_Player.transform.position + KartClassic_Player.transform.forward * 1, KartClassic_Player.transform.rotation);
            go.GetComponent<Rigidbody>().velocity = KartClassic_Player.transform.forward * 0;
            Destroy(go.gameObject, 1000f);
            //Debug.Log("Atirou Casco");
        }
        if (Input.GetKeyDown(KeyCode.F))
            {
            GameObject go2 = Instantiate(Egirl, KartClassic_Player1.transform.position + KartClassic_Player1.transform.forward * 1, KartClassic_Player1.transform.rotation);
            go2.GetComponent<Rigidbody>().velocity = KartClassic_Player1.transform.forward * 0;
            Destroy(go2.gameObject, 1000f);
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
    
