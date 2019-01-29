using System;
using System.Collections;
using System.Xml.Linq;
using UnityEngine;

public class Main : MonoBehaviour
{
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
            this.place = 0;
            this.idcarte1 = 0;
            this.idcarte2 = 0;
            this.idcarte3 = 0;
            this.isOk = 0;
        }

        public int Id => id;
        public int IsSelect => isSelect;
        public int Place => place;
        public int Idcarte1 => idcarte1;
        public int Idcarte2 => idcarte2;
        public int Idcarte3 => idcarte3;

        public int GetIsOk()
        {
            return isOk;
        }


        public int setid
        {
            get => id;
            set => id = value;
        }

        public int setisSelect
        {
            get => isSelect;
            set => isSelect = value;
        }

        public int setplace
        {
            get => place;
            set => place = value;
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
            return "" + this.id + this.isSelect + this.Place + this.idcarte1 + this.idcarte2 + this.idcarte3 +
                   this.isOk;
        }
    }

    public class Global
    {
        public static Player[] tabPlayer;
        private static int nbjoueur;

        public Global()
        {
            tabPlayer = new Main.Player[7];
            nbjoueur = 0;
        }

        public static Player[] GetPlayer()
        {
            return tabPlayer;
        }

        public static int Getnbjoueur()
        {
            return nbjoueur;
        }

        public void SetPlayer(Player[] p)
        {
            tabPlayer = p;
        }

        public static void Setnbjoueur(int i)
        {
            nbjoueur = i;
        }

        public static string ToString()
        {
            string res = "";
            for (int i = 1; i < 7; i++)
            {
                res = res + GetPlayer()[i].ToString() + " ; ";
            }

            return res;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Global g = new Global();
        StartCoroutine(userInfo());
    }

    // Update is called once per frame
    void Update()
    {
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
            Global.tabPlayer[i] = new Player(int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]),
                int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]));
    
        }

    }
}