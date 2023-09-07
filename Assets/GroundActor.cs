using System;
using SkyBrave_Toolkit.Scripts;
using SkyBrave_Toolkit.Scripts.Components;
using UnityEngine;

[RequireComponent(typeof(SelectableObjectComponent), typeof(SpawnObjectComponent))]
public class GroundActor : MonoBehaviour
{
    private SelectableObjectComponent _selectableObjectComponent;
    private SpawnObjectComponent _spawnObjectComponent;
    private void Awake()
    {
        _selectableObjectComponent = GetComponent<SelectableObjectComponent>(); //todo: GC makro to getcomponent quickly
        _spawnObjectComponent = GetComponent<SpawnObjectComponent>();
    }

    public void SpawnObjectAtSelectedPoint()
    {
        _spawnObjectComponent.SpawnPos = _selectableObjectComponent.SelectionWorldPos;
        _spawnObjectComponent.Spawn();
    }
}
