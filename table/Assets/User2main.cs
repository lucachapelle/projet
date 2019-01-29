using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class User2main : MonoBehaviour
{
    public static Sprite picl0;
    public static Sprite picl1;
    public static Sprite picl2;
    public static Sprite picl3;
    public static Sprite picl4;
    public static Sprite picl5;
    public static Sprite picl6;
    public static Sprite picl7;
    public static Sprite picl8;
    public static Sprite picl9;

    public static Sprite picd0;
    public static Sprite picd1;
    public static Sprite picd2;
    public static Sprite picd3;
    public static Sprite picd4;
    public static Sprite picd5;
    public static Sprite picd6;
    public static Sprite picd7;
    public static Sprite picd8;
    public static Sprite picd9;
    
    public static Sprite pice0;
    public static Sprite pice1;
    public static Sprite pice2;
    public static Sprite pice3;
    public static Sprite pice4;
    public static Sprite pice5;
    public static Sprite pice6;
    public static Sprite pice7;
    public static Sprite pice8;
    public static Sprite pice9;

    public Image imagep11;
    public Image imagep12;
    public Image imagep13;
    public Image imagep14;
    public Image imagep15;

    public Image imagep21;
    public Image imagep22;
    public Image imagep23;
    public Image imagep24;
    public Image imagep25;

    public Image imagep31;
    public Image imagep32;
    public Image imagep33;
    public Image imagep34;
    public Image imagep35;
    
    public Image imagep41;
    public Image imagep42;
    public Image imagep43;
    public Image imagep44;
    public Image imagep45;
    
    public Image imagep51;
    public Image imagep52;
    public Image imagep53;
    public Image imagep54;
    public Image imagep55;
    
    public Image imagep61;
    public Image imagep62;
    public Image imagep63;
    public Image imagep64;
    public Image imagep65;

    public Text textp1;
    public Text textp2;
    public Text textp3;
    public Text textp4;
    public Text textp5;
    public Text textp6;
    
    public int[] tabPlace;
    

    public Image[] imagetab;
    public Image[] imagetab1;
    private Text[] texTab;
    public Vector2[] vector2;

    public static Sprite[] picl;
    public static Sprite[] picd;
    public static Sprite[] pice;

    void Start()
    {    
        imagetab = new Image[31];
        texTab = new Text[7]{null,textp1,textp2,textp3,textp4,textp5,textp6};
        int x = 1;
        tabPlace = new int[7]{0,1,1,1,1,1,1};
        if (b1.estselec != 1)
        {       
            Destroy(imagep11);
            Destroy(imagep12);
            Destroy(imagep13);
            Destroy(imagep14);
            Destroy(imagep15);
            tabPlace[1] = 0;
            Destroy(textp1);
        }
        else
        {
                imagetab[x++] = imagep11;
                imagetab[x++] = imagep12;
                imagetab[x++] = imagep13;
                imagetab[x++] = imagep14;
                imagetab[x++] = imagep15;
        }




        if (b2.estselec != 1)
        {
            Destroy(imagep21);
            Destroy(imagep22);
            Destroy(imagep23);
            Destroy(imagep24);
            Destroy(imagep25);
            tabPlace[2] = 0;
            Destroy(textp2);
        }else
        {
            imagetab[x++] = imagep21;
            imagetab[x++] = imagep22;
            imagetab[x++] = imagep23;
            imagetab[x++] = imagep24;
            imagetab[x++] = imagep25;
        } 
           

        if (b3.estselec != 1)
        {
            Destroy(imagep31);
            Destroy(imagep32);
            Destroy(imagep33);
            Destroy(imagep34);
            Destroy(imagep35);
            tabPlace[3] = 0;
            Destroy(textp3);
        }else
        {
            imagetab[x++] = imagep31;
            imagetab[x++] = imagep32;
            imagetab[x++] = imagep33;
            imagetab[x++] = imagep34;
            imagetab[x++] = imagep35;
        } 

        if (b4.estselec != 1)
        {
            Destroy(imagep41);
            Destroy(imagep42);
            Destroy(imagep43);
            Destroy(imagep44);
            Destroy(imagep45);
            tabPlace[4] = 0;
            Destroy(textp4);
        }else
        {
            imagetab[x++] = imagep41;
            imagetab[x++] = imagep42;
            imagetab[x++] = imagep43;
            imagetab[x++] = imagep44;
            imagetab[x++] = imagep45;
        } 
        
        if (b5.estselec != 1)
        {
            Destroy(imagep51);
            Destroy(imagep52);
            Destroy(imagep53);
            Destroy(imagep54);
            Destroy(imagep55);
            tabPlace[5] = 0;
            Destroy(textp5);
        } else
        {
            imagetab[x++] = imagep51;
            imagetab[x++] = imagep52;
            imagetab[x++] = imagep53;
            imagetab[x++] = imagep54;
            imagetab[x++] = imagep55;
        }

        if (b6.estselec != 1)
        {            
            Destroy(imagep61);
            Destroy(imagep62);
            Destroy(imagep63);
            Destroy(imagep64);
            Destroy(imagep65);
            tabPlace[6] = 0;
            Destroy(textp6);
        }else
        
        {
            imagetab[x++] = imagep61;
            imagetab[x++] = imagep62;
            imagetab[x++] = imagep63;
            imagetab[x++] = imagep64;
            imagetab[x++] = imagep65;
        }

        int j = 1;
        for (int i = 1; i < 7; i++)
        {
            if (tabPlace[i] == 1)
            {
                Main.Global.GetPlayer()[j].setplace = i;
                j++;
            }
        }

        for (int i = 1; i < x; i++)
        {
            imagetab[i].enabled = false;
        }
        //Debug.Log(Main.Global.ToString());
        StartCoroutine(changePlace());
        init();
        init2();
        init3();
        
        InvokeRepeating("requette", 0f, 1f);

        
        
    }
    void FixedUpdate()
    {

    }

    public static Sprite[] getSpritel()
    {
        init();
        return picl;
    }

    public static Sprite[] getSprited()
    {
        init2();
        return picd;
    }
    
    public static Sprite[] getSpritee()
    {
        init3();
        return pice;
    }

    public static void init()
    {
        picl1 = Resources.Load<Sprite>("image/Locomotion/Ailes");
        picl2 = Resources.Load<Sprite>("image/Locomotion/Ballon");
        picl3 = Resources.Load<Sprite>("image/Locomotion/Chenilles");
        picl4 = Resources.Load<Sprite>("image/Locomotion/Flottaison");
        picl5 = Resources.Load<Sprite>("image/Locomotion/Helices");
        picl6 = Resources.Load<Sprite>("image/Locomotion/Pattes");
        picl7 = Resources.Load<Sprite>("image/Locomotion/Rampant");
        picl8 = Resources.Load<Sprite>("image/Locomotion/Rebondir");
        picl9 = Resources.Load<Sprite>("image/Locomotion/Roues");
        picl0 = Resources.Load<Sprite>("image/Locomotion/LocomotionDos");
        picl = new Sprite[10] {picl0,picl1, picl2, picl3, picl4, picl5, picl6, picl7, picl8, picl9};
    }

    public static void init2()
    {
        picd1 = Resources.Load<Sprite>("image/Dimension/GrandeCapacite");
        picd2 = Resources.Load<Sprite>("image/Dimension/GrandVegiculeLourd");
        picd3 = Resources.Load<Sprite>("image/Dimension/GrandVehiculeIntermediaire");
        picd4 = Resources.Load<Sprite>("image/Dimension/Monoplace");
        picd5 = Resources.Load<Sprite>("image/Dimension/PetitRobot");
        picd6 = Resources.Load<Sprite>("image/Dimension/TresGrandeCapacite");
        picd7 = Resources.Load<Sprite>("image/Dimension/VehiculeIntermediaire");
        picd8 = Resources.Load<Sprite>("image/Dimension/VehiculeLeger");
        picd9 = Resources.Load<Sprite>("image/Dimension/VehiculeLourd");
        picd0 = Resources.Load<Sprite>("image/Dimension/DosDimension");
        picd = new Sprite[10] {picd0,picd1, picd2, picd3, picd4, picd5, picd6, picd7, picd8, picd9};
    }
    
    public static void init3()
    {
        pice1 = Resources.Load<Sprite>("image/Equipements/AppelUrgence");
        pice2 = Resources.Load<Sprite>("image/Equipements/BrasArticules");
        pice3 = Resources.Load<Sprite>("image/Equipements/CameraThermique");
        pice4 = Resources.Load<Sprite>("image/Equipements/CanonPeinture");
        pice5 = Resources.Load<Sprite>("image/Equipements/CarrosserieReflechissante");
        pice6 = Resources.Load<Sprite>("image/Equipements/CentraleRecyclage");
        pice7 = Resources.Load<Sprite>("image/Equipements/CoffreBlinde");
        pice8 = Resources.Load<Sprite>("image/Equipements/CommandeVocale");
        pice9 = Resources.Load<Sprite>("image/Equipements/ConnexionVPN");
        pice0 = Resources.Load<Sprite>("image/Equipements/Couchettes");
        pice = new Sprite[10] {pice0,pice1, pice2, pice3, pice4, pice5, pice6, pice7, pice8, pice9};
    }
    IEnumerator changePlace()
    {
        WWWForm form = new WWWForm();
        form.AddField("user1",Main.Global.GetPlayer()[1].Place);
        form.AddField("user2",Main.Global.GetPlayer()[2].Place);
        form.AddField("user3",Main.Global.GetPlayer()[3].Place);
        form.AddField("user4",Main.Global.GetPlayer()[4].Place);
        form.AddField("user5",Main.Global.GetPlayer()[5].Place);
        form.AddField("user6",Main.Global.GetPlayer()[6].Place);

        WWW www = new WWW("https://primsie-spears.000webhostapp.com/changePlaceCarte.php",form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("ok");
        }
        else
        {
            Debug.Log("erroer"+www.text);
        }
    }
    
    IEnumerator checkestok()
    {
        WWWForm logform = new WWWForm();
        var www = new WWW("https://primsie-spears.000webhostapp.com/select.php", logform);
        yield return www;

        string[] data = www.text.Split(new string[] {","}, System.StringSplitOptions.None);
        int x = 0;
        
        for (int i = 1; i < 7; i++)
        {
            Main.Global.tabPlayer[i] = new Main.Player(int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]),
                int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]));
        }
    }

    
    private void requette()
    {
        
        StartCoroutine(checkestok());
        if (Main.Global.GetPlayer()[1].GetIsOk() == 1)
        {
            texTab[Main.Global.GetPlayer()[1].Place].enabled = false;
            imagetab[1].sprite = picl[ Main.Global.GetPlayer()[1].Idcarte1];
            imagetab[2].sprite = picd[ Main.Global.GetPlayer()[1].Idcarte2];
            imagetab[3].sprite = pice[ Main.Global.GetPlayer()[1].Idcarte3];
        }
        if (Main.Global.GetPlayer()[2].GetIsOk() == 1)
        {
            texTab[Main.Global.GetPlayer()[2].Place].enabled = false;
            imagetab[6].sprite = picl[ Main.Global.GetPlayer()[2].Idcarte1];
            imagetab[7].sprite = picd[ Main.Global.GetPlayer()[2].Idcarte2];
            imagetab[8].sprite = pice[ Main.Global.GetPlayer()[2].Idcarte3];
        }
        if (Main.Global.GetPlayer()[3].GetIsOk() == 1)
        {
            texTab[Main.Global.GetPlayer()[3].Place].enabled = false;
            imagetab[11].sprite = picl[ Main.Global.GetPlayer()[3].Idcarte1];
            imagetab[12].sprite = picd[ Main.Global.GetPlayer()[3].Idcarte2];
            imagetab[13].sprite = pice[ Main.Global.GetPlayer()[3].Idcarte3];
        }
        if (Main.Global.GetPlayer()[4].GetIsOk() == 1)
        {
            texTab[Main.Global.GetPlayer()[4].Place].enabled = false;
            imagetab[16].sprite = picl[ Main.Global.GetPlayer()[4].Idcarte1];
            imagetab[17].sprite = picd[ Main.Global.GetPlayer()[4].Idcarte2];
            imagetab[18].sprite = pice[ Main.Global.GetPlayer()[4].Idcarte3];
        }
        if (Main.Global.GetPlayer()[5].GetIsOk() == 1)
        {
            texTab[Main.Global.GetPlayer()[5].Place].enabled = false;
            imagetab[21].sprite = picl[ Main.Global.GetPlayer()[5].Idcarte1];
            imagetab[22].sprite = picd[ Main.Global.GetPlayer()[5].Idcarte2];
            imagetab[23].sprite = pice[ Main.Global.GetPlayer()[5].Idcarte3];
        }
        if (Main.Global.GetPlayer()[6].GetIsOk() == 1)
        {
            texTab[Main.Global.GetPlayer()[6].Place].enabled = false;
            imagetab[26].sprite = picl[ Main.Global.GetPlayer()[6].Idcarte1];
            imagetab[27].sprite = picd[ Main.Global.GetPlayer()[6].Idcarte2];
            imagetab[28].sprite = pice[ Main.Global.GetPlayer()[6].Idcarte3];
            
        }

      
        int x = 6;                                                                                                    
        for (int i = 1; i < x; i++)
        {
            imagetab[i].enabled = Main.Global.GetPlayer()[1].GetIsOk() != 0;
        }
        
       x = 11 ;

        for (int i = 6; i < x; i++)
        {
            imagetab[i].enabled = Main.Global.GetPlayer()[2].GetIsOk() != 0; 
            
        }
        x = 16;

        for (int i = 11; i < x; i++)
        {
            imagetab[i].enabled = Main.Global.GetPlayer()[3].GetIsOk() != 0; 
        }
        x = 21;

        for (int i = 16; i < x; i++)
        {
            imagetab[i].enabled = Main.Global.GetPlayer()[4].GetIsOk() != 0; 
        }
        x = 26;
        if (Main.Global.Getnbjoueur() > 4)
        {
            for (int i = 21; i < x; i++)
            {
                imagetab[i].enabled = Main.Global.GetPlayer()[5].GetIsOk() != 0; 
            }
            x =31;
            if (Main.Global.Getnbjoueur() > 5)
            {
                for (int i = 26; i < x; i++)
                {
                    imagetab[i].enabled = Main.Global.GetPlayer()[6].GetIsOk() != 0;
                }
            }
        }
        
    }
}