﻿using DokanNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MegaFUSE
{
    public class MFuseFS : IDokanOperations
    {
        public MFuseFSHook Hook { get; set; }

        public MFuseFS(MFuseFSHook hook)
        {
            Hook = hook;
        }

        public void Cleanup(string fileName, DokanFileInfo info)
        {
            (info.Context as Stream)?.Dispose();
            info.Context = null;
        }

        public void CloseFile(string fileName, DokanFileInfo info)
        {
            (info.Context as Stream)?.Dispose();
            info.Context = null;
        }

        public NtStatus CreateFile(string fileName, DokanNet.FileAccess access, FileShare share, FileMode mode, FileOptions options, FileAttributes attributes, DokanFileInfo info)
        {
            return Hook.CreateFile(fileName, mode, attributes);
        }

        public NtStatus DeleteDirectory(string fileName, DokanFileInfo info)
        {
            return Hook.DeleteDir(fileName, info);
        }

        public NtStatus DeleteFile(string fileName, DokanFileInfo info)
        {
            return Hook.DeleteFile(fileName, info);
        }

        public NtStatus FindFiles(string fileName, out IList<FileInformation> files, DokanFileInfo info)
        {
            files = Hook.GetFiles(fileName);
            return DokanResult.Success;
        }

        public NtStatus FindFilesWithPattern(string fileName, string searchPattern, out IList<FileInformation> files, DokanFileInfo info)
        {
            files = new FileInformation[0];
            return DokanResult.NotImplemented;
        }

        public NtStatus FindStreams(string fileName, out IList<FileInformation> streams, DokanFileInfo info)
        {
            streams = new FileInformation[0];
            return DokanResult.NotImplemented;
        }

        public NtStatus FlushFileBuffers(string fileName, DokanFileInfo info)
        {
            try
            {
                ((Stream)(info.Context)).Flush();
                return DokanResult.Success;
            }
            catch (IOException)
            {
                return DokanResult.Error;
            }
        }

        public NtStatus GetDiskFreeSpace(out long freeBytesAvailable, out long totalNumberOfBytes, out long totalNumberOfFreeBytes, DokanFileInfo info)
        {
            var quota = Hook.GetQuota();
            freeBytesAvailable = quota.QuotaFree;
            totalNumberOfBytes = quota.QuotaTotal;
            totalNumberOfFreeBytes = quota.QuotaFree;
            return DokanResult.Success;
        }

        public NtStatus GetFileInformation(string fileName, out FileInformation fileInfo, DokanFileInfo info)
        {
            return Hook.GetFileInfo(fileName, out fileInfo, info); ;
        }

        public NtStatus GetFileSecurity(string fileName, out FileSystemSecurity security, AccessControlSections sections, DokanFileInfo info)
        {
            security = null;
            return DokanResult.NotImplemented;
        }

        public NtStatus GetVolumeInformation(out string volumeLabel, out FileSystemFeatures features, out string fileSystemName, out uint maximumComponentLength, DokanFileInfo info)
        {
            volumeLabel = "MEGA";
            features = FileSystemFeatures.None;
            fileSystemName = "MEGAFS";
            maximumComponentLength = 256;
            return DokanResult.Success;
        }

        public NtStatus LockFile(string fileName, long offset, long length, DokanFileInfo info)
        {
            return DokanResult.Success;
        }

        public NtStatus Mounted(DokanFileInfo info)
        {
            Hook.OnMounted();
            return DokanResult.Success;
        }

        public NtStatus MoveFile(string oldName, string newName, bool replace, DokanFileInfo info)
        {
            return DokanResult.NotImplemented;
        }

        public NtStatus ReadFile(string fileName, byte[] buffer, out int bytesRead, long offset, DokanFileInfo info)
        {
            return Hook.ReadFile(fileName, buffer, out bytesRead, offset, info);
        }

        public NtStatus SetAllocationSize(string fileName, long length, DokanFileInfo info)
        {
            try
            {
                ((Stream)(info.Context)).SetLength(length);
                return DokanResult.Success;
            }
            catch (Exception)
            {
                return DokanResult.Error;
            }
        }

        public NtStatus SetEndOfFile(string fileName, long length, DokanFileInfo info)
        {
            try
            {
                ((Stream)(info.Context)).SetLength(length);
                return DokanResult.Success;
            }
            catch (Exception)
            {
                return DokanResult.Error;
            }
        }

        public NtStatus SetFileAttributes(string fileName, FileAttributes attributes, DokanFileInfo info)
        {
            return DokanResult.Success;
        }

        public NtStatus SetFileSecurity(string fileName, FileSystemSecurity security, AccessControlSections sections, DokanFileInfo info)
        {
            return DokanResult.NotImplemented;
        }

        public NtStatus SetFileTime(string fileName, DateTime? creationTime, DateTime? lastAccessTime, DateTime? lastWriteTime, DokanFileInfo info)
        {
            return Hook.SetFileTime(fileName, creationTime, lastAccessTime, lastWriteTime, info);
        }

        public NtStatus UnlockFile(string fileName, long offset, long length, DokanFileInfo info)
        {
            try
            {
                return DokanResult.Success;
            }
            catch (Exception)
            {
                return DokanResult.Error;
            }
        }

        public NtStatus Unmounted(DokanFileInfo info)
        {
            Hook.OnEject();
            return DokanResult.Success;
        }

        public NtStatus WriteFile(string fileName, byte[] buffer, out int bytesWritten, long offset, DokanFileInfo info)
        {
            return Hook.WriteFile(fileName, buffer, out bytesWritten, offset, info);
        }
    }
}
