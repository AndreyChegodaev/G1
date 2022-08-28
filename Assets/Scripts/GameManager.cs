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
    public bool settings_MusicSwitch = true;
    public bool settings_VoiceSwitch = true;
    public bool settings_WelcomePopUp = true;
    public bool settings_FullIntro;


    public bool f1B_Unlocked = false;
    public bool f3O_1_Unlocked = false;
    public bool f3O_2_Unlocked = false;
    public bool f3O_3_Unlocked = false;
    public bool f4G_Unlocked = false;
    public bool f5T_Unlocked = false;
    public bool page1_Unlocked = true; //level 1
    public bool page2_Unlocked = false;
    public bool page35_Unlocked = false;
    public bool page3A_Unlocked = false;
    public bool page3B_Unlocked = false;
    public bool page3C_Unlocked = false;
    public bool page4_Unlocked = false;
    public bool page55A_Unlocked = false;
    public bool page55B_Unlocked = false;
    public bool page5_Unlocked = false;
    public bool page5v2_Unlocked = false;
    public bool page65A_Unlocked = false;
    public bool page6v1_Unlocked = false;
    public bool page6v2_Unlocked = false;
    public bool page7_Unlocked = false;
    public bool page8_Unlocked = false;
    public bool page9A_Unlocked = false;
    public bool page9B_Unlocked = false;
    public bool page9C_Unlocked = false;
    public bool page10_Unlocked = false;
    public bool page11A_Unlocked = false;
    public bool pS_Unlocked = false;
    public bool pF1B_Unlocked = false;
    public bool pF2B_Unlocked = false;
    public bool pF3O_1_Unlocked = false;
    public bool pF3O_2_Unlocked = false;
    public bool pF3O_3_Unlocked = false;
    public bool pF4G_Unlocked = false;
    public bool pF5T_Unlocked = false;


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

        SaveManager.instance.activeSave.f1B_Unlocked = false;
        f1B_Unlocked = false;
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        f3O_3_Unlocked = false;
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        f4G_Unlocked = false;
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        f5T_Unlocked = false;
        SaveManager.instance.activeSave.page1_Unlocked = true; //level 1
        page1_Unlocked = true;
        SaveManager.instance.activeSave.page2_Unlocked = false;
        page2_Unlocked = false;
        SaveManager.instance.activeSave.page35_Unlocked = false;
        page35_Unlocked = false;
        SaveManager.instance.activeSave.page3A_Unlocked = false;
        page3A_Unlocked = false;
        SaveManager.instance.activeSave.page3B_Unlocked = false;
        page3B_Unlocked = false;
        SaveManager.instance.activeSave.page3C_Unlocked = false;
        page3C_Unlocked = false;
        SaveManager.instance.activeSave.page4_Unlocked = false;
        page4_Unlocked = false;
        SaveManager.instance.activeSave.page55A_Unlocked = false;
        page55A_Unlocked = false;
        SaveManager.instance.activeSave.page55B_Unlocked = false;
        page55B_Unlocked = false;
        SaveManager.instance.activeSave.page5_Unlocked = false;
        page5_Unlocked = false;
        SaveManager.instance.activeSave.page5v2_Unlocked = false;
        page5v2_Unlocked = false;
        SaveManager.instance.activeSave.page65A_Unlocked = false;
        page65A_Unlocked = false;
        SaveManager.instance.activeSave.page6v1_Unlocked = false;
        page6v1_Unlocked = false;
        SaveManager.instance.activeSave.page6v2_Unlocked = false;
        page6v2_Unlocked = false;
        SaveManager.instance.activeSave.page7_Unlocked = false;
        page7_Unlocked = false;
        SaveManager.instance.activeSave.page8_Unlocked = false;
        page8_Unlocked = false;
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        page9A_Unlocked = false;
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        page9B_Unlocked = false;
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        page9C_Unlocked = false;
        SaveManager.instance.activeSave.page10_Unlocked = false;
        page10_Unlocked = false;
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        page11A_Unlocked = false;
        SaveManager.instance.activeSave.pS_Unlocked = false;
        pS_Unlocked = false;
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        pF1B_Unlocked = false;
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        pF2B_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        pF3O_3_Unlocked = false;
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        pF4G_Unlocked = false;
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        pF5T_Unlocked = false;

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

        SaveManager.instance.activeSave.f1B_Unlocked = false;
        f1B_Unlocked = false;
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        f3O_3_Unlocked = false;
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        f4G_Unlocked = false;
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        f5T_Unlocked = false;
        SaveManager.instance.activeSave.page1_Unlocked = true; //level 1
        page1_Unlocked = true;
        SaveManager.instance.activeSave.page2_Unlocked = false;
        page2_Unlocked = false;
        SaveManager.instance.activeSave.page35_Unlocked = false;
        page35_Unlocked = false;
        SaveManager.instance.activeSave.page3A_Unlocked = false;
        page3A_Unlocked = false;
        SaveManager.instance.activeSave.page3B_Unlocked = false;
        page3B_Unlocked = false;
        SaveManager.instance.activeSave.page3C_Unlocked = false;
        page3C_Unlocked = false;
        SaveManager.instance.activeSave.page4_Unlocked = false;
        page4_Unlocked = false;
        SaveManager.instance.activeSave.page55A_Unlocked = false;
        page55A_Unlocked = false;
        SaveManager.instance.activeSave.page55B_Unlocked = false;
        page55B_Unlocked = false;
        SaveManager.instance.activeSave.page5_Unlocked = false;
        page5_Unlocked = false;
        SaveManager.instance.activeSave.page5v2_Unlocked = false;
        page5v2_Unlocked = false;
        SaveManager.instance.activeSave.page65A_Unlocked = false;
        page65A_Unlocked = false;
        SaveManager.instance.activeSave.page6v1_Unlocked = false;
        page6v1_Unlocked = false;
        SaveManager.instance.activeSave.page6v2_Unlocked = false;
        page6v2_Unlocked = false;
        SaveManager.instance.activeSave.page7_Unlocked = false;
        page7_Unlocked = false;
        SaveManager.instance.activeSave.page8_Unlocked = false;
        page8_Unlocked = false;
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        page9A_Unlocked = false;
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        page9B_Unlocked = false;
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        page9C_Unlocked = false;
        SaveManager.instance.activeSave.page10_Unlocked = false;
        page10_Unlocked = false;
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        page11A_Unlocked = false;
        SaveManager.instance.activeSave.pS_Unlocked = false;
        pS_Unlocked = false;
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        pF1B_Unlocked = false;
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        pF2B_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        pF3O_3_Unlocked = false;
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        pF4G_Unlocked = false;
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        pF5T_Unlocked = false;
        SaveManager.instance.activeSave.settings_WelcomePopUp = true;
        settings_WelcomePopUp = true;


        SaveManager.instance.Save();
    }

    public void Settings_CCSwitch()
    {
        SaveManager.instance.activeSave.settings_CCSwitch = !SaveManager.instance.activeSave.settings_CCSwitch;
        settings_CCSwitch = !settings_CCSwitch;

    }

    public void Settings_MusicSwitch()
    {
        SaveManager.instance.activeSave.settings_MusicSwitch = !SaveManager.instance.activeSave.settings_MusicSwitch;
        settings_MusicSwitch = !settings_MusicSwitch;

    }

    public void Settings_VoiceSwitch()
    {
        SaveManager.instance.activeSave.settings_VoiceSwitch = !SaveManager.instance.activeSave.settings_VoiceSwitch;
        settings_VoiceSwitch = !settings_VoiceSwitch;

    }

    public void Settings_WelcomePopUp()
    {
        SaveManager.instance.activeSave.settings_WelcomePopUp = !SaveManager.instance.activeSave.settings_WelcomePopUp;
        settings_WelcomePopUp = !settings_WelcomePopUp;

    }

    public void Settings_FullIntro()
    {
        SaveManager.instance.activeSave.settings_FullIntro = !SaveManager.instance.activeSave.settings_FullIntro;
        settings_FullIntro = !settings_FullIntro;
        SaveManager.instance.Save();
    }




    public void F1B_Unlocked()
    {
        f1B_Unlocked = true;
        SaveManager.instance.activeSave.f1B_Unlocked = true;
    }

    public void F3O_1_Unlocked()
    {
        f3O_1_Unlocked = true;
        SaveManager.instance.activeSave.f3O_1_Unlocked = true;
    }
    public void F3O_2_Unlocked()
    {
        f3O_2_Unlocked = true;
        SaveManager.instance.activeSave.f3O_2_Unlocked = true;
    }
    public void F3O_3_Unlocked()
    {
        f3O_3_Unlocked = true;
        SaveManager.instance.activeSave.f3O_3_Unlocked = true;
    }

    public void F4G_Unlocked()
    {
        f4G_Unlocked = true;
        SaveManager.instance.activeSave.f4G_Unlocked = true;
    }
    public void F5T_Unlocked()
    {
        f5T_Unlocked = true;
        SaveManager.instance.activeSave.f5T_Unlocked = true;
    }
    public void Page1_Unlocked()
    {
        page1_Unlocked = true;
        SaveManager.instance.activeSave.page1_Unlocked = true;
    }
    public void Page2_Unlocked()
    {
        page2_Unlocked = true;
        SaveManager.instance.activeSave.page2_Unlocked = true;
    }
    public void Page35_Unlocked()
    {
        page35_Unlocked = true;
        SaveManager.instance.activeSave.page35_Unlocked = true;
    }
    public void Page3A_Unlocked()
    {
        page3A_Unlocked = true;
        SaveManager.instance.activeSave.page3A_Unlocked = true;
    }
    public void Page3B_Unlocked()
    {
        page3B_Unlocked = true;
        SaveManager.instance.activeSave.page3B_Unlocked = true;
    }
    public void Page3C_Unlocked()
    {
        page3C_Unlocked = true;
        SaveManager.instance.activeSave.page3C_Unlocked = true;
    }
    public void Page4_Unlocked()
    {
        page4_Unlocked = true;
        SaveManager.instance.activeSave.page4_Unlocked = true;
    }
    public void Page55A_Unlocked()
    {
        page55A_Unlocked = true;
        SaveManager.instance.activeSave.page55A_Unlocked = true;
    }
    public void Page55B_Unlocked()
    {
        page55B_Unlocked = true;
        SaveManager.instance.activeSave.page55B_Unlocked = true;
    }
    public void Page5_Unlocked()
    {
        page5_Unlocked = true;
        SaveManager.instance.activeSave.page5_Unlocked = true;
    }
    public void Page5v2_Unlocked()
    {
        page5v2_Unlocked = true;
        SaveManager.instance.activeSave.page5v2_Unlocked = true;
    }
    public void Page65A_Unlocked()
    {
        page65A_Unlocked = true;
        SaveManager.instance.activeSave.page65A_Unlocked = true;
    }
    public void Page6v1_Unlocked()
    {
        page6v1_Unlocked = true;
        SaveManager.instance.activeSave.page6v1_Unlocked = true;
    }
    public void Page6v2_Unlocked()
    {
        page6v2_Unlocked = true;
        SaveManager.instance.activeSave.page6v2_Unlocked = true;
    }
    public void Page7_Unlocked()
    {
        page7_Unlocked = true;
        SaveManager.instance.activeSave.page7_Unlocked = true;
    }
    public void Page8_Unlocked()
    {
        page8_Unlocked = true;
        SaveManager.instance.activeSave.page8_Unlocked = true;
    }
    public void Page9A_Unlocked()
    {
        page9A_Unlocked = true;
        SaveManager.instance.activeSave.page9A_Unlocked = true;
    }
    public void Page9B_Unlocked()
    {
        page9B_Unlocked = true;
        SaveManager.instance.activeSave.page9B_Unlocked = true;
    }
    public void Page9C_Unlocked()
    {
        page9C_Unlocked = true;
        SaveManager.instance.activeSave.page9C_Unlocked = true;
    }
    public void Page10_Unlocked()
    {
        page10_Unlocked = true;
        SaveManager.instance.activeSave.page10_Unlocked = true;
    }

    public void Page11A_Unlocked()
    {
        page11A_Unlocked = true;
        SaveManager.instance.activeSave.page11A_Unlocked = true;
    }

    public void PS_Unlocked()
    {
        pS_Unlocked = true;
        SaveManager.instance.activeSave.pS_Unlocked = true;
    }
    public void PF1B_Unlocked()
    {
        pF1B_Unlocked = true;
        SaveManager.instance.activeSave.pF1B_Unlocked = true;
    }
    public void PF2B_Unlocked()
    {
        pF2B_Unlocked = true;
        SaveManager.instance.activeSave.pF2B_Unlocked = true;
    }
    public void PF3O_1_Unlocked()
    {
        pF3O_1_Unlocked = true;
        SaveManager.instance.activeSave.pF3O_1_Unlocked = true;
    }
    public void PF3O_2_Unlocked()
    {
        pF3O_1_Unlocked = true;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = true;
    }
    public void PF3O_3_Unlocked()
    {
        pF3O_1_Unlocked = true;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = true;
    }
    public void PF4G_Unlocked()
    {
        pF4G_Unlocked = true;
        SaveManager.instance.activeSave.pF4G_Unlocked = true;
    }
    public void PF5T_Unlocked()
    {
        pF5T_Unlocked = true;
        SaveManager.instance.activeSave.pF5T_Unlocked = true;
    }


}

