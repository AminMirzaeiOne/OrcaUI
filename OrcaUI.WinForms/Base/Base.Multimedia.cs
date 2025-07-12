using System;
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
}
