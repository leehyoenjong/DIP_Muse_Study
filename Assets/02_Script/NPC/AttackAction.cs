using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Attack", story: "[Target] 이 공격 당하면 삭제되고 [State] 가 Wait 이 된다", category: "Action", id: "56fae2f47a9db6e25f3acebdfba26d88")]
public partial class AttackAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Target;
    [SerializeReference] public BlackboardVariable<State> State;
    protected override Status OnStart()
    {
        Gamemanager.instance.DestoryObject(Target.Value);
        State.Value = global::State.Wait;
        return Status.Running;
    }
}

