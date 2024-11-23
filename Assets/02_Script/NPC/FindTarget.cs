using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "FindTarget", story: "[Self] 위치 와 [Target] 의 위치를 특정하여 [State] 를 변경", category: "Action", id: "48dc96e757876e056721cf42e2cb01b8")]
public partial class FindTargetAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Self;
    [SerializeReference] public BlackboardVariable<GameObject> Target;
    [SerializeReference] public BlackboardVariable<State> State;
    protected override Status OnUpdate()
    {
        if(Target.Value == null)
        {
            return Status.Success;
        }

        if(DistanceChecker.IsTargetClose(Self.Value, Target.Value))
        {
            State.Value = global::State.Attack;
            return Status.Success;
        }

        State.Value = global::State.Move;

        return Status.Success;
    }
}

