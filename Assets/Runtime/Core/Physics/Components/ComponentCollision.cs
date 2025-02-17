﻿using System.Runtime.CompilerServices;
using Pixeye.Actors;
using Unity.IL2CPP.CompilerServices;

namespace Runtime.Core.Physics.Components
{
    public class ComponentCollision
    {
        public CollisionPoints CollisionPoints;
        public ent ReceiverEntity;
        public ent SenderEntity;
    }

    #region HELPERS

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    static partial class Component
    {
        public const string Collision = "Game.Source.ComponentCollision";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref ComponentCollision ComponentCollision(in this ent entity) =>
            ref Storage<ComponentCollision>.components[entity.id];
    }

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    sealed class StorageComponentCollision : Storage<ComponentCollision>
    {
        public override ComponentCollision Create() => new ComponentCollision();

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