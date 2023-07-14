﻿using System.Collections.Generic;
using Aurora.Devices;

namespace Aurora.Modules.Razer;

// https://developer.razer.com/works-with-chroma/razer-chroma-led-profiles/
public static class RazerLayoutMap
{
    public static readonly IReadOnlyDictionary<DeviceKeys, int[]> GenericKeyboard = new Dictionary<DeviceKeys, int[]>
    {
        {DeviceKeys.ESC,                   new[]{0, 1} },
        {DeviceKeys.F1,                    new[]{0, 3} },
        {DeviceKeys.F2,                    new[]{0, 4} },
        {DeviceKeys.F3,                    new[]{0, 5} },
        {DeviceKeys.F4,                    new[]{0, 6} },
        {DeviceKeys.F5,                    new[]{0, 7} },
        {DeviceKeys.F6,                    new[]{0, 8} },
        {DeviceKeys.F7,                    new[]{0, 9} },
        {DeviceKeys.F8,                    new[]{0, 10} },
        {DeviceKeys.F9,                    new[]{0, 11} },
        {DeviceKeys.F10,                   new[]{0, 12} },
        {DeviceKeys.F11,                   new[]{0, 13} },
        {DeviceKeys.F12,                   new[]{0, 14} },
        {DeviceKeys.PRINT_SCREEN,          new[]{0, 15} },
        {DeviceKeys.SCROLL_LOCK,           new[]{0, 16} },
        {DeviceKeys.PAUSE_BREAK,           new[]{0, 17} },
        {DeviceKeys.MEDIA_PREVIOUS,        new[]{0, 18} },
        {DeviceKeys.MEDIA_PLAY_PAUSE,      new[]{0, 19} },
        {DeviceKeys.MEDIA_PLAY,            new[]{0, 20} },
        {DeviceKeys.MEDIA_STOP,            new[]{0, 20} },
        {DeviceKeys.MEDIA_PAUSE,           new[]{0, 20} },
        {DeviceKeys.MEDIA_NEXT,            new[]{0, 21} },
        {DeviceKeys.VOLUME_MUTE,           new[]{0, 22} },
        {DeviceKeys.LOGO,                  new[]{0, 20} },
        {DeviceKeys.G1,                    new[]{1, 0} },
        {DeviceKeys.TILDE,                 new[]{1, 1} },
        {DeviceKeys.ONE,                   new[]{1, 2} },
        {DeviceKeys.TWO,                   new[]{1, 3} },
        {DeviceKeys.THREE,                 new[]{1, 4} },
        {DeviceKeys.FOUR,                  new[]{1, 5} },
        {DeviceKeys.FIVE,                  new[]{1, 6} },
        {DeviceKeys.SIX,                   new[]{1, 7} },
        {DeviceKeys.SEVEN,                 new[]{1, 8} },
        {DeviceKeys.EIGHT,                 new[]{1, 9} },
        {DeviceKeys.NINE,                  new[]{1, 10} },
        {DeviceKeys.ZERO,                  new[]{1, 11} },
        {DeviceKeys.MINUS,                 new[]{1, 12} },
        {DeviceKeys.EQUALS,                new[]{1, 13} },
        {DeviceKeys.BACKSPACE,             new[]{1, 14} },
        {DeviceKeys.INSERT,                new[]{1, 15} },
        {DeviceKeys.HOME,                  new[]{1, 16} },
        {DeviceKeys.PAGE_UP,               new[]{1, 17} },
        {DeviceKeys.NUM_LOCK,              new[]{1, 18} },
        {DeviceKeys.NUM_SLASH,             new[]{1, 19} },
        {DeviceKeys.NUM_ASTERISK,          new[]{1, 20} },
        {DeviceKeys.NUM_MINUS,             new[]{1, 21} },
        {DeviceKeys.G2,                    new[]{2, 0} },
        {DeviceKeys.TAB,                   new[]{2, 1} },
        {DeviceKeys.Q,                     new[]{2, 2} },
        {DeviceKeys.W,                     new[]{2, 3} },
        {DeviceKeys.E,                     new[]{2, 4} },
        {DeviceKeys.R,                     new[]{2, 5} },
        {DeviceKeys.T,                     new[]{2, 6} },
        {DeviceKeys.Y,                     new[]{2, 7} },
        {DeviceKeys.U,                     new[]{2, 8} },
        {DeviceKeys.I,                     new[]{2, 9} },
        {DeviceKeys.O,                     new[]{2, 10} },
        {DeviceKeys.P,                     new[]{2, 11} },
        {DeviceKeys.OPEN_BRACKET,          new[]{2, 12} },
        {DeviceKeys.CLOSE_BRACKET,         new[]{2,13} },
        {DeviceKeys.BACKSLASH,             new[]{2, 14} },
        {DeviceKeys.DELETE,                new[]{2, 15} },
        {DeviceKeys.END,                   new[]{2, 16} },
        {DeviceKeys.PAGE_DOWN,             new[]{2, 17} },
        {DeviceKeys.NUM_SEVEN,             new[]{2, 18} },
        {DeviceKeys.NUM_EIGHT,             new[]{2, 19} },
        {DeviceKeys.NUM_NINE,              new[]{2, 20} },
        {DeviceKeys.NUM_PLUS,              new[]{2, 21} },
        {DeviceKeys.G3,                    new[]{3, 0} },
        {DeviceKeys.CAPS_LOCK,             new[]{3, 1} },
        {DeviceKeys.A,                     new[]{3, 2} },
        {DeviceKeys.S,                     new[]{3, 3} },
        {DeviceKeys.D,                     new[]{3, 4} },
        {DeviceKeys.F,                     new[]{3, 5} },
        {DeviceKeys.G,                     new[]{3, 6} },
        {DeviceKeys.H,                     new[]{3, 7} },
        {DeviceKeys.J,                     new[]{3, 8} },
        {DeviceKeys.K,                     new[]{3, 9} },
        {DeviceKeys.L,                     new[]{3, 10} },
        {DeviceKeys.SEMICOLON,             new[]{3, 11} },
        {DeviceKeys.APOSTROPHE,            new[]{3, 12} },
        {DeviceKeys.HASHTAG,               new[]{3, 13} },
        {DeviceKeys.ENTER,                 new[]{3, 14} },
        {DeviceKeys.NUM_FOUR,              new[]{3, 18} },
        {DeviceKeys.NUM_FIVE,              new[]{3, 19} },
        {DeviceKeys.NUM_SIX,               new[]{3, 20} },
        {DeviceKeys.G4,                    new[]{4, 0} },
        {DeviceKeys.LEFT_SHIFT,            new[]{4, 1} },
        {DeviceKeys.BACKSLASH_UK,          new[]{4, 2} },
        {DeviceKeys.Z,                     new[]{4, 3} },
        {DeviceKeys.X,                     new[]{4, 4} },
        {DeviceKeys.C,                     new[]{4, 5} },
        {DeviceKeys.V,                     new[]{4, 6} },
        {DeviceKeys.B,                     new[]{4, 7} },
        {DeviceKeys.N,                     new[]{4, 8} },
        {DeviceKeys.M,                     new[]{4, 9} },
        {DeviceKeys.COMMA,                 new[]{4, 10} },
        {DeviceKeys.PERIOD,                new[]{4, 11} },
        {DeviceKeys.FORWARD_SLASH,         new[]{4, 12} },
        {DeviceKeys.RIGHT_SHIFT,           new[]{4, 14} },
        {DeviceKeys.ARROW_UP,              new[]{4, 16} },
        {DeviceKeys.NUM_ONE,               new[]{4, 18} },
        {DeviceKeys.NUM_TWO,               new[]{4, 19} },
        {DeviceKeys.NUM_THREE,             new[]{4, 20} },
        {DeviceKeys.NUM_ENTER,             new[]{4, 21} },
        {DeviceKeys.G5,                    new[]{5, 0} },
        {DeviceKeys.LEFT_CONTROL,          new[]{5, 1} },
        {DeviceKeys.LEFT_WINDOWS,          new[]{5, 2} },
        {DeviceKeys.LEFT_ALT,              new[]{5, 3} },
        {DeviceKeys.SPACE,                 new[]{5, 7} },
        {DeviceKeys.RIGHT_ALT,             new[]{5, 11} },
        {DeviceKeys.RIGHT_WINDOWS,         new[]{5, 12} },
        {DeviceKeys.FN_Key,                new[]{5, 12} },
        {DeviceKeys.APPLICATION_SELECT,    new[]{5, 13} },
        {DeviceKeys.RIGHT_CONTROL,         new[]{5, 14} },
        {DeviceKeys.ARROW_LEFT,            new[]{5, 15} },
        {DeviceKeys.ARROW_DOWN,            new[]{5, 16} },
        {DeviceKeys.ARROW_RIGHT,           new[]{5, 17} },
        {DeviceKeys.NUM_ZERO,              new[]{5, 19} },
        {DeviceKeys.NUM_PERIOD,            new[]{5, 20} }
    };

