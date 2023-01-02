using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
    //public static MapManager instanceMapManager;

    public List<GameObject> f1B = new List<GameObject>();
    public List<GameObject> f3O = new List<GameObject>();
    public List<GameObject> f4G = new List<GameObject>();
    public List<GameObject> f5T = new List<GameObject>();
    public List<GameObject> page1 = new List<GameObject>();
    public List<GameObject> page2 = new List<GameObject>();
    public List<GameObject> page35 = new List<GameObject>();
    public List<GameObject> page3A = new List<GameObject>();
    public List<GameObject> page3B = new List<GameObject>();
    public List<GameObject> page3C = new List<GameObject>();
    public List<GameObject> page4 = new List<GameObject>();
    public List<GameObject> page55A = new List<GameObject>();
    public List<GameObject> page5 = new List<GameObject>();
    public List<GameObject> page5v2 = new List<GameObject>();
    public List<GameObject> page65A = new List<GameObject>();
    public List<GameObject> page6v1 = new List<GameObject>();
    public List<GameObject> page6v2 = new List<GameObject>();
    public List<GameObject> page7 = new List<GameObject>();
    public List<GameObject> page8 = new List<GameObject>();
    public List<GameObject> page9A = new List<GameObject>();
    public List<GameObject> page9B = new List<GameObject>();
    public List<GameObject> page9C = new List<GameObject>();
    public List<GameObject> page10 = new List<GameObject>();
    public List<GameObject> page11A = new List<GameObject>();
    public List<GameObject> ps = new List<GameObject>();
    public List<GameObject> pf1b = new List<GameObject>();
    public List<GameObject> pf2b = new List<GameObject>();
    public List<GameObject> pf3o = new List<GameObject>();
    public List<GameObject> pf4g = new List<GameObject>();
    public List<GameObject> pf5t = new List<GameObject>();



    /*    private void Awake()
        {
            instanceMapManager = this;
        }*/

    void Start()
    {


        //Final 1 Bad
        if (SaveManager.instance.activeSave.f1B_Unlocked == true && SaveManager.instance.activeSave.pF1B_Unlocked == true)
        {
            f1B[0].SetActive(true);
            f1B[1].SetActive(true);
            f1B[2].SetActive(false);

        }
        else if (SaveManager.instance.activeSave.f1B_Unlocked == true && SaveManager.instance.activeSave.pF2B_Unlocked == true)
        {
            f1B[0].SetActive(true);
            f1B[1].SetActive(false);
            f1B[2].SetActive(true);
        }
        else
        {
            foreach (var item in f1B)
                item.SetActive(false);
        }


        //Final-3-Ok (1,2,3)
        if (SaveManager.instance.activeSave.f3O_1_Unlocked == true)
        {
            f3O[0].SetActive(true);
            f3O[1].SetActive(true);
            f3O[2].SetActive(false);
            f3O[3].SetActive(false);
            f3O[4].SetActive(false);
            f3O[5].SetActive(false);
        }
        else if (SaveManager.instance.activeSave.f3O_2_Unlocked)
        {
            f3O[0].SetActive(false);
            f3O[1].SetActive(false);
            f3O[2].SetActive(true);
            f3O[3].SetActive(true);
            f3O[4].SetActive(false);
            f3O[5].SetActive(false);
        }
        else if (SaveManager.instance.activeSave.f3O_3_Unlocked)
        {
            f3O[0].SetActive(false);
            f3O[1].SetActive(false);
            f3O[2].SetActive(false);
            f3O[3].SetActive(false);
            f3O[4].SetActive(true);
            f3O[5].SetActive(true);
        }
        else
        {
            foreach (var item in f3O)
                item.SetActive(false);
        }

        //Final 4 Good
        if (SaveManager.instance.activeSave.f4G_Unlocked == true)
        {
            f4G[0].SetActive(true);
            f4G[1].SetActive(false);
        }
        else
        {
            foreach (var item in f4G)
                item.SetActive(false);
        }

        //Final 5 True
        if (SaveManager.instance.activeSave.f5T_Unlocked == true)
        {
            f5T[0].SetActive(true);
            f5T[1].SetActive(false);
        }
        else
        {
            foreach (var item in f5T)
                item.SetActive(false);
        }

        //Page 1
        if (SaveManager.instance.activeSave.page1_Unlocked == true)
        {
            page1[0].SetActive(true);
        }
        else
        {
            foreach (var item in page1)
                item.SetActive(false);
        }

        //Page 2
        if (SaveManager.instance.activeSave.page2_Unlocked == true)
        {
            page2[0].SetActive(true);
            page2[1].SetActive(true);
        }
        else
        {
            foreach (var item in page2)
                item.SetActive(false);
        }

        //Page 3.5
        if (SaveManager.instance.activeSave.page35_Unlocked == true)
        {
            page35[0].SetActive(true);
            page35[1].SetActive(true);
        }
        else
        {
            foreach (var item in page35)
                item.SetActive(false);
        }

        //Page 3A
        if (SaveManager.instance.activeSave.page3A_Unlocked == true && SaveManager.instance.activeSave.page35_Unlocked == true)
        {
            page3A[0].SetActive(true);
            page3A[1].SetActive(false);
            page3A[2].SetActive(true);
        }
        else if (SaveManager.instance.activeSave.page3A_Unlocked == true && SaveManager.instance.activeSave.page35_Unlocked == false)
        {
            page3A[0].SetActive(true);
            page3A[1].SetActive(true);
            page3A[2].SetActive(false);
        }
        else
        {
            foreach (var item in page3A)
                item.SetActive(false);
        }

        //Page 3B
        if (SaveManager.instance.activeSave.page3B_Unlocked == true)
        {
            page3B[0].SetActive(true);
            page3B[1].SetActive(true);
        }
        else
        {
            foreach (var item in page3B)
                item.SetActive(false);
        }


        //Page 3C
        if (SaveManager.instance.activeSave.page3C_Unlocked == true && SaveManager.instance.activeSave.page35_Unlocked == true)
        {
            page3C[0].SetActive(true);
            page3C[1].SetActive(false);
            page3C[2].SetActive(true);
        }
        else if (SaveManager.instance.activeSave.page3C_Unlocked == true && SaveManager.instance.activeSave.page35_Unlocked == false)
        {
            page3C[0].SetActive(true);
            page3C[1].SetActive(true);
            page3C[2].SetActive(false);
        }
        else
        {
            foreach (var item in page3C)
                item.SetActive(false);
        }


        //Page 4
        if (SaveManager.instance.activeSave.page4_Unlocked == true && SaveManager.instance.activeSave.page3A_Unlocked == true)
        {
            page4[0].SetActive(true);
            page4[1].SetActive(true);
            page4[2].SetActive(false);
        }
        else if (SaveManager.instance.activeSave.page4_Unlocked == true && SaveManager.instance.activeSave.page3C_Unlocked == true)
        {
            page4[0].SetActive(true);
            page4[1].SetActive(false);
            page4[2].SetActive(true);
        }
        else
        {
            foreach (var item in page4)
                item.SetActive(false);
        }

        //Page 5.5A
        if (SaveManager.instance.activeSave.page55A_Unlocked == true && SaveManager.instance.activeSave.page5v2_Unlocked == false)
        {
            page55A[0].SetActive(true);
            page55A[1].SetActive(true);
            page55A[2].SetActive(false);

        }
        else if (SaveManager.instance.activeSave.page55A_Unlocked == true && SaveManager.instance.activeSave.page5v2_Unlocked == true)
        {
            page55A[0].SetActive(true);
            page55A[1].SetActive(false);
            page55A[2].SetActive(true);
        }
        else
        {
            foreach (var item in page55A)
                item.SetActive(false);
        }

        //Page 5
        if (SaveManager.instance.activeSave.page5_Unlocked == true)
        {
            page5[0].SetActive(true);
            page5[1].SetActive(true);
        }
        else
        {
            foreach (var item in page5)
                item.SetActive(false);
        }

        //Page 5v2
        if (SaveManager.instance.activeSave.page5v2_Unlocked == true)
        {
            page5v2[0].SetActive(true);
            page5v2[1].SetActive(true);
        }
        else
        {
            foreach (var item in page5v2)
                item.SetActive(false);
        }

        //Page 6.5A
        if (SaveManager.instance.activeSave.page65A_Unlocked == true)
        {
            page65A[0].SetActive(true);
            page65A[1].SetActive(true);
        }
        else
        {
            foreach (var item in page65A)
                item.SetActive(false);
        }

        //Page 6v1
        if (SaveManager.instance.activeSave.page6v1_Unlocked == true)
        {
            page6v1[0].SetActive(true);
            page6v1[1].SetActive(true);
        }
        else
        {
            foreach (var item in page6v1)
                item.SetActive(false);
        }

        //Page 6v2
        if (SaveManager.instance.activeSave.page6v2_Unlocked == true)
        {
            page6v2[0].SetActive(true);
            page6v2[1].SetActive(true);
        }
        else
        {
            foreach (var item in page6v2)
                item.SetActive(false);
        }

        //Page 7
        if (SaveManager.instance.activeSave.page7_Unlocked == true)
        {
            page7[0].SetActive(true);
            page7[1].SetActive(true);
        }
        else
        {
            foreach (var item in page7)
                item.SetActive(false);
        }

        //Page 8
        if (SaveManager.instance.activeSave.page8_Unlocked == true)
        {
            page8[0].SetActive(true);
            page8[1].SetActive(true);
        }
        else
        {
            foreach (var item in page8)
                item.SetActive(false);
        }

        //Page 9A
        if (SaveManager.instance.activeSave.page9A_Unlocked == true && SaveManager.instance.activeSave.waitAtTheDoor == 0)
        {
            page9A[0].SetActive(true);
            page9A[1].SetActive(true);
            page9A[2].SetActive(false);
        }
        if (SaveManager.instance.activeSave.page9A_Unlocked == true && SaveManager.instance.activeSave.waitAtTheDoor != 0)
        {
            page9A[0].SetActive(true);
            page9A[1].SetActive(true);
            page9A[2].SetActive(true);
        }
        else
        {
            foreach (var item in page9A)
                item.SetActive(false);
        }

        //Page 9B
        if (SaveManager.instance.activeSave.page9B_Unlocked == true && SaveManager.instance.activeSave.page9A_Unlocked == false)
        {
            page9B[0].SetActive(true);
            page9B[1].SetActive(true);
            page9B[2].SetActive(false);
        }
        else if (SaveManager.instance.activeSave.page9B_Unlocked == true && SaveManager.instance.activeSave.page9A_Unlocked == true)
        {
            page9B[0].SetActive(true);
            page9B[1].SetActive(true);
            page9B[2].SetActive(true);
        }

        else
        {
            foreach (var item in page9B)
                item.SetActive(false);
        }

        //Page 9C
        if (SaveManager.instance.activeSave.page9C_Unlocked == true && SaveManager.instance.activeSave.page9A_Unlocked == false)
        {
            page9C[0].SetActive(true);
            page9C[1].SetActive(true);
            page9C[2].SetActive(false);
        }
        else if (SaveManager.instance.activeSave.page9C_Unlocked == true && SaveManager.instance.activeSave.page9A_Unlocked == true)
        {
            page9C[0].SetActive(true);
            page9C[1].SetActive(true);
            page9C[2].SetActive(true);
        }
        else
        {
            foreach (var item in page9C)
                item.SetActive(false);
        }

        //Page 10
        if (SaveManager.instance.activeSave.page10_Unlocked == true)
        {
            page10[0].SetActive(true);
            page10[1].SetActive(true);
        }
        else
        {
            foreach (var item in page10)
                item.SetActive(false);
        }

        //Page 11A
        if (SaveManager.instance.activeSave.page11A_Unlocked == true)
        {
            page11A[0].SetActive(true);
            page11A[1].SetActive(true);
        }
        else
        {
            foreach (var item in page11A)
                item.SetActive(false);
        }

        //Post Scriptum
        if (SaveManager.instance.activeSave.pS_Unlocked == true)
        {
            ps[0].SetActive(true);
            ps[1].SetActive(true);
        }
        else
        {
            foreach (var item in ps)
                item.SetActive(false);
        }

        //Pre Final 1 Bad
        if (SaveManager.instance.activeSave.pF1B_Unlocked == true && SaveManager.instance.activeSave.page55A_Unlocked == true)
        {
            pf1b[0].SetActive(true);
            pf1b[1].SetActive(true);
            pf1b[2].SetActive(false);
        }
        else if (SaveManager.instance.activeSave.pF1B_Unlocked == true && SaveManager.instance.activeSave.page55B_Unlocked == true)
        {
            pf1b[0].SetActive(true);
            pf1b[1].SetActive(false);
            pf1b[2].SetActive(true);
        }
        else
        {
            foreach (var item in pf1b)
                item.SetActive(false);
        }

        //Pre Final 2 Bad
        if (SaveManager.instance.activeSave.pF2B_Unlocked == true)
        {
            pf2b[0].SetActive(true);
            pf2b[1].SetActive(true);
        }
        else
        {
            foreach (var item in pf2b)
                item.SetActive(false);
        }

        //Pre Final 3 Ok (1,2,3)
        if (SaveManager.instance.activeSave.pF3O_1_Unlocked == true)
        {
            pf3o[0].SetActive(true);
            pf3o[1].SetActive(true);
            pf3o[2].SetActive(false);
            pf3o[3].SetActive(false);
            pf3o[4].SetActive(false);
            pf3o[5].SetActive(false);

        }
        else if (SaveManager.instance.activeSave.pF3O_2_Unlocked)
        {
            pf3o[0].SetActive(false);
            pf3o[1].SetActive(false);
            pf3o[2].SetActive(true);
            pf3o[3].SetActive(true);
            pf3o[4].SetActive(false);
            pf3o[5].SetActive(false);
        }
        else if (SaveManager.instance.activeSave.pF3O_3_Unlocked)
        {
            pf3o[0].SetActive(false);
            pf3o[1].SetActive(false);
            pf3o[2].SetActive(false);
            pf3o[3].SetActive(false);
            pf3o[4].SetActive(true);
            pf3o[5].SetActive(true);
        }
        else
        {
            foreach (var item in pf3o)
                item.SetActive(false);
        }

        //Pre Final 4 Goodish
        if (SaveManager.instance.activeSave.pF4G_Unlocked == true)
        {
            pf4g[0].SetActive(true);
            pf4g[1].SetActive(true);
        }
        else
        {
            foreach (var item in pf4g)
                item.SetActive(false);
        }

        //Pre Final 5 True
        if (SaveManager.instance.activeSave.pF5T_Unlocked == true)
        {
            pf5t[0].SetActive(true);
            pf5t[1].SetActive(true);

        }
        else
        {
            foreach (var item in pf5t)
                item.SetActive(false);
        }
    }

    private void Update()
    {

    }

    public void PreFinal1bad()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(true);
        SaveManager.instance.activeSave.pF1B_Unlocked = true;
        GameManager.instance.pF1B_Unlocked = true;
    }

    public void PreFinal2bad()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(true);
        SaveManager.instance.activeSave.pF2B_Unlocked = true;
        GameManager.instance.pF2B_Unlocked = true;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;
    }

    public void PreFinal3Ok()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;


        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //pf3O

        if (SaveManager.instance.activeSave.pF3O_1_Unlocked == true)
        {
            pf3o[0].SetActive(true);
            pf3o[1].SetActive(true);
            pf3o[2].SetActive(false);
            pf3o[3].SetActive(false);
            pf3o[4].SetActive(false);
            pf3o[5].SetActive(false);

            SaveManager.instance.activeSave.pF3O_1_Unlocked = true;
            GameManager.instance.pF3O_1_Unlocked = true;
            SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
            GameManager.instance.pF3O_2_Unlocked = false;
            SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
            GameManager.instance.pF3O_3_Unlocked = false;

        }
        else if (SaveManager.instance.activeSave.pF3O_2_Unlocked)
        {
            pf3o[0].SetActive(false);
            pf3o[1].SetActive(false);
            pf3o[2].SetActive(true);
            pf3o[3].SetActive(true);
            pf3o[4].SetActive(false);
            pf3o[5].SetActive(false);

            SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
            GameManager.instance.pF3O_1_Unlocked = false;
            SaveManager.instance.activeSave.pF3O_2_Unlocked = true;
            GameManager.instance.pF3O_2_Unlocked = true;
            SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
            GameManager.instance.pF3O_3_Unlocked = false;
        }
        else if (SaveManager.instance.activeSave.pF3O_3_Unlocked)
        {
            pf3o[0].SetActive(false);
            pf3o[1].SetActive(false);
            pf3o[2].SetActive(false);
            pf3o[3].SetActive(false);
            pf3o[4].SetActive(true);
            pf3o[5].SetActive(true);

            SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
            GameManager.instance.pF3O_1_Unlocked = false;
            SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
            GameManager.instance.pF3O_2_Unlocked = false;
            SaveManager.instance.activeSave.pF3O_3_Unlocked = true;
            GameManager.instance.pF3O_3_Unlocked = true;
        }
        else
        {
            foreach (var item in pf3o)
                item.SetActive(false);

            SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
            GameManager.instance.pF3O_1_Unlocked = false;
            SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
            GameManager.instance.pF3O_2_Unlocked = false;
            SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
            GameManager.instance.pF3O_3_Unlocked = false;
        }

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void PreFinal4goodish()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(true);
        SaveManager.instance.activeSave.pF4G_Unlocked = true;
        GameManager.instance.pF4G_Unlocked = true;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void PreFinal5true()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5t
        foreach (var item in pf5t) item.SetActive(true);
        SaveManager.instance.activeSave.pF5T_Unlocked = true;
        GameManager.instance.pF5T_Unlocked = true;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;
    }

    public void Postscriptum()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //PS
        foreach (var item in ps) item.SetActive(true);
        SaveManager.instance.activeSave.pS_Unlocked = true;
        GameManager.instance.pS_Unlocked = true;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;
    }

    public void Final1bad()
    {
        if (SaveManager.instance.activeSave.f1B_Unlocked == true && SaveManager.instance.activeSave.pF1B_Unlocked == true)
        {
            f1B[0].SetActive(true);
            f1B[1].SetActive(true);
            f1B[2].SetActive(false);

        }
        else if (SaveManager.instance.activeSave.f1B_Unlocked == true && SaveManager.instance.activeSave.pF2B_Unlocked == true)
        {
            f1B[0].SetActive(true);
            f1B[1].SetActive(false);
            f1B[2].SetActive(true);
        }
        else
        {
            foreach (var item in f1B)
                item.SetActive(false);
        }
    }

    public void Final3Ok()
    {
        if (SaveManager.instance.activeSave.f3O_1_Unlocked == true)
        {
            f3O[0].SetActive(true);
            f3O[1].SetActive(true);
            f3O[2].SetActive(false);
            f3O[3].SetActive(false);
            f3O[4].SetActive(false);
            f3O[5].SetActive(false);

            SaveManager.instance.activeSave.f3O_1_Unlocked = true;
            GameManager.instance.f3O_1_Unlocked = true;
            SaveManager.instance.activeSave.f3O_2_Unlocked = false;
            GameManager.instance.f3O_2_Unlocked = false;
            SaveManager.instance.activeSave.f3O_3_Unlocked = false;
            GameManager.instance.f3O_3_Unlocked = false;
        }
        else if (SaveManager.instance.activeSave.f3O_2_Unlocked)
        {
            f3O[0].SetActive(false);
            f3O[1].SetActive(false);
            f3O[2].SetActive(true);
            f3O[3].SetActive(true);
            f3O[4].SetActive(false);
            f3O[5].SetActive(false);

            SaveManager.instance.activeSave.f3O_1_Unlocked = false;
            GameManager.instance.f3O_1_Unlocked = false;
            SaveManager.instance.activeSave.f3O_2_Unlocked = true;
            GameManager.instance.f3O_2_Unlocked = true;
            SaveManager.instance.activeSave.f3O_3_Unlocked = false;
            GameManager.instance.f3O_3_Unlocked = false;
        }
        else if (SaveManager.instance.activeSave.f3O_3_Unlocked)
        {
            f3O[0].SetActive(false);
            f3O[1].SetActive(false);
            f3O[2].SetActive(false);
            f3O[3].SetActive(false);
            f3O[4].SetActive(true);
            f3O[5].SetActive(true);

            SaveManager.instance.activeSave.f3O_1_Unlocked = false;
            GameManager.instance.f3O_1_Unlocked = false;
            SaveManager.instance.activeSave.f3O_2_Unlocked = false;
            GameManager.instance.f3O_2_Unlocked = false;
            SaveManager.instance.activeSave.f3O_3_Unlocked = true;
            GameManager.instance.f3O_3_Unlocked = true;
        }
        else
        {
            foreach (var item in f3O)
                item.SetActive(false);

            SaveManager.instance.activeSave.f3O_1_Unlocked = false;
            GameManager.instance.f3O_1_Unlocked = false;
            SaveManager.instance.activeSave.f3O_2_Unlocked = false;
            GameManager.instance.f3O_2_Unlocked = false;
            SaveManager.instance.activeSave.f3O_3_Unlocked = false;
            GameManager.instance.f3O_3_Unlocked = false;
        }
    }

    public void Final4goodish()
    {
        foreach (var item in f4G) item.SetActive(true);
        SaveManager.instance.activeSave.f4G_Unlocked = true;
        GameManager.instance.f4G_Unlocked = true;
    }

    public void Final5true()
    {
        foreach (var item in f5T) item.SetActive(true);
        SaveManager.instance.activeSave.f5T_Unlocked = true;
        GameManager.instance.f5T_Unlocked = true;
    }

    public void Page1()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;

        //page1
        foreach (var item in page1) item.SetActive(true);
        SaveManager.instance.activeSave.page1_Unlocked = true; //level 1
        GameManager.instance.page1_Unlocked = true;

        //page2
        foreach (var item in page2) item.SetActive(false);
        SaveManager.instance.activeSave.page2_Unlocked = false;
        GameManager.instance.page2_Unlocked = false;

        SaveManager.instance.activeSave.onTree = false;
        GameManager.instance.onTree = false;

        SaveManager.instance.activeSave.hasFork = false;
        GameManager.instance.hasFork = false;

        SaveManager.instance.activeSave.hasFinger = false;
        GameManager.instance.hasFinger = false;

        //page3.5
        foreach (var item in page35) item.SetActive(false);
        SaveManager.instance.activeSave.page35_Unlocked = false;
        GameManager.instance.page35_Unlocked = false;

        SaveManager.instance.activeSave.hasFinger = false;
        GameManager.instance.hasFinger = false;


        //page3A
        foreach (var item in page3A) item.SetActive(false);
        SaveManager.instance.activeSave.page3A_Unlocked = false;
        GameManager.instance.page3A_Unlocked = false;

        //page3B
        foreach (var item in page3B) item.SetActive(false);
        SaveManager.instance.activeSave.page3B_Unlocked = false;
        GameManager.instance.page3B_Unlocked = false;

        SaveManager.instance.activeSave.onTree = false;
        GameManager.instance.onTree = false;

        SaveManager.instance.activeSave.hasFork = false;
        GameManager.instance.hasFork = false;

        //page3C
        foreach (var item in page3C) item.SetActive(false);
        SaveManager.instance.activeSave.page3C_Unlocked = false;
        GameManager.instance.page3C_Unlocked = false;

        SaveManager.instance.activeSave.hasFinger = false;
        GameManager.instance.hasFinger = false;

        //page4
        foreach (var item in page4) item.SetActive(false);
        SaveManager.instance.activeSave.page4_Unlocked = false;
        GameManager.instance.page4_Unlocked = false;

        //page55A
        foreach (var item in page55A) item.SetActive(false);
        SaveManager.instance.activeSave.page55A_Unlocked = false;
        GameManager.instance.page55A_Unlocked = false;

        //page5
        foreach (var item in page5) item.SetActive(false);
        SaveManager.instance.activeSave.page5_Unlocked = false;
        GameManager.instance.page5_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page5v2
        foreach (var item in page5v2) item.SetActive(false);
        SaveManager.instance.activeSave.page5v2_Unlocked = false;
        GameManager.instance.page5v2_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page65A
        foreach (var item in page65A) item.SetActive(false);
        SaveManager.instance.activeSave.page65A_Unlocked = false;
        GameManager.instance.page65A_Unlocked = false;

        //page6v1
        foreach (var item in page6v1) item.SetActive(false);
        SaveManager.instance.activeSave.page6v1_Unlocked = false;
        GameManager.instance.page6v1_Unlocked = false;

        //page6v2
        foreach (var item in page6v2) item.SetActive(false);
        SaveManager.instance.activeSave.page6v2_Unlocked = false;
        GameManager.instance.page6v2_Unlocked = false;

        SaveManager.instance.activeSave.visitedWitch = false;
        GameManager.instance.visitedWitch = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //page7
        foreach (var item in page7) item.SetActive(false);
        SaveManager.instance.activeSave.page7_Unlocked = false;
        GameManager.instance.page7_Unlocked = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        GameManager.instance.crossedRavine = false;

        //page8
        foreach (var item in page8) item.SetActive(false);
        SaveManager.instance.activeSave.page8_Unlocked = false;
        GameManager.instance.page8_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page2()
    {

        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;

        //page1
        foreach (var item in page1) item.SetActive(true);
        SaveManager.instance.activeSave.page1_Unlocked = true; //level 1
        GameManager.instance.page1_Unlocked = true;

        //page2
        foreach (var item in page2) item.SetActive(true);
        SaveManager.instance.activeSave.page2_Unlocked = true;
        GameManager.instance.page2_Unlocked = true;

        SaveManager.instance.activeSave.onTree = false;
        GameManager.instance.onTree = false;

        SaveManager.instance.activeSave.hasFork = false;
        GameManager.instance.hasFork = false;

        SaveManager.instance.activeSave.hasFinger = false;
        GameManager.instance.hasFinger = false;

        //page3.5
        foreach (var item in page35) item.SetActive(false);
        SaveManager.instance.activeSave.page35_Unlocked = false;
        GameManager.instance.page35_Unlocked = false;

        SaveManager.instance.activeSave.hasFinger = false;
        GameManager.instance.hasFinger = false;


        //page3A
        foreach (var item in page3A) item.SetActive(false);
        SaveManager.instance.activeSave.page3A_Unlocked = false;
        GameManager.instance.page3A_Unlocked = false;

        //page3B
        foreach (var item in page3B) item.SetActive(false);
        SaveManager.instance.activeSave.page3B_Unlocked = false;
        GameManager.instance.page3B_Unlocked = false;

        SaveManager.instance.activeSave.onTree = false;
        GameManager.instance.onTree = false;

        SaveManager.instance.activeSave.hasFork = false;
        GameManager.instance.hasFork = false;

        //page3C
        foreach (var item in page3C) item.SetActive(false);
        SaveManager.instance.activeSave.page3C_Unlocked = false;
        GameManager.instance.page3C_Unlocked = false;

        SaveManager.instance.activeSave.hasFinger = false;
        GameManager.instance.hasFinger = false;

        //page4
        foreach (var item in page4) item.SetActive(false);
        SaveManager.instance.activeSave.page4_Unlocked = false;
        GameManager.instance.page4_Unlocked = false;

        //page55A
        foreach (var item in page55A) item.SetActive(false);
        SaveManager.instance.activeSave.page55A_Unlocked = false;
        GameManager.instance.page55A_Unlocked = false;

        //page5
        foreach (var item in page5) item.SetActive(false);
        SaveManager.instance.activeSave.page5_Unlocked = false;
        GameManager.instance.page5_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page5v2
        foreach (var item in page5v2) item.SetActive(false);
        SaveManager.instance.activeSave.page5v2_Unlocked = false;
        GameManager.instance.page5v2_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page65A
        foreach (var item in page65A) item.SetActive(false);
        SaveManager.instance.activeSave.page65A_Unlocked = false;
        GameManager.instance.page65A_Unlocked = false;

        //page6v1
        foreach (var item in page6v1) item.SetActive(false);
        SaveManager.instance.activeSave.page6v1_Unlocked = false;
        GameManager.instance.page6v1_Unlocked = false;

        //page6v2
        foreach (var item in page6v2) item.SetActive(false);
        SaveManager.instance.activeSave.page6v2_Unlocked = false;
        GameManager.instance.page6v2_Unlocked = false;

        SaveManager.instance.activeSave.visitedWitch = false;
        GameManager.instance.visitedWitch = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //page7
        foreach (var item in page7) item.SetActive(false);
        SaveManager.instance.activeSave.page7_Unlocked = false;
        GameManager.instance.page7_Unlocked = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        GameManager.instance.crossedRavine = false;

        //page8
        foreach (var item in page8) item.SetActive(false);
        SaveManager.instance.activeSave.page8_Unlocked = false;
        GameManager.instance.page8_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page35()
    {

        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;

        //page1
        foreach (var item in page1) item.SetActive(true);
        SaveManager.instance.activeSave.page1_Unlocked = true; //level 1
        GameManager.instance.page1_Unlocked = true;

        //page2
        foreach (var item in page2) item.SetActive(true);
        SaveManager.instance.activeSave.page2_Unlocked = true;
        GameManager.instance.page2_Unlocked = true;

        //page3.5
        foreach (var item in page35) item.SetActive(true);
        SaveManager.instance.activeSave.page35_Unlocked = false;
        GameManager.instance.page35_Unlocked = false;

        SaveManager.instance.activeSave.hasFinger = false;
        GameManager.instance.hasFinger = false;


        //page3A
        foreach (var item in page3A) item.SetActive(false);
        SaveManager.instance.activeSave.page3A_Unlocked = false;
        GameManager.instance.page3A_Unlocked = false;

        //page3B
        foreach (var item in page3B) item.SetActive(true);
        SaveManager.instance.activeSave.page3B_Unlocked = true;
        GameManager.instance.page3B_Unlocked = true;

        //page3C
        foreach (var item in page3C) item.SetActive(false);
        SaveManager.instance.activeSave.page3C_Unlocked = false;
        GameManager.instance.page3C_Unlocked = false;

        SaveManager.instance.activeSave.hasFinger = false;
        GameManager.instance.hasFinger = false;

        //page4
        foreach (var item in page4) item.SetActive(false);
        SaveManager.instance.activeSave.page4_Unlocked = false;
        GameManager.instance.page4_Unlocked = false;

        //page55A
        foreach (var item in page55A) item.SetActive(false);
        SaveManager.instance.activeSave.page55A_Unlocked = false;
        GameManager.instance.page55A_Unlocked = false;

        //page5
        foreach (var item in page5) item.SetActive(false);
        SaveManager.instance.activeSave.page5_Unlocked = false;
        GameManager.instance.page5_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page5v2
        foreach (var item in page5v2) item.SetActive(false);
        SaveManager.instance.activeSave.page5v2_Unlocked = false;
        GameManager.instance.page5v2_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page65A
        foreach (var item in page65A) item.SetActive(false);
        SaveManager.instance.activeSave.page65A_Unlocked = false;
        GameManager.instance.page65A_Unlocked = false;

        //page6v1
        foreach (var item in page6v1) item.SetActive(false);
        SaveManager.instance.activeSave.page6v1_Unlocked = false;
        GameManager.instance.page6v1_Unlocked = false;

        //page6v2
        foreach (var item in page6v2) item.SetActive(false);
        SaveManager.instance.activeSave.page6v2_Unlocked = false;
        GameManager.instance.page6v2_Unlocked = false;

        SaveManager.instance.activeSave.visitedWitch = false;
        GameManager.instance.visitedWitch = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //page7
        foreach (var item in page7) item.SetActive(false);
        SaveManager.instance.activeSave.page7_Unlocked = false;
        GameManager.instance.page7_Unlocked = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        GameManager.instance.crossedRavine = false;

        //page8
        foreach (var item in page8) item.SetActive(false);
        SaveManager.instance.activeSave.page8_Unlocked = false;
        GameManager.instance.page8_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page3A()
    {

        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;


        //page3.5

        if (SaveManager.instance.activeSave.page35_Unlocked == true)
        {
            foreach (var item in page35) item.SetActive(true);
            SaveManager.instance.activeSave.page35_Unlocked = true;
            GameManager.instance.page35_Unlocked = true;

            //SaveManager.instance.activeSave.hasFinger = false;
            //GameManager.instance.hasFinger = false;
        }
        else
        {
            foreach (var item in page35) item.SetActive(false);
            SaveManager.instance.activeSave.page35_Unlocked = false;
            GameManager.instance.page35_Unlocked = false;

            SaveManager.instance.activeSave.hasFinger = false;
            GameManager.instance.hasFinger = false;
        }




        //page3A
        if (SaveManager.instance.activeSave.page3A_Unlocked == true && SaveManager.instance.activeSave.page35_Unlocked == true)
        {
            page3A[0].SetActive(true);
            page3A[1].SetActive(false);
            page3A[2].SetActive(true);


            SaveManager.instance.activeSave.hasFinger = true;
            GameManager.instance.hasFinger = true;


        }
        else if (SaveManager.instance.activeSave.page3A_Unlocked == true && SaveManager.instance.activeSave.page35_Unlocked == false)
        {
            page3A[0].SetActive(true);
            page3A[1].SetActive(true);
            page3A[2].SetActive(false);


            SaveManager.instance.activeSave.hasFinger = false;
            GameManager.instance.hasFinger = false;
        }
        else
        {
            foreach (var item in page3A)
                item.SetActive(false);


            SaveManager.instance.activeSave.hasFinger = false;
            GameManager.instance.hasFinger = false;
        }
        SaveManager.instance.activeSave.page3A_Unlocked = true;
        GameManager.instance.page3A_Unlocked = true;

        //page3B
        if (SaveManager.instance.activeSave.page3B_Unlocked == true)
        {
            foreach (var item in page3B) item.SetActive(true);
            SaveManager.instance.activeSave.page3B_Unlocked = true;
            GameManager.instance.page3B_Unlocked = true;

            SaveManager.instance.activeSave.onTree = true;
            GameManager.instance.onTree = true;

            SaveManager.instance.activeSave.hasFork = true;
            GameManager.instance.hasFork = true;
        }
        else
        {
            foreach (var item in page3B) item.SetActive(false);
            SaveManager.instance.activeSave.page3B_Unlocked = false;
            GameManager.instance.page3B_Unlocked = false;

            SaveManager.instance.activeSave.hasFinger = false;
            GameManager.instance.hasFinger = false;

            SaveManager.instance.activeSave.onTree = false;
            GameManager.instance.onTree = false;

            SaveManager.instance.activeSave.hasFork = false;
            GameManager.instance.hasFork = false;
        }



        //page3C
        foreach (var item in page3C) item.SetActive(false);
        SaveManager.instance.activeSave.page3C_Unlocked = false;
        GameManager.instance.page3C_Unlocked = false;

        SaveManager.instance.activeSave.hasFinger = false;
        GameManager.instance.hasFinger = false;

        //page4
        foreach (var item in page4) item.SetActive(false);
        SaveManager.instance.activeSave.page4_Unlocked = false;
        GameManager.instance.page4_Unlocked = false;

        //page55A
        foreach (var item in page55A) item.SetActive(false);
        SaveManager.instance.activeSave.page55A_Unlocked = false;
        GameManager.instance.page55A_Unlocked = false;

        //page5
        foreach (var item in page5) item.SetActive(false);
        SaveManager.instance.activeSave.page5_Unlocked = false;
        GameManager.instance.page5_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page5v2
        foreach (var item in page5v2) item.SetActive(false);
        SaveManager.instance.activeSave.page5v2_Unlocked = false;
        GameManager.instance.page5v2_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page65A
        foreach (var item in page65A) item.SetActive(false);
        SaveManager.instance.activeSave.page65A_Unlocked = false;
        GameManager.instance.page65A_Unlocked = false;

        //page6v1
        foreach (var item in page6v1) item.SetActive(false);
        SaveManager.instance.activeSave.page6v1_Unlocked = false;
        GameManager.instance.page6v1_Unlocked = false;

        //page6v2
        foreach (var item in page6v2) item.SetActive(false);
        SaveManager.instance.activeSave.page6v2_Unlocked = false;
        GameManager.instance.page6v2_Unlocked = false;

        SaveManager.instance.activeSave.visitedWitch = false;
        GameManager.instance.visitedWitch = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //page7
        foreach (var item in page7) item.SetActive(false);
        SaveManager.instance.activeSave.page7_Unlocked = false;
        GameManager.instance.page7_Unlocked = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        GameManager.instance.crossedRavine = false;

        //page8
        foreach (var item in page8) item.SetActive(false);
        SaveManager.instance.activeSave.page8_Unlocked = false;
        GameManager.instance.page8_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page3B()
    {

        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;


        //page3.5
        foreach (var item in page35) item.SetActive(false);
        SaveManager.instance.activeSave.page35_Unlocked = false;
        GameManager.instance.page35_Unlocked = false;

        SaveManager.instance.activeSave.hasFinger = false;
        GameManager.instance.hasFinger = false;

        SaveManager.instance.activeSave.hasFinger = false;
        GameManager.instance.hasFinger = false;


        //page3A
        foreach (var item in page3A) item.SetActive(false);
        SaveManager.instance.activeSave.page3A_Unlocked = false;
        GameManager.instance.page3A_Unlocked = false;

        //page3B
        foreach (var item in page3B) item.SetActive(true);
        SaveManager.instance.activeSave.page3B_Unlocked = true;
        GameManager.instance.page3B_Unlocked = true;

        SaveManager.instance.activeSave.onTree = false;
        GameManager.instance.onTree = false;

        SaveManager.instance.activeSave.hasFork = false;
        GameManager.instance.hasFork = false;

        //page3C
        foreach (var item in page3C) item.SetActive(false);
        SaveManager.instance.activeSave.page3C_Unlocked = false;
        GameManager.instance.page3C_Unlocked = false;

        SaveManager.instance.activeSave.hasFinger = false;
        GameManager.instance.hasFinger = false;

        //page4
        foreach (var item in page4) item.SetActive(false);
        SaveManager.instance.activeSave.page4_Unlocked = false;
        GameManager.instance.page4_Unlocked = false;

        //page55A
        foreach (var item in page55A) item.SetActive(false);
        SaveManager.instance.activeSave.page55A_Unlocked = false;
        GameManager.instance.page55A_Unlocked = false;

        //page5
        foreach (var item in page5) item.SetActive(false);
        SaveManager.instance.activeSave.page5_Unlocked = false;
        GameManager.instance.page5_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page5v2
        foreach (var item in page5v2) item.SetActive(false);
        SaveManager.instance.activeSave.page5v2_Unlocked = false;
        GameManager.instance.page5v2_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page65A
        foreach (var item in page65A) item.SetActive(false);
        SaveManager.instance.activeSave.page65A_Unlocked = false;
        GameManager.instance.page65A_Unlocked = false;

        //page6v1
        foreach (var item in page6v1) item.SetActive(false);
        SaveManager.instance.activeSave.page6v1_Unlocked = false;
        GameManager.instance.page6v1_Unlocked = false;

        //page6v2
        foreach (var item in page6v2) item.SetActive(false);
        SaveManager.instance.activeSave.page6v2_Unlocked = false;
        GameManager.instance.page6v2_Unlocked = false;

        SaveManager.instance.activeSave.visitedWitch = false;
        GameManager.instance.visitedWitch = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //page7
        foreach (var item in page7) item.SetActive(false);
        SaveManager.instance.activeSave.page7_Unlocked = false;
        GameManager.instance.page7_Unlocked = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        GameManager.instance.crossedRavine = false;

        //page8
        foreach (var item in page8) item.SetActive(false);
        SaveManager.instance.activeSave.page8_Unlocked = false;
        GameManager.instance.page8_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page3C()
    {

        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;


        //page3.5

        if (SaveManager.instance.activeSave.page35_Unlocked == true)
        {
            foreach (var item in page35) item.SetActive(true);
            SaveManager.instance.activeSave.page35_Unlocked = true;
            GameManager.instance.page35_Unlocked = true;

            //SaveManager.instance.activeSave.hasFinger = false;
            //GameManager.instance.hasFinger = false;
        }
        else
        {
            foreach (var item in page35) item.SetActive(false);
            SaveManager.instance.activeSave.page35_Unlocked = false;
            GameManager.instance.page35_Unlocked = false;

            SaveManager.instance.activeSave.hasFinger = false;
            GameManager.instance.hasFinger = false;
        }


        //page3A
        foreach (var item in page3A) item.SetActive(false);
        SaveManager.instance.activeSave.page3A_Unlocked = false;
        GameManager.instance.page3A_Unlocked = false;

        //page3B
        if (SaveManager.instance.activeSave.page3B_Unlocked == true)
        {
            foreach (var item in page3B) item.SetActive(true);
            SaveManager.instance.activeSave.page3B_Unlocked = true;
            GameManager.instance.page3B_Unlocked = true;

            SaveManager.instance.activeSave.onTree = true;
            GameManager.instance.onTree = true;

            SaveManager.instance.activeSave.hasFork = true;
            GameManager.instance.hasFork = true;
        }
        else
        {
            foreach (var item in page3B) item.SetActive(false);
            SaveManager.instance.activeSave.page3B_Unlocked = false;
            GameManager.instance.page3B_Unlocked = false;

            SaveManager.instance.activeSave.hasFinger = false;
            GameManager.instance.hasFinger = false;

            SaveManager.instance.activeSave.onTree = false;
            GameManager.instance.onTree = false;

            SaveManager.instance.activeSave.hasFork = false;
            GameManager.instance.hasFork = false;
        }

        //page3C
        if (SaveManager.instance.activeSave.page3C_Unlocked == true && SaveManager.instance.activeSave.page35_Unlocked == true)
        {
            page3C[0].SetActive(true);
            page3C[1].SetActive(false);
            page3C[2].SetActive(true);


            SaveManager.instance.activeSave.hasFinger = true;
            GameManager.instance.hasFinger = true;
        }
        else if (SaveManager.instance.activeSave.page3C_Unlocked == true && SaveManager.instance.activeSave.page35_Unlocked == false)
        {
            page3C[0].SetActive(true);
            page3C[1].SetActive(true);
            page3C[2].SetActive(false);


            SaveManager.instance.activeSave.hasFinger = false;
            GameManager.instance.hasFinger = false;
        }
        else
        {
            foreach (var item in page3C)
                item.SetActive(false);


            SaveManager.instance.activeSave.hasFinger = false;
            GameManager.instance.hasFinger = false;
        }


        SaveManager.instance.activeSave.page3C_Unlocked = true;
        GameManager.instance.page3C_Unlocked = true;

        //page4
        foreach (var item in page4) item.SetActive(false);
        SaveManager.instance.activeSave.page4_Unlocked = false;
        GameManager.instance.page4_Unlocked = false;

        //page55A
        foreach (var item in page55A) item.SetActive(false);
        SaveManager.instance.activeSave.page55A_Unlocked = false;
        GameManager.instance.page55A_Unlocked = false;

        //page5
        foreach (var item in page5) item.SetActive(false);
        SaveManager.instance.activeSave.page5_Unlocked = false;
        GameManager.instance.page5_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page5v2
        foreach (var item in page5v2) item.SetActive(false);
        SaveManager.instance.activeSave.page5v2_Unlocked = false;
        GameManager.instance.page5v2_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page65A
        foreach (var item in page65A) item.SetActive(false);
        SaveManager.instance.activeSave.page65A_Unlocked = false;
        GameManager.instance.page65A_Unlocked = false;

        //page6v1
        foreach (var item in page6v1) item.SetActive(false);
        SaveManager.instance.activeSave.page6v1_Unlocked = false;
        GameManager.instance.page6v1_Unlocked = false;

        //page6v2
        foreach (var item in page6v2) item.SetActive(false);
        SaveManager.instance.activeSave.page6v2_Unlocked = false;
        GameManager.instance.page6v2_Unlocked = false;

        SaveManager.instance.activeSave.visitedWitch = false;
        GameManager.instance.visitedWitch = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //page7
        foreach (var item in page7) item.SetActive(false);
        SaveManager.instance.activeSave.page7_Unlocked = false;
        GameManager.instance.page7_Unlocked = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        GameManager.instance.crossedRavine = false;

        //page8
        foreach (var item in page8) item.SetActive(false);
        SaveManager.instance.activeSave.page8_Unlocked = false;
        GameManager.instance.page8_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page4()
    {

        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;


        //page4
        foreach (var item in page4) item.SetActive(true);
        SaveManager.instance.activeSave.page4_Unlocked = true;
        GameManager.instance.page4_Unlocked = true;

        //page55A
        foreach (var item in page55A) item.SetActive(false);
        SaveManager.instance.activeSave.page55A_Unlocked = false;
        GameManager.instance.page55A_Unlocked = false;

        //page5
        foreach (var item in page5) item.SetActive(false);
        SaveManager.instance.activeSave.page5_Unlocked = false;
        GameManager.instance.page5_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page5v2
        foreach (var item in page5v2) item.SetActive(false);
        SaveManager.instance.activeSave.page5v2_Unlocked = false;
        GameManager.instance.page5v2_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page65A
        foreach (var item in page65A) item.SetActive(false);
        SaveManager.instance.activeSave.page65A_Unlocked = false;
        GameManager.instance.page65A_Unlocked = false;

        //page6v1
        foreach (var item in page6v1) item.SetActive(false);
        SaveManager.instance.activeSave.page6v1_Unlocked = false;
        GameManager.instance.page6v1_Unlocked = false;

        //page6v2
        foreach (var item in page6v2) item.SetActive(false);
        SaveManager.instance.activeSave.page6v2_Unlocked = false;
        GameManager.instance.page6v2_Unlocked = false;

        SaveManager.instance.activeSave.visitedWitch = false;
        GameManager.instance.visitedWitch = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //page7
        foreach (var item in page7) item.SetActive(false);
        SaveManager.instance.activeSave.page7_Unlocked = false;
        GameManager.instance.page7_Unlocked = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        GameManager.instance.crossedRavine = false;

        //page8
        foreach (var item in page8) item.SetActive(false);
        SaveManager.instance.activeSave.page8_Unlocked = false;
        GameManager.instance.page8_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page5()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;


        //page55A
        foreach (var item in page55A) item.SetActive(false);
        SaveManager.instance.activeSave.page55A_Unlocked = false;
        GameManager.instance.page55A_Unlocked = false;

        //page5
        foreach (var item in page5) item.SetActive(true);
        SaveManager.instance.activeSave.page5_Unlocked = true;
        GameManager.instance.page5_Unlocked = true;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page5v2
        foreach (var item in page5v2) item.SetActive(false);
        SaveManager.instance.activeSave.page5v2_Unlocked = false;
        GameManager.instance.page5v2_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page65A
        foreach (var item in page65A) item.SetActive(false);
        SaveManager.instance.activeSave.page65A_Unlocked = false;
        GameManager.instance.page65A_Unlocked = false;

        //page6v1
        foreach (var item in page6v1) item.SetActive(false);
        SaveManager.instance.activeSave.page6v1_Unlocked = false;
        GameManager.instance.page6v1_Unlocked = false;

        //page6v2
        foreach (var item in page6v2) item.SetActive(false);
        SaveManager.instance.activeSave.page6v2_Unlocked = false;
        GameManager.instance.page6v2_Unlocked = false;

        SaveManager.instance.activeSave.visitedWitch = false;
        GameManager.instance.visitedWitch = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //page7
        foreach (var item in page7) item.SetActive(false);
        SaveManager.instance.activeSave.page7_Unlocked = false;
        GameManager.instance.page7_Unlocked = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        GameManager.instance.crossedRavine = false;

        //page8
        foreach (var item in page8) item.SetActive(false);
        SaveManager.instance.activeSave.page8_Unlocked = false;
        GameManager.instance.page8_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page55A()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;


        //page55A
        foreach (var item in page55A) item.SetActive(true);
        SaveManager.instance.activeSave.page55A_Unlocked = true;
        GameManager.instance.page55A_Unlocked = true;


        //page5v2
        foreach (var item in page5v2) item.SetActive(false);
        SaveManager.instance.activeSave.page5v2_Unlocked = false;
        GameManager.instance.page5v2_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page65A
        foreach (var item in page65A) item.SetActive(false);
        SaveManager.instance.activeSave.page65A_Unlocked = false;
        GameManager.instance.page65A_Unlocked = false;

        //page6v1
        foreach (var item in page6v1) item.SetActive(false);
        SaveManager.instance.activeSave.page6v1_Unlocked = false;
        GameManager.instance.page6v1_Unlocked = false;

        //page6v2
        foreach (var item in page6v2) item.SetActive(false);
        SaveManager.instance.activeSave.page6v2_Unlocked = false;
        GameManager.instance.page6v2_Unlocked = false;

        SaveManager.instance.activeSave.visitedWitch = false;
        GameManager.instance.visitedWitch = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //page7
        foreach (var item in page7) item.SetActive(false);
        SaveManager.instance.activeSave.page7_Unlocked = false;
        GameManager.instance.page7_Unlocked = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        GameManager.instance.crossedRavine = false;

        //page8
        foreach (var item in page8) item.SetActive(false);
        SaveManager.instance.activeSave.page8_Unlocked = false;
        GameManager.instance.page8_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page6v1()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;


        //page55A
        foreach (var item in page55A) item.SetActive(false);
        SaveManager.instance.activeSave.page55A_Unlocked = false;
        GameManager.instance.page55A_Unlocked = false;


        //page5v2
        foreach (var item in page5v2) item.SetActive(false);
        SaveManager.instance.activeSave.page5v2_Unlocked = false;
        GameManager.instance.page5v2_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page65A
        foreach (var item in page65A) item.SetActive(false);
        SaveManager.instance.activeSave.page65A_Unlocked = false;
        GameManager.instance.page65A_Unlocked = false;

        //page6v1
        foreach (var item in page6v1) item.SetActive(true);
        SaveManager.instance.activeSave.page6v1_Unlocked = true;
        GameManager.instance.page6v1_Unlocked = true;

        //page6v2
        foreach (var item in page6v2) item.SetActive(false);
        SaveManager.instance.activeSave.page6v2_Unlocked = false;
        GameManager.instance.page6v2_Unlocked = false;

        SaveManager.instance.activeSave.visitedWitch = false;
        GameManager.instance.visitedWitch = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //page7
        foreach (var item in page7) item.SetActive(false);
        SaveManager.instance.activeSave.page7_Unlocked = false;
        GameManager.instance.page7_Unlocked = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        GameManager.instance.crossedRavine = false;

        //page8
        foreach (var item in page8) item.SetActive(false);
        SaveManager.instance.activeSave.page8_Unlocked = false;
        GameManager.instance.page8_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page6v2()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;


        //page55A
        foreach (var item in page55A) item.SetActive(false);
        SaveManager.instance.activeSave.page55A_Unlocked = false;
        GameManager.instance.page55A_Unlocked = false;


        //page5v2
        foreach (var item in page5v2) item.SetActive(false);
        SaveManager.instance.activeSave.page5v2_Unlocked = false;
        GameManager.instance.page5v2_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page65A
        foreach (var item in page65A) item.SetActive(false);
        SaveManager.instance.activeSave.page65A_Unlocked = false;
        GameManager.instance.page65A_Unlocked = false;

        //page6v1
        foreach (var item in page6v1) item.SetActive(false);
        SaveManager.instance.activeSave.page6v1_Unlocked = false;
        GameManager.instance.page6v1_Unlocked = false;

        //page6v2
        foreach (var item in page6v2) item.SetActive(true);
        SaveManager.instance.activeSave.page6v2_Unlocked = true;
        GameManager.instance.page6v2_Unlocked = true;

        SaveManager.instance.activeSave.visitedWitch = false;
        GameManager.instance.visitedWitch = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //page7
        foreach (var item in page7) item.SetActive(false);
        SaveManager.instance.activeSave.page7_Unlocked = false;
        GameManager.instance.page7_Unlocked = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        GameManager.instance.crossedRavine = false;

        //page8
        foreach (var item in page8) item.SetActive(false);
        SaveManager.instance.activeSave.page8_Unlocked = false;
        GameManager.instance.page8_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page65A()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;


        //page5v2
        foreach (var item in page5v2) item.SetActive(false);
        SaveManager.instance.activeSave.page5v2_Unlocked = false;
        GameManager.instance.page5v2_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;

        //page65A
        foreach (var item in page65A) item.SetActive(true);
        SaveManager.instance.activeSave.page65A_Unlocked = true;
        GameManager.instance.page65A_Unlocked = true;


        //page7
        foreach (var item in page7) item.SetActive(false);
        SaveManager.instance.activeSave.page7_Unlocked = false;
        GameManager.instance.page7_Unlocked = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        GameManager.instance.crossedRavine = false;

        //page8
        foreach (var item in page8) item.SetActive(false);
        SaveManager.instance.activeSave.page8_Unlocked = false;
        GameManager.instance.page8_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page5v2()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;


        //page5v2
        foreach (var item in page5v2) item.SetActive(true);
        SaveManager.instance.activeSave.page5v2_Unlocked = true;
        GameManager.instance.page5v2_Unlocked = false;

        SaveManager.instance.activeSave.dejaVu = 0;
        GameManager.instance.dejaVu = 0;


        //page7
        foreach (var item in page7) item.SetActive(false);
        SaveManager.instance.activeSave.page7_Unlocked = false;
        GameManager.instance.page7_Unlocked = false;

        SaveManager.instance.activeSave.crossedRavine = false;
        GameManager.instance.crossedRavine = false;

        //page8
        foreach (var item in page8) item.SetActive(false);
        SaveManager.instance.activeSave.page8_Unlocked = false;
        GameManager.instance.page8_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page7()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;


        //page7
        foreach (var item in page7) item.SetActive(true);
        SaveManager.instance.activeSave.page7_Unlocked = true;
        GameManager.instance.page7_Unlocked = true;

        SaveManager.instance.activeSave.crossedRavine = false;
        GameManager.instance.crossedRavine = false;

        //page8
        foreach (var item in page8) item.SetActive(false);
        SaveManager.instance.activeSave.page8_Unlocked = false;
        GameManager.instance.page8_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page8()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;

        //page8
        foreach (var item in page8) item.SetActive(true);
        SaveManager.instance.activeSave.page8_Unlocked = true;
        GameManager.instance.page8_Unlocked = true;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9A
        foreach (var item in page9A) item.SetActive(false);
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.waitAtTheDoor = 0;
        GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page9A()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;

        //page9A
        if (SaveManager.instance.activeSave.page9A_Unlocked == true && SaveManager.instance.activeSave.waitAtTheDoor == 0)
        {
            page9A[0].SetActive(true);
            page9A[1].SetActive(true);
            page9A[2].SetActive(false);
        }
        if (SaveManager.instance.activeSave.page9A_Unlocked == true && SaveManager.instance.activeSave.waitAtTheDoor != 0)
        {
            page9A[0].SetActive(true);
            page9A[1].SetActive(true);
            page9A[2].SetActive(true);
        }
        else
        {
            foreach (var item in page9A)
                item.SetActive(false);
        }
        SaveManager.instance.activeSave.page9A_Unlocked = false;
        GameManager.instance.page9A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        //SaveManager.instance.activeSave.waitAtTheDoor = 0;
        //GameManager.instance.waitAtTheDoor = 0;

        //page9B
        foreach (var item in page9B) item.SetActive(false);
        SaveManager.instance.activeSave.page9B_Unlocked = false;
        GameManager.instance.page9B_Unlocked = false;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page9B()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;

        //page9B
        if (SaveManager.instance.activeSave.page9B_Unlocked == true && SaveManager.instance.activeSave.page9A_Unlocked == false)
        {
            page9B[0].SetActive(true);
            page9B[1].SetActive(true);
            page9B[2].SetActive(false);
        }
        else if (SaveManager.instance.activeSave.page9B_Unlocked == true && SaveManager.instance.activeSave.page9A_Unlocked == true)
        {
            page9B[0].SetActive(true);
            page9B[1].SetActive(false);
            page9B[2].SetActive(true);
        }

        else
        {
            foreach (var item in page9B)
                item.SetActive(false);
        }
        SaveManager.instance.activeSave.page9B_Unlocked = true;
        GameManager.instance.page9B_Unlocked = true;

        SaveManager.instance.activeSave.heardVoice = false;
        GameManager.instance.heardVoice = false;

        //page9C
        foreach (var item in page9C) item.SetActive(false);
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page9C()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;

        //page9C
        if (SaveManager.instance.activeSave.page9C_Unlocked == true && SaveManager.instance.activeSave.page9A_Unlocked == false)
        {
            page9C[0].SetActive(true);
            page9C[1].SetActive(true);
            page9C[2].SetActive(false);
        }
        else if (SaveManager.instance.activeSave.page9C_Unlocked == true && SaveManager.instance.activeSave.page9A_Unlocked == true)
        {
            page9C[0].SetActive(true);
            page9C[1].SetActive(false);
            page9C[2].SetActive(true);
        }
        else
        {
            foreach (var item in page9C)
                item.SetActive(false);
        }
        SaveManager.instance.activeSave.page9C_Unlocked = false;
        GameManager.instance.page9C_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(false);
        SaveManager.instance.activeSave.page10_Unlocked = false;
        GameManager.instance.page10_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page10()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;

        //page10
        foreach (var item in page10) item.SetActive(true);
        SaveManager.instance.activeSave.page10_Unlocked = true;
        GameManager.instance.page10_Unlocked = true;

        //page11A
        foreach (var item in page11A) item.SetActive(false);
        SaveManager.instance.activeSave.page11A_Unlocked = false;
        GameManager.instance.page11A_Unlocked = false;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }

    public void Page11A()
    {
        //f1b
        foreach (var item in f1B) item.SetActive(false);
        SaveManager.instance.activeSave.f1B_Unlocked = false;
        GameManager.instance.f1B_Unlocked = false;

        //f3O
        foreach (var item in f3O) item.SetActive(false);
        SaveManager.instance.activeSave.f3O_1_Unlocked = false;
        GameManager.instance.f3O_1_Unlocked = false;
        SaveManager.instance.activeSave.f3O_2_Unlocked = false;
        GameManager.instance.f3O_2_Unlocked = false;
        SaveManager.instance.activeSave.f3O_3_Unlocked = false;
        GameManager.instance.f3O_3_Unlocked = false;

        //f4G
        foreach (var item in f4G) item.SetActive(false);
        SaveManager.instance.activeSave.f4G_Unlocked = false;
        GameManager.instance.f4G_Unlocked = false;

        //f5T
        foreach (var item in f5T) item.SetActive(false);
        SaveManager.instance.activeSave.f5T_Unlocked = false;
        GameManager.instance.f5T_Unlocked = false;

        //page11A
        foreach (var item in page11A) item.SetActive(true);
        SaveManager.instance.activeSave.page11A_Unlocked = true;
        GameManager.instance.page11A_Unlocked = true;

        SaveManager.instance.activeSave.setHomeFromTower = false;
        GameManager.instance.setHomeFromTower = false;

        SaveManager.instance.activeSave.keptTheRing = false;
        GameManager.instance.keptTheRing = false;

        //PS
        foreach (var item in ps) item.SetActive(false);
        SaveManager.instance.activeSave.pS_Unlocked = false;
        GameManager.instance.pS_Unlocked = false;

        //pf1b
        foreach (var item in pf1b) item.SetActive(false);
        SaveManager.instance.activeSave.pF1B_Unlocked = false;
        GameManager.instance.pF1B_Unlocked = false;

        //pf2b
        foreach (var item in pf2b) item.SetActive(false);
        SaveManager.instance.activeSave.pF2B_Unlocked = false;
        GameManager.instance.pF2B_Unlocked = false;

        SaveManager.instance.activeSave.killedByWitch = false;
        GameManager.instance.killedByWitch = false;

        //pf3o
        foreach (var item in pf3o) item.SetActive(false);
        SaveManager.instance.activeSave.pF3O_1_Unlocked = false;
        GameManager.instance.pF3O_1_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_2_Unlocked = false;
        GameManager.instance.pF3O_2_Unlocked = false;
        SaveManager.instance.activeSave.pF3O_3_Unlocked = false;
        GameManager.instance.pF3O_3_Unlocked = false;

        //pf4g
        foreach (var item in pf4g) item.SetActive(false);
        SaveManager.instance.activeSave.pF4G_Unlocked = false;
        GameManager.instance.pF4G_Unlocked = false;

        //pf5g
        foreach (var item in pf5t) item.SetActive(false);
        SaveManager.instance.activeSave.pF5T_Unlocked = false;
        GameManager.instance.pF5T_Unlocked = false;
    }


}


