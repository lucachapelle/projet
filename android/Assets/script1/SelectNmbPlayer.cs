using System;
using System.Collections;
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

    public static Player p1 = new Player();
    public static Player p2 = new Player();
    public static Player p3 = new Player();
    public static Player p4 = new Player();
    public static Player p5 = new Player();
    public static Player p6 = new Player();

    // Start is called before the first frame update
    public class Player
    {
        private int id;
        private int isSelect;
        private int idcarte1;
        private int idcarte2;
        private int idcarte3;
        private int isOk;

        public Player(int id, int isSelect, int idcarte1, int idcarte2, int idcarte3, int isOk)
        {
            this.id = id;
            this.isSelect = isSelect;
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
        p1 = new Player(int.Parse(data[0]), int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]),
            int.Parse(data[4]), int.Parse(data[5]));
        p2 = new Player(int.Parse(data[6]), int.Parse(data[7]), int.Parse(data[8]), int.Parse(data[9]),
            int.Parse(data[10]), int.Parse(data[11]));
        p3 = new Player(int.Parse(data[12]), int.Parse(data[13]), int.Parse(data[14]), int.Parse(data[15]),
            int.Parse(data[16]), int.Parse(data[17]));
        p4 = new Player(int.Parse(data[18]), int.Parse(data[19]), int.Parse(data[20]), int.Parse(data[21]),
            int.Parse(data[22]), int.Parse(data[23]));
        p5 = new Player(int.Parse(data[24]), int.Parse(data[25]), int.Parse(data[26]), int.Parse(data[27]),
            int.Parse(data[28]), int.Parse(data[29]));
        p6 = new Player(int.Parse(data[30]), int.Parse(data[31]), int.Parse(data[32]), int.Parse(data[33]),
            int.Parse(data[34]), int.Parse(data[35]));

        //Debug.Log("player 1 " +p1.ToString());
        //Debug.Log("player 2 " +p2.ToString());
        //Debug.Log("player 3 " +p3.ToString());
        //Debug.Log("player 4 " +p4.ToString());
        //Debug.Log("player 5 " +p5.ToString());
        //Debug.Log("player 6 " +p6.ToString());
    }

    private void requette()
    {
        StartCoroutine(userInfo());
    }
}