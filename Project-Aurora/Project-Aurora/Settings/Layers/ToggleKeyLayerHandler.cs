﻿using System.ComponentModel;
using System.Drawing;
using Aurora.EffectsEngine;
using Aurora.Profiles;
using Newtonsoft.Json;

namespace Aurora.Settings.Layers {

    public class ToggleKeyLayerHandlerProperties : LayerHandlerProperties2Color<ToggleKeyLayerHandlerProperties> {

        public ToggleKeyLayerHandlerProperties() : base() { }
        public ToggleKeyLayerHandlerProperties(bool assign_default) : base(assign_default) { }

        public Keybind[] _TriggerKeys { get; set; }
        [JsonIgnore]
        public Keybind[] TriggerKeys { get { return Logic._TriggerKeys ?? _TriggerKeys ?? new Keybind[] { }; } }

        public override void Default() {
            base.Default();
            _TriggerKeys = new Keybind[] { };
        }

    }

    public class ToggleKeyLayerHandler : LayerHandler<ToggleKeyLayerHandlerProperties>
    {
        private bool _state;
        private readonly EffectLayer _layer = new("ToggleKeyLayer");
        private readonly SolidBrush _primaryBrush;
        private readonly SolidBrush _secondaryBrush;

        public ToggleKeyLayerHandler()
        {
            _primaryBrush = new SolidBrush(Properties.PrimaryColor);
            _secondaryBrush = new SolidBrush(Properties.SecondaryColor);
            Global.InputEvents.KeyDown += InputEvents_KeyDown;
        }

        public override void Dispose()
        {
            base.Dispose();
            Global.InputEvents.KeyDown -= InputEvents_KeyDown;
        }

        protected override System.Windows.Controls.UserControl CreateControl()
        {
            return new Control_ToggleKeyLayer(this);
        }

        public override EffectLayer Render(IGameState gamestate)
        {
            _layer.Set(Properties.Sequence, _state ? _primaryBrush : _secondaryBrush);
            return _layer;
        }

        protected override void PropertiesChanged(object sender, PropertyChangedEventArgs args)
        {
            base.PropertiesChanged(sender, args);
            _primaryBrush.Color = Properties.PrimaryColor;
            _secondaryBrush.Color = Properties.SecondaryColor;
        }

        private void InputEvents_KeyDown(object sender, SharpDX.RawInput.KeyboardInputEventArgs e)
        {
            foreach (var kb in Properties.TriggerKeys)
                if (kb.IsPressed())
                    _state = !_state;
        }
    }
}
