using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HISPlayerAPI;


public class Init : HISPlayerManager
{
    protected override void Awake()
    {
        base.Awake();
        SetUpPlayer();
    }
}