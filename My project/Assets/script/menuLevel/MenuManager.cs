using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private GameObject toplamaButton,cikarmaButton,cikisButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameLevel(string hangiislem)
    {
        PlayerPrefs.SetString("hangi��lem",hangiislem);
        SceneManager.LoadScene("gameLevel");
    }

    public void oyundanC�k()
    {
        Application.Quit();
    }
}
