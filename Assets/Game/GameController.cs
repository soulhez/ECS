/*
	Author:			hzf@neibour.com
	CreateDate:		2019-08-07 17:39:35
	Desc:			脚本类.
*/

using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ECS.Game
{
	public class GameController : MonoBehaviour 
	{
        Systems systems;

		// Use this for initialization
		void Start () 
		{
            var contexts = Contexts.sharedInstance;
            systems = new Feature("Systems").Add(new TutorialSystems(contexts));
            systems.Initialize();

            contexts.game.CreateEntity().AddECSGameLog("Hello World!");
            systems.Execute();
        }
	}
}