    public static readonly IReadOnlyDictionary<DeviceKeys, int[]> Mouse = new Dictionary<DeviceKeys, int[]>
    {
        {DeviceKeys.Peripheral_ScrollWheel,       new[]{2, 3} },
        {DeviceKeys.Peripheral_Logo,              new[]{7, 3} },
        {DeviceKeys.Peripheral,                   new[]{7, 3} },
        {DeviceKeys.Peripheral_FrontLight,        new[]{4, 3} },
        {DeviceKeys.PERIPHERAL_LIGHT1,            new[]{1, 0} },
        {DeviceKeys.PERIPHERAL_LIGHT2,            new[]{2, 0} },
        {DeviceKeys.PERIPHERAL_LIGHT3,            new[]{3, 0} },
        {DeviceKeys.PERIPHERAL_LIGHT4,            new[]{4, 0} },
        {DeviceKeys.PERIPHERAL_LIGHT5,            new[]{5, 0} },
        {DeviceKeys.PERIPHERAL_LIGHT6,            new[]{6, 0} },
        {DeviceKeys.PERIPHERAL_LIGHT7,            new[]{7, 0} },
        {DeviceKeys.PERIPHERAL_LIGHT8,            new[]{1, 6} },
        {DeviceKeys.PERIPHERAL_LIGHT9,            new[]{2, 6} },
        {DeviceKeys.PERIPHERAL_LIGHT10,           new[]{3, 6} },
        {DeviceKeys.PERIPHERAL_LIGHT11,           new[]{4, 6} },
        {DeviceKeys.PERIPHERAL_LIGHT12,           new[]{5, 6} },
        {DeviceKeys.PERIPHERAL_LIGHT13,           new[]{6, 6} },
        {DeviceKeys.PERIPHERAL_LIGHT14,           new[]{7, 6} },
    };

