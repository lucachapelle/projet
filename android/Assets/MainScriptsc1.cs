using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScriptsc1 : MonoBehaviour
{
    public class Global
    {
        private static SelectNmbPlayer.Player player;


        public Global()
        {
            player = new SelectNmbPlayer.Player();
        }
        public static void SetPlayer(SelectNmbPlayer.Player p)
        {
            player = p;
        }

        public static SelectNmbPlayer.Player GetPlayer()
        {
            return player;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

}
