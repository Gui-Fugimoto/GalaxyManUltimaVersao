using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoHold : MonoBehaviour
{
    public GameObject Tornad;
    public GameObject KartClassic_Player;
    public GameObject KartClassic_Player1;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject dota = Instantiate(Tornad, KartClassic_Player.transform.position + KartClassic_Player.transform.forward * -2, KartClassic_Player.transform.rotation);
            dota.GetComponent<Rigidbody>().velocity = KartClassic_Player.transform.forward * 0;
            Destroy(dota.gameObject, 2000f);
            Debug.Log("Atirou Tornado");
            
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            GameObject dota = Instantiate(Tornad, KartClassic_Player1.transform.position + KartClassic_Player1.transform.forward * -2, KartClassic_Player1.transform.rotation);
            dota.GetComponent<Rigidbody>().velocity = KartClassic_Player1.transform.forward * 0;
            Destroy(dota.gameObject, 2000f);
            Debug.Log("Atirou Tornado");
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       
        
        if (other.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject, 0.1f);
            audio.Play();
            Debug.Log("Colidiu");

        }
        if (other.gameObject.tag.Equals("Player1"))
        {
            Destroy(gameObject, 0.1f);
            audio.Play();
            Debug.Log("Colidiu");

        }
    }
}
