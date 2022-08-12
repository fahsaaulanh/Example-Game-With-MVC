using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExampleGame.Module.ClickGame
{
    public class ClickGameModel : BaseModel, IClickGameModel
    {
        public int Coin { get; private set; }

        public void SetCoin(int coin)
        {
            Coin = coin;
            SetDataAsDirty();
        }

        public void AddCoin()
        {
            Debug.Log("Tes Coin: " + Coin);
            Coin++;
            SetDataAsDirty();
        }

        public void SubstractCoin()
        {
            Debug.Log("Tes Coin: " + Coin);
            Coin--;
            SetDataAsDirty();
        }
    }
}