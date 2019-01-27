using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ChangeImageLoco : MonoBehaviour, IPointerClickHandler
{

    public Image image;
    public createclassimage.Image[] images;
    private createclassimage.Image pics;
    public Text idText;
    private SelectNmbPlayer.Player p;

    // Start is called before the first frame update
    void Start()

    {
        createclassimage.TabImage tab = createclassimage.getTabLoco();
        int x;
        int y;
        x = Random.Range(1, tab.getTaille());
        y = Random.Range(1, tab.getTaille());
        while (x == y)
        {
            y = Random.Range(1, tab.getTaille());
        }

        images = new createclassimage.Image[2];
        images[0] = tab.getImageind(x);
        images[1] = tab.getImageind(y);

        pics = images[0];
        
        p =  MainScriptsc1.Global.GetPlayer();
        ShowRandomImage(); 
    }

    void ShowRandomImage()
    {
        changetext((pics.getId().ToString()));
        p.setidcarte1 = pics.getId();
        image.sprite = pics.getSprite();
        image.enabled = true;   
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (pics == images[1])
        {
            pics = images[0];
            
        }
        else
        {
            pics = images[1];

        }
        ShowRandomImage();

    }
    
    public void changetext(String str)
    {
        idText.text = ("l'id de la carte sélectionnée est : "+str);
    }
    

}