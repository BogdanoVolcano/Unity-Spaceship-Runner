﻿using System;
using Runtime.Source.Tools.CameraShaker.Enums;
using Runtime.Source.Tools.CameraShaker.Interfaces;
using UnityEngine;

namespace Runtime.Source.Tools.CameraShaker
{
    // Based on plugin 'MilkShake Camera Shaker' 
    // Link to the Asset store page: https://assetstore.unity.com/packages/tools/camera/milkshake-camera-shaker-165604
    // Great thanks!

    /// <summary>
    /// An implementation of the IShakeParameters interface.
    /// </summary>
    [Serializable]
    public class ShakeParameters : IShakeParameters
    {
        [Header("Shake Type")]
        [SerializeField]
        private ShakeType shakeType;

        [Header("Shake Strength")]
        [SerializeField]
        private float strength;
        [SerializeField]
        private float roughness;

        [Header("Fade")]
        [SerializeField]
        private float fadeIn;
        [SerializeField]
        private float fadeOut;

        [Header("Shake Influence")]
        [SerializeField]
        private Vector3 positionInfluence;
        [SerializeField]
        private Vector3 rotationInfluence;

        public ShakeParameters() { }

        public ShakeParameters(IShakeParameters original)
        {
            shakeType = original.ShakeType;

            strength = original.Strength;
            roughness = original.Roughness;

            fadeIn = original.FadeIn;
            fadeOut = original.FadeOut;

            positionInfluence = original.PositionInfluence;
            rotationInfluence = original.RotationInfluence;
        }

        /// <summary>
        /// The type of shake (One-Shot or Sustained)
        /// </summary>
        public ShakeType ShakeType
        {
            get { return shakeType; }
            set { shakeType = value; }
        }

        /// <summary>
        /// The intensity / magnitude of the shake.
        /// </summary>
        public float Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        /// <summary>
        /// The roughness of the shake.
        /// Lower values are slower and smoother, higher values are faster and noisier.
        /// </summary>
        public float Roughness
        {
            get { return roughness; }
            set { roughness = value; }
        }

        /// <summary>
        /// The time, in seconds, for the shake to fade in.
        /// </summary>
        public float FadeIn
        {
            get { return fadeIn; }
            set { fadeIn = value; }
        }
        /// <summary>
        /// The time, in seconds, for the shake to fade out.
        /// </summary>
        public float FadeOut
        {
            get { return fadeOut; }
            set { fadeOut = value; }
        }

        /// <summary>
        /// How much influence the shake has over the camera's position.
        /// All values are valid, even numbers greater than 1 and negative numbers.
        /// </summary>
        public Vector3 PositionInfluence
        {
            get { return positionInfluence; }
            set { positionInfluence = value; }
        }
        /// <summary>
        /// How much influence the shake has over the camera's rotation.
        /// All values are valid, even numbers greater than 1 and negative numbers.
        /// </summary>
        public Vector3 RotationInfluence
        {
            get { return rotationInfluence; }
            set { rotationInfluence = value; }
        }
    }
}