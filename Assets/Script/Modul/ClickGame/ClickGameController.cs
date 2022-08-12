using Agate.MVC.Base;
using ExampleGame.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExampleGame.Module.ClickGame
{
	public class ClickGameController : ObjectController<ClickGameController, ClickGameModel, IClickGameModel, ClickGameView>
	{
		private void OnClickEarnCoin()
		{
			_model.AddCoin();
		}

		private void OnClickSpendCoin()
		{
			_model.SubstractCoin();
		}

		private void OnClickBack()
		{
			SceneLoader.Instance.LoadScene("Home");
		}

		public override void SetView(ClickGameView view)
		{
			base.SetView(view);
			view.SetCallbacks(OnClickEarnCoin, OnClickSpendCoin, OnClickBack);
		}
	}
}