using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestItem1 : MonoBehaviour
{
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 180);
        transform.position += Vector3.up * Mathf.Sin(Time.time) * 0.001f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player1"))
        {
            other.gameObject.SendMessage("ItemCollected");
            audio.Play();
            Destroy(gameObject, .4f);
            Debug.Log(" player1 pegou item");
        }
    }
}
