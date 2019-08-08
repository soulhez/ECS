/*
	Author:			hzf@neibour.com
	CreateDate:		2019-08-07 17:22:52
	Desc:			脚本类.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace ECS.Game
{
	public class LogSystem : ReactiveSystem<GameEntity> 
	{
        public LogSystem(Contexts contexts) : base(contexts.game)
        {

        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach(var item in entities)
            {
                Debug.Log(item.eCSGameLog.Message);
            }
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasECSGameLog;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.ECSGameLog);
        }
	}
}