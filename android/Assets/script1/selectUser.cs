using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class selectUser : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    public int i;
    public Scene scene;
    private MainScriptsc1.Global g;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        button.onClick.AddListener(() => ButtonClicked(i));
    }    
    
    void ButtonClicked(int i)
    {
        g = new MainScriptsc1.Global();
        //Output this to console when the Button3 is clicked
        switch (i)
        {
            case 1:
                g.SetPlayer(SelectNmbPlayer.p1);
                break;
            case 2:
                g.SetPlayer(SelectNmbPlayer.p2);                
                break;
            case 3:
                g.SetPlayer(SelectNmbPlayer.p3);                
                break;
            case 4:
                g.SetPlayer(SelectNmbPlayer.p4);                
                break;
            case 5:
                g.SetPlayer(SelectNmbPlayer.p5);                
                break;
            case 6:
                g.SetPlayer(SelectNmbPlayer.p6);                
                break;
            default:
                print ("Prob");
                break;
        }
        StartCoroutine(selectPlayer(i));
        SceneManager.LoadScene(scene.handle);
    }

    IEnumerator selectPlayer(int i)
    {
        WWWForm form = new WWWForm();
        form.AddField("id",i);
        WWW www = new WWW("https://primsie-spears.000webhostapp.com/estSelect.php",form);
        yield return www;
    }
}

