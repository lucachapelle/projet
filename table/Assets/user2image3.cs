using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class user2image3 : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    private Sprite pics;
    public Image image;

    private Sprite[] sprite;

    private Sprite[] tab;

    // Start is called before the first frame update
    void Start()
    {
        sprite = User2main.getSpritee();
        tab = new Sprite[2];
        int x;
        int y;
        x = Random.Range(1, sprite.Length);
        y = Random.Range(1, sprite.Length);
        while (x == y)
        {
            y = Random.Range(1, sprite.Length);

        }

        tab[0] = sprite[x];
        tab[1] = sprite[y];

        pics = tab[0];
        ShowRandomImage();

    }

    void ShowRandomImage()
    {

        image.sprite = pics;
        image.enabled = true;
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        if (pics == tab[1])
        {
            pics = tab[0];

        }
        else
        {
            pics = tab[1];

        }

        ShowRandomImage();
    }
}
