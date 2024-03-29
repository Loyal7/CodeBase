﻿using System.Collections;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using UnityEngine;
using Common;
using Common.Tools;
//love you into disease, but no medicine can.
//Created By xxx
public class NewPlayerEvent : BaseEvent
{
    private Player player;
    public override void Start()
    {
        base.Start();
        player = GetComponent<Player>();
    }
    public override void OnEvent(EventData eventData)
    {
        string username = (string)DictTool.GetValue<byte, object>(eventData.Parameters, (byte)ParameterCode.Username);
        player.OnNewPlayerEvent(username);
    }
}
