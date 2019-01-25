using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testbdd : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    private int i = 1;
    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        button.onClick.AddListener(() => ButtonClicked(i));
        
    }    
    
    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        StartCoroutine(test());
       
    }

    IEnumerator test()
    {
        WWWForm form = new WWWForm();
        form.AddField("id",2);
        WWW www = new WWW("https://primsie-spears.000webhostapp.com/test.php",form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("Il n y a pas de probleme");

        }
        else
        {
            Debug.Log("error"+www.text);

        }
    }
 }
