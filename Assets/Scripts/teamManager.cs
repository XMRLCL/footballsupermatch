using System;
using System.Collections;
using System.Collections.Generic;
using Scripts.GameData;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class teamManager : MonoBehaviour
{
    [SerializeField]
    private Image teamIcon;

    [SerializeField]
    private TMP_Text teamName;

    private void Start()
    {
        UpdateTeamView();
    }

    public void UpdateTeamView()
    {
        teamName.text = PlayerManager.Instance.teamEntry.TeamName;
        Texture teamLo = PlayerManager.Instance.teamEntry.TeamLogo.TeamLogoMaterial;teamIcon.sprite = Sprite.Create((Texture2D)teamLo, new Rect(0, 0, teamLo.width, teamLo.height), new Vector2(0.5f, 0.5f));
    }
}
