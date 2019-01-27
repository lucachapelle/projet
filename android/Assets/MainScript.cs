using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    public SelectNmbPlayer.Player player;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        player = MainScriptsc1.Global.GetPlayer();
//        Debug.Log(player.ToString());
        text.text = "Le player selectionné est :" + player.Id;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
