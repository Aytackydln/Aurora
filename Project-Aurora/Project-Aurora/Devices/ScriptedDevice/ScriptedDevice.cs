﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using Aurora.Settings;
using Microsoft.Win32.TaskScheduler;

namespace Aurora.Devices.ScriptedDevice
{
    public class ScriptedDevice : DefaultDevice
    {
        private bool crashed = false;
        private readonly dynamic script = null;

        private string devicename = "";
        private bool isInitialized = false;

        private System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        private long lastUpdateTime = 0;

        public ScriptedDevice(dynamic script)
        {
            if (
                (script != null) &&
                (script.devicename != null) &&
                (script.enabled != null && script.enabled == true) &&
                (script.GetType().GetMethod("Initialize") != null || script.Initialize != null) &&
                (script.GetType().GetMethod("Shutdown") != null || script.Shutdown != null) &&
                (script.GetType().GetMethod("Reset") != null || script.Reset != null) &&
                (script.GetType().GetMethod("UpdateDevice") != null || script.UpdateDevice != null)
                )
            {
                this.devicename = script.devicename;
                this.script = script;
            }
            else
            {
                throw new Exception("Provided script, does not meet all the requirements");
            }
        }

        public string DeviceDetails
        {
            get
            {
                if (crashed)
                    return "Error!";

                if (isInitialized)
                    return "Connected";
                else
                    return "Not initialized";
            }
        }

        public override string DeviceName => devicename;

        public override bool Initialize()
        {
            if (!isInitialized)
            {
                try
                {
                    isInitialized = script.Initialize();
                }
                catch (Exception exc)
                {
                    Global.logger.Error("Device script for {0} encountered an error during Initialization. Exception: {1}", devicename, exc);
                    crashed = true;
                    isInitialized = false;

                    return false;
                }
            }

            return isInitialized && !crashed;
        }

        public void Reset()
        {
            if (isInitialized)
            {
                try
                {
                    script.Reset();
                }
                catch (Exception exc)
                {
                    Global.logger.Error("Device script for {0} encountered an error during Reset. Exception: {1}", devicename, exc);
                    crashed = true;
                    isInitialized = false;
                }
            }
        }

        public override void Shutdown()
        {
            if (isInitialized)
            {
                try
                {
                    this.Reset();
                    script.Shutdown();
                    isInitialized = false;
                }
                catch (Exception exc)
                {
                    Global.logger.Error("Device script for {0} encountered an error during Shutdown. Exception: {1}", devicename, exc);
                    crashed = true;
                    isInitialized = false;
                }
            }
        }

        protected override bool UpdateDevice(Dictionary<DeviceKeys, Color> keyColors, DoWorkEventArgs e, bool forced = false)
        {
            if (isInitialized)
            {
                try
                {
                    return script.UpdateDevice(keyColors, forced);
                }
                catch (Exception exc)
                {
                    Global.logger.Error(
                        "Device script for {0} encountered an error during UpdateDevice. Exception: {1}",
                        devicename, exc);
                    crashed = true;
                    isInitialized = false;

                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
