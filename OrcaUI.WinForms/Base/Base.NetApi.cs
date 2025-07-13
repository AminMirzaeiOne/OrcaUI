using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcaUI.WinForms.Base
{
    public struct NETRESOURCE
    {
        public int dwScope;
        public int dwType;
        public int dwDisplayType;
        public int dwUsage;
        public string lpLocalName;
        public string lpRemoteName;
        public string lpComment;
        public string lpProvider;
    }

    public struct USER_INFO_3
    {
        public int Name;
        public int Password;
        public int PasswordAge;
        public int Privilege;
        public int HomeDir;
        public int Comment;
        public int Flags;
        public int ScriptPath;
        public int AuthFlags;
        public int FullName;
        public int UserComment;
        public int Parms;
        public int Workstations;
        public int LastLogon;
        public int LastLogoff;
        public int AcctExpires;
        public int MaxStorage;
        public int UnitsPerWeek;
        public int LogonHours;
        public int BadPwCount;
        public int NumLogons;
        public int LogonServer;
        public int CountryCode;
        public int CodePage;
        public int UserID;
        public int PrimaryGroupID;
        public int Profile;
        public int HomeDirDrive;
        public int PasswordExpired;
    }

    public struct LOCALGROUP_MEMBERS_INFO_0
    {
        public int pSID;
    }


}
