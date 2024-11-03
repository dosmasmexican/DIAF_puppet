using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerStat : MonoBehaviour
{
    public TextAsset textAssetData;

    [Serializable]

    public class player
    {
        public string name;
        public int health;
        public int damage;
        public int defence;
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
        int tableSize = data.Length / 4 - 1;
        myPlayerList.player = new player[tableSize];

        for (int i = 0; i < tableSize; i++)
        {
            myPlayerList.player[i] = new player();
            myPlayerList.player[i].name = data[4 * (i + 1)];
            myPlayerList.player[i].health = int.Parse(data[4 * (i + 1)+1]);
            myPlayerList.player[i].damage = int.Parse(data[4 * (i + 1)+2]);
            myPlayerList.player[i].defence = int.Parse(data[4 * (i + 1)+3]);
        }
    }
}
