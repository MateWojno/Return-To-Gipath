using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml; //to read xml
using System.Threading.Tasks;
using UnityEngine;
//1 what those extensions are?

private  class Code : MonoBehaviour


private void Quests() //container of data & some ideas
{
    public bool questEligibility; //check for player lvl and finished quests in order to give specific quest
    public bool questCheckTitle; //self explanatory
    public int questChoosenPath; //player may follow diff paths

    public int questID;  //id of quest, from 0 to 400 for example
    public int questLocationID; //which location/map is quest designed for?
    public int questNpcID; //which NPC gives you the quest?
    public int questNpcLocationID; //where this NPC is?

    public string questTxtShort; //what is the short txt of quest?
    public string questDialog; //dialog phrases
    public string questNextTxt; //txt for next quest from chain
    
    public string questObjectives; //self explanatory
    public bool questHasKey; //SE
    public int questEnemyID; //boss'ish enemy to kill or...?
    public int questItemID; //item to obtain

    public bool questFinished; //check if player finished the quest
    public string questReward; //as above
    public string questRewardTitle; //after finishing main quests you gain title - it unlocks some content;

}

void ReadDatabase()
{
    //reads data form database and checks with Quests method
}


void LOD()
{
    //level of difficulty
    public int questMapSeed; //seed for map generator to generate some differences in those maps;
    public bool questMapBuff; //is map buffed?
    public float questDropInc; //SE - self explanatory
    public float questExpInc; //SE
}
