using System.Collections;
using System.Collections.Generic;
using Scripts.GameData;
using UnityEngine;
using XP.TableModel;

public class TagManager : MonoBehaviour
{
    [SerializeField]
    private Transform[] pag;

    [SerializeField]
    private Table _Table;

    public void getPag(int _index)
    {
        for (int f = 0; f < 3; f++)
        {
            pag[f].gameObject.SetActive(false);
        }
        pag[_index].gameObject.SetActive(true);
        if (_index == 2)
        {
            List<GameInformation> ga = new List<GameInformation>();
            for (int f = 0; f < PlayerManager.Instance.teamEntry.Players.Length; f++)
            {
                GameInformation gameInformation = new GameInformation();
                gameInformation.posistion = PlayerManager.Instance.teamEntry.Players[f].Position.ToString();
                gameInformation.Name = PlayerManager.Instance.teamEntry.Players[f].name;
                gameInformation.Acceleration = PlayerManager.Instance.teamEntry.Players[f].acceleration;
                gameInformation.Agility = PlayerManager.Instance.teamEntry.Players[f].agility;
                gameInformation.Jump = PlayerManager.Instance.teamEntry.Players[f].jump;
                gameInformation.Passing = PlayerManager.Instance.teamEntry.Players[f].passing;
                gameInformation.Positioning = PlayerManager.Instance.teamEntry.Players[f].positioning;
                gameInformation.Reaction = PlayerManager.Instance.teamEntry.Players[f].reaction;
                gameInformation.Shooting = PlayerManager.Instance.teamEntry.Players[f].shooting;
                gameInformation.Strength = PlayerManager.Instance.teamEntry.Players[f].strength;
                gameInformation.Tackling = PlayerManager.Instance.teamEntry.Players[f].tackling;
                gameInformation.BallControl = PlayerManager.Instance.teamEntry.Players[f].ballControl;
                gameInformation.BallKeeping = PlayerManager.Instance.teamEntry.Players[f].ballKeeping;
                gameInformation.DribbleSpeed = PlayerManager.Instance.teamEntry.Players[f].dribbleSpeed;
                gameInformation.LongBall = PlayerManager.Instance.teamEntry.Players[f].longBall;
                gameInformation.ShootPower = PlayerManager.Instance.teamEntry.Players[f].shootPower;
                gameInformation.TopSpeed = PlayerManager.Instance.teamEntry.Players[f].topSpeed;
                ga.Add(gameInformation);
            }
            
            _Table._BindArray(ga);
        }
    }
}
