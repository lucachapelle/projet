using System;
using System.Collections;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SelectNmbPlayer : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;

    public static Player p1 ;
    public static Player p2 ;
    public static Player p3 ;
    public static Player p4 ;
    public static Player p5 ;
    public static Player p6 ;

    static Player[] tabPlayer;

    // Start is called before the first frame update
    public class Player
    {
        private int id;
        private int isSelect;
        private int place;
        private int idcarte1;
        private int idcarte2;
        private int idcarte3;
        private int isOk;

        public Player(int id, int isSelect, int place, int idcarte1, int idcarte2, int idcarte3, int isOk)
        {
            this.id = id;
            this.isSelect = isSelect;
            this.place = place;
            this.idcarte1 = idcarte1;
            this.idcarte2 = idcarte2;
            this.idcarte3 = idcarte3;
            this.isOk = isOk;
        }

        public Player()
        {
            this.id = 0;
            this.isSelect = 0;
            this.idcarte1 = 0;
            this.idcarte2 = 0;
            this.idcarte3 = 0;
            this.isOk = 0;
        }

        public int Id => id;

        public int IsSelect => isSelect;

        public int Idcarte1 => idcarte1;

        public int Idcarte2 => idcarte2;

        public int Idcarte3 => idcarte3;

        public int IsOk => isOk;

        public int settid
        {
            get => id;
            set => id = value;
        }

        public int setisSelect
        {
            get => isSelect;
            set => isSelect = value;
        }

        public int setidcarte1
        {
            get => idcarte1;
            set => idcarte1 = value;
        }

        public int setidcarte2
        {
            get => idcarte2;
            set => idcarte2 = value;
        }

        public int setidcarte3
        {
            get => idcarte3;
            set => idcarte3 = value;
        }

        public int setisOk
        {
            get => isOk;
            set => isOk = value;
        }

        public String ToString()
        {
            return "" + this.id + this.isSelect + this.idcarte1 + this.idcarte2 + this.idcarte3 + this.isOk;
        }
    }

    void Start()
    {
        InvokeRepeating("requette", 0f, 1f);
        p1 = new Player();
        p2 = new Player();
        p3 = new Player();
        p4 = new Player();
        p5 = new Player();
        p6 = new Player();
        tabPlayer = new Player[7]{null,p1,p2,p3,p4,p5,p6};
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        button1.interactable = p1.setisSelect != 1;
        button2.interactable = p2.setisSelect != 1;
        button3.interactable = p3.setisSelect != 1;
        button4.interactable = p4.setisSelect != 1;
        button5.interactable = p5.setisSelect != 1;
        button6.interactable = p6.setisSelect != 1;
    }

    private static IEnumerator userInfo()
    {
        

    WWWForm logform = new WWWForm();
        var www = new WWW("https://primsie-spears.000webhostapp.com/select.php", logform);
        yield return www;

        string[] data = www.text.Split(new string[] {","}, System.StringSplitOptions.None);
        int x = 0;
        
        for (int i = 1; i < 7; i++)
        {
            tabPlayer[i] = new Player(int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]),
                int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]));
    
        }

    }

    private void requette()
    {
        StartCoroutine(userInfo());
    }

    public static Player  getPlayer(int i)
    {
        return tabPlayer[i]; 
    }
}