/*
	Author:			hzf@neibour.com
	CreateDate:		2019-08-07 16:49:39
	Desc:			脚本类.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace ECS.Game
{
    [Game]
	public class LogComponent : IComponent 
	{
        public string Message;
	}
}