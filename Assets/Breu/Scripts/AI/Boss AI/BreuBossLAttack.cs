﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breu
{
    public class BreuBossLAttack : BreuBossState
    {
        
        public override BreuBossState Update()
        {
            Debug.Log("Left Attacking");//for testing, comment out

            return new BreuBossIdle();
        }
    }
}