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
           StartCoroutine(init());
           SceneManager.LoadScene("1ere scene jeu");
       }
   IEnumerator init()
   {
       WWWForm form = new WWWForm();
       WWW www = new WWW("https://primsie-spears.000webhostapp.com/init.php",form);
       yield return www;
   }
}
