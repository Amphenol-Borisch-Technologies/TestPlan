using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Principal;

namespace ABT.Test.TestExecutive.InstallerCustomActions {
    [RunInstaller(true)]
    public partial class InstallerCustomActions : Installer {
        public InstallerCustomActions() { InitializeComponent(); }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Install(IDictionary stateSaver) {

            base.Install(stateSaver);
            SetDirectoryPermissions(Context.Parameters["targetdir"], WellKnownSidType.BuiltinUsersSid, FileSystemRights.ReadAndExecute);
            SetDirectoryPermissions(Context.Parameters["targetdir"], @"BORISCH\Test - TestExecutive Administrators", FileSystemRights.Modify | FileSystemRights.Write);

            Configuration configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            String tdr_Folder = configuration.AppSettings.Settings["TDR_Folder"].Value;

            // TODO: Soon; read C:\Program Files\ABT\Test\TestExecutive\TestExecDefinition.xml to read TestData element.
            //       - If TestData contains element TextFiles, then TestData\TextFiles\Folder\Name is base TDR path, typically P:\Test\TDR.
            //         - Then read Context.Parameters["targetdir"]\TestExecDefinition.xml to read all TestSpace\TestOperation\NameSpaceTrunks.
            //         - Then create folder TestData\TextFiles\Folder\Name\Path.GetFileName(Context.Parameters["targetdir"])
            //         - Then create folder TestData\TextFiles\Folder\Name\Path.GetFileName(Context.Parameters["targetdir"])\TestSpace\TestOperation\NameSpaceTrunk
            //           - For each NameSpaceTrunk.
            //         - Finally, set permissions on all the folders.
            String folderName = Path.GetFileName(Context.Parameters["targetdir"]);
            Directory.CreateDirectory(Path.GetFileName(Context.Parameters["targetdir"]));
            SetDirectoryPermissions(tdr_Folder, WellKnownSidType.BuiltinUsersSid, FileSystemRights.ReadAndExecute);
            SetDirectoryPermissions(tdr_Folder, @"BORISCH\Test - TDR Administrators", FileSystemRights.Modify | FileSystemRights.Write);
            SetDirectoryPermissions(tdr_Folder, @"BORISCH\Test - TestExecutive Administrators", FileSystemRights.Modify | FileSystemRights.Write);
        }
        private void SetDirectoryPermissions(String directory, WellKnownSidType wellKnownSidType, FileSystemRights fileSystemRights) {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
            directorySecurity.AddAccessRule(
                new FileSystemAccessRule(
                    new SecurityIdentifier(wellKnownSidType, null),
                        fileSystemRights,
                        InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit,
                        PropagationFlags.NoPropagateInherit,
                        AccessControlType.Allow));
            directoryInfo.SetAccessControl(directorySecurity);
        }

        private void SetDirectoryPermissions(String directory, String identity, FileSystemRights fileSystemRights) {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
            directorySecurity.AddAccessRule(
                new FileSystemAccessRule(identity,
                    fileSystemRights,
                    InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit,
                    PropagationFlags.NoPropagateInherit,
                    AccessControlType.Allow));
            directoryInfo.SetAccessControl(directorySecurity);
        }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Commit(IDictionary savedState) { base.Commit(savedState); }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Rollback(IDictionary savedState) { base.Rollback(savedState); }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Uninstall(IDictionary savedState) { base.Uninstall(savedState); }
    }
}
