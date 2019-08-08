/*
	Author:			hzf@neibour.com
	CreateDate:		2019-08-07 17:35:19
	Desc:			脚本类.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Entitas;

namespace ECS.Game
{
	public class TutorialSystems : Feature 
	{
        public TutorialSystems(Contexts contexts) : base ("Tutorial Systems")
        {
            Add(new LogSystem(contexts));
        }
	}
}