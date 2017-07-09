﻿using Aurora.Profiles.Borderlands2.GSI;
using Aurora.Profiles.Borderlands2.Layers;
using Aurora.Settings;
using Aurora.Settings.Layers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Aurora.Profiles.Borderlands2
{
    public class Borderlands2 : Application
    {
        public Borderlands2()
            : base(new LightEventConfig { Name = "Borderlands 2", ID = "borderlands2", ProcessNames = new[] { "borderlands2.exe" }, ProfileType = typeof(Borderlands2Profile), OverviewControlType = typeof(Control_Borderlands2), GameStateType = typeof(GameState_Borderlands2), Event = new GameEvent_Borderlands2(), IconURI = "Resources/Borderlands2_64x64.png" })
        {
            var extra = new List<LayerHandlerEntry>
            {
                new LayerHandlerEntry("Borderlands2Background", "Borderlands 2 Layer", typeof(Borderlands2BackgroundLayerHandler)),
            };

            Global.LightingStateManager.RegisterLayerHandlers(extra, false);

            foreach (var entry in extra)
            {
                Config.ExtraAvailableLayers.Add(entry.Key);
            }
        }
    }
}
