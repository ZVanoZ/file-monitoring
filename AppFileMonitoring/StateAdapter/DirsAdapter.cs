using System;

namespace AppFileMonitoring
{

    partial class StateAdapter
    {
        public static class DirsAdapter
        {
            public static void set(
                string dirInp,
                string dirOut = null,
                Nullable<bool> isActive = null
            )
            {
                bool isInsert = false;
                DirsRow row = state.Dirs.FindByDirInp(dirInp);
                if (row == null)
                {
                    isInsert = true;
                    row = state.Dirs.NewDirsRow();
                    row.DirInp = dirInp;
                }
                if (dirOut != null)
                {
                    row.DirOut = dirOut;
                }
                if (isActive != null)
                {
                    row.IsActive = isActive.Value;
                }
                if (isInsert)
                {
                    state.Dirs.Rows.Add(row);
                }
            }
        }
    }
}
