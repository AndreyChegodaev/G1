using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool firstPlaythrough = true;
    public bool onTree = false;
    public bool hasFork = false;
    public bool hasFinger = false;
    public int dejaVu = 0;
    public bool visitedWitch = false;
    public bool hasChalk = false;
    public bool killedByWitch = false;
    public bool crossedRavine = false;
    public bool setHomeFromTower = false;
    public int waitAtTheDoor = 0;
    public bool keptTheRing = false;
    public bool heardVoice = false;
    public bool fakeEnding = false;
    public bool trueEnding = false;

    public enum ActivePicture
    {
        nothing,
        bad_tower,
        bad_ash,
        ok_back,
        ok_tower_man,
        goodish,
    }
    public ActivePicture activePicture;

    public bool settings_CCSwitch = false;

    private void Awake()
    {
        instance = this;
    }

    public void FirstPlaytroughDone()
    {
        SaveManager.instance.activeSave.firstPlaytrough = false;
        firstPlaythrough = false;
    }
    
    public void OnTree()
    {
        SaveManager.instance.activeSave.onTree = true;
        onTree = true;
    }
    public void HasFork()
    {
        SaveManager.instance.activeSave.hasFork = true;
        hasFork = true;
    }
    public void HasFinger()
    {
        SaveManager.instance.activeSave.hasFinger = true;
        hasFinger = true;
    }
    public void DejaVu()
    {
        SaveManager.instance.activeSave.dejaVu++;
        dejaVu++;
    }
    public void VisitedWitch()
    {
        SaveManager.instance.activeSave.visitedWitch = true;
        visitedWitch = true;
    }
/*    public void HasChalk()
    {
        SaveManager.instance.activeSave.hasChalk = true;
        hasChalk = true;
    }*/ //no need -> use HasFinger instead
    public void KilledByWitch()
    {
        SaveManager.instance.activeSave.killedByWitch = true;
        killedByWitch = true;
    }
    public void CrossedRavine()
    {
        SaveManager.instance.activeSave.crossedRavine = true;
        crossedRavine = true;
    }
    public void SetHomeFromTower()
    {
        SaveManager.instance.activeSave.setHomeFromTower = true;
        setHomeFromTower = true;
    }
    public void WaitAtTheDoor()
    {
        SaveManager.instance.activeSave.waitAtTheDoor++;
        waitAtTheDoor++;
    }
    public void KeptTheRing()
    {
        SaveManager.instance.activeSave.keptTheRing = true;
        keptTheRing = true;
    }
    public void HeardVoice()
    {
        SaveManager.instance.activeSave.heardVoice = true;
        heardVoice = true;
    }
    public void FakeEnding()
    {
        SaveManager.instance.activeSave.fakeEnding = true;
        fakeEnding = true;
    }
    public void TrueEnding()
    {
        SaveManager.instance.activeSave.trueEnding = true;
        trueEnding = true;        
    }

    public void SetActivePictureBad()
    {
        if (killedByWitch == true)
        {
            SaveManager.instance.activeSave.activePicture = SaveData.ActivePicture.bad_ash;
            activePicture = ActivePicture.bad_ash;
        }

        else
        {
            SaveManager.instance.activeSave.activePicture = SaveData.ActivePicture.bad_tower;
            activePicture = ActivePicture.bad_tower;
        }      
    }

    public void SetActivePictureOk()
    {
        if (keptTheRing == true)
        {
            SaveManager.instance.activeSave.activePicture = SaveData.ActivePicture.ok_tower_man;
            activePicture = ActivePicture.ok_tower_man;
        }

        else 
        {
            SaveManager.instance.activeSave.activePicture = SaveData.ActivePicture.ok_back;
            activePicture = ActivePicture.ok_back;
        }
    }

    public void SetActivePictureGoodish()
    {
            SaveManager.instance.activeSave.activePicture = SaveData.ActivePicture.goodish;
            activePicture = ActivePicture.goodish;
    }

    //This method is applied when a new game is started
    public void StartNewGame()
    {
        SaveManager.instance.activeSave.currentLevel = "Page1";

       // to restart this parameter with all of the others - use "WipeAllProgress" method
        //SaveManager.instance.activeSave.firstPlaytrough = true;
        //firstPlaythrough = true;

        SaveManager.instance.activeSave.onTree = false;
        onTree = false;

        SaveManager.instance.activeSave.hasFork = false;
        hasFork = false;

        SaveManager.instance.activeSave.hasFinger = false;
        hasFinger = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        dejaVu = 0;

        SaveManager.instance.activeSave.visitedWitch = false;
        visitedWitch = false;


        SaveManager.instance.activeSave.killedByWitch = false;
        killedByWitch = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        crossedRavine = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        waitAtTheDoor = 0;

        SaveManager.instance.activeSave.keptTheRing = false;
        keptTheRing = false;

        SaveManager.instance.activeSave.heardVoice = false;
        heardVoice = false;

        SaveManager.instance.Save();
    }

    public void WipeAllProgress()
    {
        SaveManager.instance.activeSave.currentLevel = "Page1";

        SaveManager.instance.activeSave.firstPlaytrough = true;
        firstPlaythrough = true;

        SaveManager.instance.activeSave.onTree = false;
        onTree = false;

        SaveManager.instance.activeSave.hasFork = false;
        hasFork = false;

        SaveManager.instance.activeSave.hasFinger = false;
        hasFinger = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        dejaVu = 0;

        SaveManager.instance.activeSave.visitedWitch = false;
        visitedWitch = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        killedByWitch = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        crossedRavine = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        waitAtTheDoor = 0;

        SaveManager.instance.activeSave.keptTheRing = false;
        keptTheRing = false;

        SaveManager.instance.activeSave.heardVoice = false;
        heardVoice = false;
        
        SaveManager.instance.activeSave.fakeEnding = false;
            fakeEnding = false;
        
        SaveManager.instance.activeSave.trueEnding = false;
            trueEnding = false;

        activePicture = ActivePicture.nothing;
        SaveManager.instance.activeSave.activePicture = SaveData.ActivePicture.nothing;

        SaveManager.instance.Save();
    }

    public void Settings_CCSwitch()
    {
        SaveManager.instance.activeSave.settings_CCSwitch = !SaveManager.instance.activeSave.settings_CCSwitch;
        settings_CCSwitch = !settings_CCSwitch;

    }

}

