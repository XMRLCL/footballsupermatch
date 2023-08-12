using System;
using System.Collections.Generic;
using FStudio.Data;
using Scripts.GameData;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class lineupManager : MonoBehaviour
    {
        [SerializeField]
        private Transform footllber;

        [SerializeField]
        private Button[] lineupTransfrom;

        [SerializeField]
        private Transform[] lineupu;

        [SerializeField]
        private TMP_Dropdown teamlienup;

        private string[] fluname = new string[11];

        private int luID;

        private void Start()
        {
            for (int f = 0; f < 18; f++)
            {
                teamlienup.options.Add(new TMP_Dropdown.OptionData(((Formations) f).ToString()));
            }

            teamlienup.value = (int)PlayerManager.Instance.teamEntry.Formation;
            sellineup((int)PlayerManager.Instance.teamEntry.Formation);
        }

        private void sellineup(int _index)
        {
            for (int f = 0; f < lineupu.Length; f++)
            {
                lineupu[f].gameObject.SetActive(false);
            }
            
            lineupu[_index].gameObject.SetActive(true);
        }

        public void SetFootllber(int _playerID)
        {
            luID = _playerID;
            footllber.gameObject.SetActive(true);
            footllber.position = lineupTransfrom[_playerID].transform.position;
        }

        public void UpdateFootlber()
        {
            // for (int f = 0; f < 11; f++)
            // {
            //     fluname[f] = PlayerManager.Instance.teamEntry.Players[f].Name;
            //     footllber.GetComponentInChildren<TMP_Dropdown>().options[f] = new TMP_Dropdown.OptionData(PlayerManager.Instance.teamEntry.Players[f].Name);
            // }
            //
            // footllber.GetComponentInChildren<TMP_Dropdown>().value = PlayerManager.Instance.GetPlayer((Formations) luID);
            PlayerManager.Instance.teamEntry.Formation = (Formations) teamlienup.value;
            sellineup(teamlienup.value);
        }
    }
}