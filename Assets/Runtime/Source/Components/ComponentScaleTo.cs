﻿using System;
using System.Runtime.CompilerServices;
using Pixeye.Actors;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Runtime.Source.Components
{
    [Serializable]
    public class ComponentScaleTo
    {
        public Vector3 startScale = Vector3.zero;
        public Vector3 finalScale = Vector3.one;
        public float scaleSpeed = 2;
    }

    #region HELPERS

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    static partial class Component
    {
        public const string Scalable = "Game.Source.ComponentScalable";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref ComponentScaleTo ComponentScaleTo(in this ent entity) =>
            ref Storage<ComponentScaleTo>.components[entity.id];
    }

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    sealed class StorageComponentScalable : Storage<ComponentScaleTo>
    {
        public override ComponentScaleTo Create() => new ComponentScaleTo();

        // Use for cleaning components that were removed at the current frame.
        public override void Dispose(indexes disposed)
        {
            foreach (var id in disposed)
            {
                ref var component = ref components[id];
            }
        }
    }

    #endregion
}