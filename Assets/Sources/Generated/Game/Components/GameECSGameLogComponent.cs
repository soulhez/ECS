//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ECS.Game.LogComponent eCSGameLog { get { return (ECS.Game.LogComponent)GetComponent(GameComponentsLookup.ECSGameLog); } }
    public bool hasECSGameLog { get { return HasComponent(GameComponentsLookup.ECSGameLog); } }

    public void AddECSGameLog(string newMessage) {
        var index = GameComponentsLookup.ECSGameLog;
        var component = CreateComponent<ECS.Game.LogComponent>(index);
        component.Message = newMessage;
        AddComponent(index, component);
    }

    public void ReplaceECSGameLog(string newMessage) {
        var index = GameComponentsLookup.ECSGameLog;
        var component = CreateComponent<ECS.Game.LogComponent>(index);
        component.Message = newMessage;
        ReplaceComponent(index, component);
    }

    public void RemoveECSGameLog() {
        RemoveComponent(GameComponentsLookup.ECSGameLog);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherECSGameLog;

    public static Entitas.IMatcher<GameEntity> ECSGameLog {
        get {
            if (_matcherECSGameLog == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ECSGameLog);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherECSGameLog = matcher;
            }

            return _matcherECSGameLog;
        }
    }
}
