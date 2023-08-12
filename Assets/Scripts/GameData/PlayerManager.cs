using System;
using System.Collections.Generic;
using FStudio.Data;
using FStudio.Database;
using UnityEngine;
using UnityEngine.Serialization;

namespace Scripts.GameData
{
    public class PlayerManager : MonoBehaviour
    {
        public static PlayerManager Instance // 单例
        {
            private set
            {
                instance = value;
            }
            get
            {
                if (instance == null)
                { 
                    instance = new PlayerManager();
                }

                return instance;
            }
        }

        private static PlayerManager instance;
        
        public TeamEntry teamEntry;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        /// <summary>
        /// 设置队伍的球员
        /// </summary>
        /// <param name="_index"></param>
        /// <param name="playerEntry"></param>
        public void SetPlayer(int _index, PlayerEntry playerEntry)
        {
            teamEntry.Players[_index] = playerEntry;
        }

        /// <summary>
        /// 获取队伍球员
        /// </summary>
        /// <param name="_index"></param>
        /// <returns></returns>
        public PlayerEntry GetPlayer(int _index)
        {
            return teamEntry.Players[_index];
        }

        public int GetPlayer(Formations _focusType)
        {
            for (int f = 0; f < 11; f++)
            {
                if ((int)teamEntry.Players[f].Position == (int)_focusType)
                {
                    return f;
                }
            }

            return 1;
        }
        
        public string GetPlayer(Formations _focusType, int entry)
        {
            for (int f = 0; f < 11; f++)
            {
                if ((int)teamEntry.Players[f].Position == (int)_focusType)
                {
                    return teamEntry.Players[f].name;
                }
            }

            return null;
        }
    }
}