    public static readonly IReadOnlyDictionary<DeviceKeys, int[]> Mousepad = new Dictionary<DeviceKeys, int[]>
    {
        {DeviceKeys.MOUSEPADLIGHT1,               new[]{0, 0} },
        {DeviceKeys.MOUSEPADLIGHT2,               new[]{1, 0} },
        {DeviceKeys.MOUSEPADLIGHT3,               new[]{2, 0} },
        {DeviceKeys.MOUSEPADLIGHT4,               new[]{3, 0} },
        {DeviceKeys.MOUSEPADLIGHT5,               new[]{4, 0} },
        {DeviceKeys.MOUSEPADLIGHT6,               new[]{5, 0} },
        {DeviceKeys.MOUSEPADLIGHT7,               new[]{6, 0} },
        {DeviceKeys.MOUSEPADLIGHT8,               new[]{7, 0} },
        {DeviceKeys.MOUSEPADLIGHT9,               new[]{8, 0} },
        {DeviceKeys.MOUSEPADLIGHT10,              new[]{9, 0} },
        {DeviceKeys.MOUSEPADLIGHT11,              new[]{10, 0} },
        {DeviceKeys.MOUSEPADLIGHT12,              new[]{11, 0} },
        {DeviceKeys.MOUSEPADLIGHT13,              new[]{12, 0} },
        {DeviceKeys.MOUSEPADLIGHT14,              new[]{13, 0} },
        {DeviceKeys.MOUSEPADLIGHT15,              new[]{14, 0} },
        {DeviceKeys.MOUSEPADLIGHT16,              new[]{15, 0} },
        {DeviceKeys.MOUSEPADLIGHT17,              new[]{16, 0} },
        {DeviceKeys.MOUSEPADLIGHT18,              new[]{17, 0} },
        {DeviceKeys.MOUSEPADLIGHT19,              new[]{18, 0} },
        {DeviceKeys.MOUSEPADLIGHT20,              new[]{19, 0} },
    };

    public static readonly IReadOnlyDictionary<DeviceKeys, int[]> Headset = new Dictionary<DeviceKeys, int[]>
    {
        {DeviceKeys.HEADSET1,               new[]{0, 0} },
        {DeviceKeys.HEADSET2,               new[]{0, 1} },
        //{DeviceKeys.HEADSET3,               new[]{0, 2} },
        //{DeviceKeys.HEADSET4,               new[]{0, 3} },
        //{DeviceKeys.HEADSET5,               new[]{0, 4} },
    };

    public static readonly IReadOnlyDictionary<DeviceKeys, int[]> ChromaLink = new Dictionary<DeviceKeys, int[]>
    {
        {DeviceKeys.CL1,               new[]{0, 0} },
        {DeviceKeys.CL2,               new[]{1, 0} },
        {DeviceKeys.CL3,               new[]{2, 0} },
        {DeviceKeys.CL4,               new[]{3, 0} },
        {DeviceKeys.CL5,               new[]{4, 0} },
    };
}