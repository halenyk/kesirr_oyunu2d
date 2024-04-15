using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class gameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject KareNesne;

    [SerializeField]
    private Transform karelerPaneli;

    private GameObject[] karelerDizisi = new GameObject[25];

    string hangiislem;




    void Start()
    {
        soruyuSor();
        KareleriOlustur();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void soruyuSor()
    {
        switch(hangiislem)
        {
            case "toplama":

                break;

            case "cikarma":

                break;
        }
    }
    public void KareleriOlustur()
    {
        for(int i = 0; i<25; i++)
        {
            GameObject kare = Instantiate(KareNesne, karelerPaneli);
            karelerDizisi[i] = kare;
        }
    }



}
