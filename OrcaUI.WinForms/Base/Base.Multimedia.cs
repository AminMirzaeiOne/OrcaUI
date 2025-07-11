﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OrcaUI.WinForms.Base
{
    public struct MMTIME
    {
        public int wType;
        public int u;
    }

    public struct MIXERCAPS
    {
        public short wMid;
        public short wPid;
        public int vDriverVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = WinMM.MAXPNAMELEN)] public string szPname;
        public int fdwSupport;
        public int cDestinations;
    }

    public struct TARGET
    {
        public int dwType;
        public int dwDeviceID;
        public short wMid;
        public short wPid;
        public int vDriverVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = WinMM.MAXPNAMELEN)] public string szPname;
    }

    public struct MIXERLINE
    {
        public int cbStruct;
        public int dwDestination;
        public int dwSource;
        public int dwLineID;
        public int fdwLine;
        public int dwUser;
        public int dwComponentType;
        public int cChannels;
        public int cConnections;
        public int cControls;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = WinMM.MIXER_SHORT_NAME_CHARS)]
        public string szShortName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = WinMM.MIXER_LONG_NAME_CHARS)]
        public string szName;
        public TARGET tTarget;
    }

    public struct MIXERCONTROL
    {
        public int cbStruct;
        public int dwControlID;
        public int dwControlType;
        public int fdwControl;
        public int cMultipleItems;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = WinMM.MIXER_SHORT_NAME_CHARS)] public string szShortName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = WinMM.MIXER_LONG_NAME_CHARS)] public string szName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)] public int[] Bounds;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)] public int[] Metrics;
    }

    public struct MIXERLINECONTROLS
    {
        public int cbStruct;
        public int dwLineID;
        public int dwControl;
        public int cControls;
        public int cbmxctrl;
        public MIXERCONTROL pamxctrl;
    }

    public struct MIXERCONTROLDETAILS
    {
        public int cbStruct;
        public int dwControlID;
        public int cChannels;
        public int item;
        public int cbDetails;
        public int paDetails;
    }

    public struct JOYINFOEX
    {
        public int dwSize;
        public int dwFlags;
        public int dwXpos;
        public int dwYpos;
        public int dwZpos;
        public int dwRpos;
        public int dwUpos;
        public int dwVpos;
        public int dwButtons;
        public int dwButtonNumber;
        public int dwPOV;
        public int dwReserved1;
        public int dwReserved2;
    }

    public struct WAVEHDR
    {
        public string lpData;
        public int dwBufferLength;
        public int dwBytesRecorded;
        public int dwUser;
        public int dwFlags;
        public int dwLoops;
        public int lpNext;
        public int Reserved;
    }

    public struct WAVEOUTCAPS
    {
        public short wMid;
        public short wPid;
        public int vDriverVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = WinMM.MAXPNAMELEN)] public string szPname;
        public int dwFormats;
        public short wChannels;
        public int dwSupport;
    }

    public struct WAVEINCAPS
    {
        public short wMid;
        public short wPid;
        public int vDriverVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = WinMM.MAXPNAMELEN)] public string szPname;
        public int dwFormats;
        public short wChannels;
    }

    public struct WAVEFORMAT
    {
        public short wFormatTag;
        public short nChannels;
        public int nSamplesPerSec;
        public int nAvgBytesPerSec;
        public short nBlockAlign;
    }

    public struct MIDIOUTCAPS
    {
        public short wMid;
        public short wPid;
        public int vDriverVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = WinMM.MAXPNAMELEN)] public string szPname;
        public short wTechnology;
        public short wVoices;
        public short wNotes;
        public short wChannelMask;
        public int dwSupport;
    }

    public struct MIDIINCAPS
    {
        public short wMid;
        public short wPid;
        public int vDriverVersion;
        public string szPname;
    }

    public struct MIDIHDR
    {
        public string lpData;
        public int dwBufferLength;
        public int dwBytesRecorded;
        public int dwUser;
        public int dwFlags;
        public int lpNext;
        public int Reserved;
    }

    public struct AUXCAPS
    {
        public short wMid;
        public short wPid;
        public int vDriverVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = WinMM.MAXPNAMELEN)] public string szPname;
        public short wTechnology;
        public int dwSupport;
    }

    public struct TIMECAPS
    {
        public int wPeriodMin;
        public int wPeriodMax;
    }

    public struct JOYCAPS
    {
        public short wMid;
        public short wPid;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = WinMM.MAXPNAMELEN)] public string szPname;
        public short wXmin;
        public short wXmax;
        public short wYmin;
        public short wYmax;
        public short wZmin;
        public short wZmax;
        public short wNumButtons;
        public short wPeriodMin;
        public short wPeriodMax;
    }


}
