﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Controls;
using Aurora.Devices;
using Aurora.EffectsEngine;
using Aurora.Profiles.CSGO.GSI;
using Aurora.Profiles.CSGO.GSI.Nodes;
using Aurora.Settings;
using Aurora.Settings.Layers;
using Newtonsoft.Json;

namespace Aurora.Profiles.CSGO.Layers
{
    public class CSGOKillIndicatorLayerHandlerProperties : LayerHandlerProperties2Color<CSGOKillIndicatorLayerHandlerProperties>
    {
        public Color? _RegularKillColor { get; set; }

        [JsonIgnore]
        public Color RegularKillColor => Logic._RegularKillColor ?? _RegularKillColor ?? Color.Empty;

        public Color? _HeadshotKillColor { get; set; }

        [JsonIgnore]
        public Color HeadshotKillColor => Logic._HeadshotKillColor ?? _HeadshotKillColor ?? Color.Empty;

        public CSGOKillIndicatorLayerHandlerProperties()
        { }

        public CSGOKillIndicatorLayerHandlerProperties(bool assign_default = false) : base(assign_default) { }

        public override void Default()
        {
            base.Default();

            _Sequence = new KeySequence(new DeviceKey[] { DeviceKeys.G1, DeviceKeys.G2, DeviceKeys.G3, DeviceKeys.G4, DeviceKeys.G5 });
            _RegularKillColor = Color.FromArgb(255, 204, 0);
            _HeadshotKillColor = Color.FromArgb(255, 0, 0);
        }

    }

    public class CSGOKillIndicatorLayerHandler : LayerHandler<CSGOKillIndicatorLayerHandlerProperties>
    {
        private enum RoundKillType
        {
            None,
            Regular,
            Headshot
        }

        private List<RoundKillType> roundKills = new();
        private int _lastCountedKill;
        private readonly EffectLayer _killsIndicatorLayer = new("CSGO - Kills Indicator");

        protected override UserControl CreateControl()
        {
            return new Control_CSGOKillIndicatorLayer(this);
        }

        public override EffectLayer Render(IGameState state)
        {
            if (state is not GameState_CSGO csgostate) return _killsIndicatorLayer;

            if (_lastCountedKill != csgostate.Player.State.RoundKills)
            {
                if (csgostate.Player.State.RoundKills == 0 ||
                    (csgostate.Round.WinTeam == RoundWinTeam.Undefined && csgostate.Previously.Round.WinTeam != RoundWinTeam.Undefined) ||
                    (csgostate.Player.State.Health == 100 && ((csgostate.Previously.Player.State.Health > -1 && csgostate.Previously.Player.State.Health < 100) || (csgostate.Round.WinTeam == RoundWinTeam.Undefined && csgostate.Previously.Round.WinTeam != RoundWinTeam.Undefined)) && csgostate.Provider.SteamID.Equals(csgostate.Player.SteamID))
                   )
                    roundKills.Clear();
                if (csgostate.Previously.Player.State.RoundKills != -1 && csgostate.Player.State.RoundKills != -1 && csgostate.Previously.Player.State.RoundKills < csgostate.Player.State.RoundKills && csgostate.Provider.SteamID.Equals(csgostate.Player.SteamID))
                {
                    if (csgostate.Previously.Player.State.RoundKillHS != -1 && csgostate.Player.State.RoundKillHS != -1 && csgostate.Previously.Player.State.RoundKillHS < csgostate.Player.State.RoundKillHS)
                        roundKills.Add(RoundKillType.Headshot);
                    else
                        roundKills.Add(RoundKillType.Regular);
                }

                _lastCountedKill = csgostate.Player.State.RoundKills;
            }

            if (!csgostate.Provider.SteamID.Equals(csgostate.Player.SteamID)) return _killsIndicatorLayer;
            for (var pos = 0; pos < Properties.Sequence.keys.Count; pos++)
            {
                if (pos < roundKills.Count)
                {
                    switch (roundKills[pos])
                    {
                        case RoundKillType.Regular:
                            _killsIndicatorLayer.Set(Properties.Sequence.keys[pos], Properties.RegularKillColor);
                            break;
                        case RoundKillType.Headshot:
                            _killsIndicatorLayer.Set(Properties.Sequence.keys[pos], Properties.HeadshotKillColor);
                            break;
                        case RoundKillType.None:
                            _killsIndicatorLayer.Set(Properties.Sequence.keys[pos], Color.Empty);
                            break;
                    }
                }
            }

            return _killsIndicatorLayer;
        }

        public override void SetApplication(Application profile)
        {
            (Control as Control_CSGOKillIndicatorLayer).SetProfile(profile);
            base.SetApplication(profile);
        }
    }
}