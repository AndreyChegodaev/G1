using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalChoiceManager_PF30 : MonoBehaviour
{

    public void TaskOnClick()
    {
        if (SaveManager.instance.activeSave.pF3O_1_Unlocked == true)
        {
            GameManager.instance.F3O_1_Unlocked();

        }
        else if (SaveManager.instance.activeSave.pF3O_2_Unlocked == true)
        {
            GameManager.instance.F3O_2_Unlocked();

        }
        else if (SaveManager.instance.activeSave.pF3O_3_Unlocked == true)
        {
            GameManager.instance.F3O_3_Unlocked();

        }
    }

}
