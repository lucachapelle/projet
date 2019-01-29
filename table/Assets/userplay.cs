using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class userplay : MonoBehaviour
{
    // Start is called before the first frame update
    public Button buttonuser;
    void Start()
    {
        buttonuser.onClick.AddListener(() => ButtonClicked());

    }

    // Update is called once per frame
   void ButtonClicked()
       {

           SceneManager.LoadScene("1ere scene jeu");
       }

}
