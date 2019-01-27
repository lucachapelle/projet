using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createclassimage : MonoBehaviour
{
    public static TabImage tab;
    public class Image
    {
        private int id;
        private Sprite sprite;


        public Image(int id, Sprite sprite)
        {
            this.id = id;
            this.sprite = sprite;
        }

        public Sprite getSprite()
        {
            return this.sprite;
        }
        public int getId()
        {
            return this.id;
        }
    }

    public class TabImage
    {
        private int taille;
        private Image[] tabsprite;


        public TabImage()
        {
            tabsprite = new Image[50];
            this.taille = 0;
        }

        public void addImage(Image image)
        {
            tabsprite[taille] = image;
            taille++;
        }

        public Image getImageind(int i)
        {
            return this.tabsprite[i];
        }

        public int getTaille()
        {
            return this.taille;
        }
    }


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
    }

    public static TabImage getTabLoco()
    {
        initializeLoco();
        return tab;
    }

    private static void initializeLoco()
    {
        tab = new TabImage();
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/LocomotionDos")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Ailes")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Ballon")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Chenilles")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Flottaison")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Helices")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Pattes")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Rampant")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Rebondir")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Roues")));
    }
    
    public static TabImage getTabDi()
    {
        initializeDi();
        return tab;
    }

    private static void initializeDi()
    {
        tab = new TabImage();
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/DosDimension")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/GrandeCapacite")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/GrandVegiculeLourd")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/GrandVehiculeIntermediaire")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/Monoplace")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/PetitRobot")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/TresGrandeCapacite")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/VehiculeIntermediaire")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/VehiculeLeger")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/VehiculeLourd")));
    }
    
     public static TabImage getTabEqui()
        {
            initializeEqui();
            return tab;
        }
     
    public static void initializeEqui()
    {
        tab = new TabImage();
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/EquipementDos.png")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/AppelUrgence")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/BrasArticules")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/CameraThermique")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/CanonPeinture")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/CarrosserieReflechissante")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/CentraleRecyclage")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/CoffreBlinde")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/CommandeVocale")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/ConnexionVPN")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/Couchettes")));
    }
}