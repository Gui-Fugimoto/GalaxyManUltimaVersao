using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemHUD1 : MonoBehaviour
{
   
    [SerializeField]
    public Image customImage4;
    public Image customImage5;
    public Image customImage6;


    //public int AllItemGraphics;
    [SerializeField]
    private int rand;


    public Sprite[] Sprite_Pic;


    //private bool shuffleSprite;
    //public float TimeBtwShuffle;
    //public Image[] AllItemGraphics;
    //public Sprite EmptyItem;

    //public Image Img;



    private void Start()
    {
        rand = Random.Range(0, 3);
        //GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand];Sprite_Pic.Length
        //shuffleSprite = false;
    }

    void OnTriggerEnter(Collider other)
    {
        int rand = Random.Range(0, 3);
        if (other.CompareTag("Player1"))
        {
            //GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand];
            if (rand == 0)
            {
                customImage4.enabled = true;
               // customImage2.enabled = false;
               // customImage3.enabled = false;
            }

            if (rand == 1)
            {
                //customImage.enabled = false;
                customImage5.enabled = true;
               // customImage3.enabled = false;
            }

            if (rand == 2)
            {
               // customImage.enabled = false;
               // customImage2.enabled = false;
                customImage6.enabled = true;
            }
            //AllItemGraphics[Random.Range(0, 2)];
            //shuffleSprite = true;
            //customImage.enabled = true;
            //if (int = 0)if (rnd == 0)
            // {
            //    customImage.enabled = true;
            //}
            //if (rand i = 1)
            //{
            //  customImage.enabled = true;

            // }

        }

    }

    //void Shuffle()
    //{

    //}

}
