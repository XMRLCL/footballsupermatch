using System;
using System.Collections;
using System.Collections.Generic;
using Scripts.GameData;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class takeexerciseManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text me;

    [SerializeField]
    private TMP_Dropdown te;
    
    [SerializeField]
    private List<TMP_Text> fl;
    
    private int _id;

    private float time;

    private string[] df = new string[3]
    {
        "普通锻炼：80000",
        "超强锻炼：500000",
        "最强锻炼：600000"
    };

    private int[][] tei = new int[11][];

    private void Awake()
    {
        for (int f = 0; f < tei.Length; f++)
        {
            tei[f] = new int[3];
        }
    }

    private void Update()
    {
        gettakeexercise();
        for (int f = 0; f < 3; f++)
        {
            if (tei[_id][f] > 0)
            {
                fl[f].text = "等待" + tei[_id][f] + "秒";
            }
            else
            {
                fl[f].text = df[f];
            }
        }
        setplayer();
    }

    private void OnEnable()
    {
        updatetakeexercise();
        setplayer();
    }

    private IEnumerator takeexercise(int _index, float deltetime, int st)
    {
        for (int i = 0; i < deltetime; i++)
        {
            yield return new WaitForSeconds(1);
            tei[_index][st] -= 1;
        }

        PlayerManager.Instance.teamEntry.Players[_index].acceleration += Random.Range(1, (int) deltetime);
    }

    private void updatetakeexercise()
    {
        te.options = new List<TMP_Dropdown.OptionData>();
        
        for (int f = 0; f < 11; f++)
        {
            te.options.Add(new TMP_Dropdown.OptionData(PlayerManager.Instance.teamEntry.Players[f].name));
        }
    }

    public void setStrength(int players)
    {
        gettakeexercise();
        if (tei[_id][0] > 0) return;
        if (tei[_id][1] > 0) return;
        if (tei[_id][2] > 0) return;
        float delttime = 30;
        if (players == 1)
        {
            delttime = 50;
        }

        if (players == 2)
        {
            delttime = 55;
        }
        tei[_id][players] = (int) delttime;
        StartCoroutine(takeexercise(_id, delttime, players));
    }
    

    private void setplayer()
    {
        me.text = "体能" + PlayerManager.Instance.teamEntry.Players[_id].strength + "\n"
            + "加速度" + PlayerManager.Instance.teamEntry.Players[_id].acceleration + "\n"
            + "速度" + PlayerManager.Instance.teamEntry.Players[_id].topSpeed + "\n"
            + "带足球的速度" + PlayerManager.Instance.teamEntry.Players[_id].dribbleSpeed + "\n"
            + "跳跃" + PlayerManager.Instance.teamEntry.Players[_id].jump + "\n"
            + "拦截" + PlayerManager.Instance.teamEntry.Players[_id].tackling + "\n"
            + "球保持" + PlayerManager.Instance.teamEntry.Players[_id].ballKeeping + "\n"
            + "传" + PlayerManager.Instance.teamEntry.Players[_id].passing + "\n"
            + "长传球" + PlayerManager.Instance.teamEntry.Players[_id].longBall + "\n"
            + "灵敏度" + PlayerManager.Instance.teamEntry.Players[_id].agility + "\n"
            + "踢球" + PlayerManager.Instance.teamEntry.Players[_id].shooting + "\n"
            + "踢球力" + PlayerManager.Instance.teamEntry.Players[_id].shootPower + "\n"
            + "站位" + PlayerManager.Instance.teamEntry.Players[_id].positioning + "\n"
            + "反馈力" + PlayerManager.Instance.teamEntry.Players[_id].reaction + "\n"
            + "控球" + PlayerManager.Instance.teamEntry.Players[_id].ballControl + "\n";
    }

    public void gettakeexercise()
    {
        _id = te.value;
    }
}
