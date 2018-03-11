﻿// <copyright file="PlayerSettings.cs" company="Jan Ivar Z. Carlsen">
// Copyright (c) 2018 Jan Ivar Z. Carlsen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace SwipeUp
{
    using UnityEngine;

    public static class PlayerSettings
    {
        private const string muteMusicKey = "MuteMusic";
        private const string muteSfxKey = "MuteSFX";
        private const string volumeMusicKey = "VolumeMusic";
        private const string volumeSfxKey = "VolumeSFX";
        private const string howToPlayShownKey = "HowToPlayShown";

        public static float MusicVolume { get; set; }
        public static float SfxVolume { get; set; }
        public static bool MuteMusic { get; set; }
        public static bool MuteSfx { get; set; }
        public static bool HowToPlayShown { get; set; }

        public static bool MovementEnabled { get; set; }

        public static void Load()
        {
            MusicVolume = PlayerPrefs.GetFloat(volumeMusicKey, 1f);
            SfxVolume = PlayerPrefs.GetFloat(volumeSfxKey, 1f);
            MuteMusic = PlayerPrefs.GetInt(muteMusicKey, 0) == 1;
            MuteSfx = PlayerPrefs.GetInt(muteSfxKey, 0) == 1;
            HowToPlayShown = PlayerPrefs.GetInt(howToPlayShownKey, 0) == 1;
        }

        public static void Save()
        {
            PlayerPrefs.SetFloat(volumeMusicKey, MusicVolume);
            PlayerPrefs.SetFloat(volumeSfxKey, SfxVolume);
            PlayerPrefs.SetInt(muteMusicKey, MuteMusic ? 1 : 0);
            PlayerPrefs.SetInt(muteSfxKey, MuteSfx ? 1 : 0);
            PlayerPrefs.SetInt(howToPlayShownKey, HowToPlayShown ? 1 : 0);
            PlayerPrefs.Save();
        }
    }
}
