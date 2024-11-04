using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEditor;

public class PlayerStat : MonoBehaviour
{
    public TextAsset textAssetData;

    [Serializable]

    public class player
    {
        public string name;
        public int HP;
        public int ATK;
        public int SPD;
        public int DEF;
        public int STA;
    }

    [Serializable]

    public class PlayerList
    {
        public player[] player;
    }

    public PlayerList myPlayerList = new PlayerList();

    // Start is called before the first frame update
    void Start()
    {
        ReadCSV();
    }

    // Update is called once per frame
    void ReadCSV()
    {
        String[] data = textAssetData.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
        int tableSize = data.Length / 6 - 1;
        myPlayerList.player = new player[tableSize];

        for (int i = 0; i < tableSize; i++)
        {
            myPlayerList.player[i] = new player();
            myPlayerList.player[i].name = data[6 * (i + 1)];
            myPlayerList.player[i].HP = int.Parse(data[6 * (i + 1) + 1]);
            myPlayerList.player[i].ATK = int.Parse(data[6 * (i + 1) + 2]);
            myPlayerList.player[i].SPD = int.Parse(data[6 * (i + 1) + 3]);
            myPlayerList.player[i].DEF = int.Parse(data[6 * (i + 1) + 4]);
            myPlayerList.player[i].STA = int.Parse(data[6 * (i + 1) + 5]);
        }
    }
}
