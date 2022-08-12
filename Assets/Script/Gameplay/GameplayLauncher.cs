using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using ExampleGame.Boot;
using Agate.MVC.Core;
using ExampleGame.Module.ClickGame;

namespace ExampleGame.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";
        private ClickGameController _clickGame;

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
            new ClickGameController() 
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _clickGame.SetView(_view.ClickGameView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}
