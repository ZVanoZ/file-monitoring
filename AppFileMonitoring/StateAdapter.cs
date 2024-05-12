using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using AppFileMonitoring.StateSchema;
using static AppFileMonitoring.StateSchema.State;

namespace AppFileMonitoring
{
    public static class StaticStateAdapter { 
        public static StateAdapter state = new StateAdapter();
    }

    public partial class StateAdapter : 
        State 
//        , System.ComponentModel.ISupportInitialize
    {
        public static StateAdapter state;

        /** 
         * Классический Singleton не проходит т.к. конструктор форм использует публичный конструктор.
         * <code>
         * private StateAdapter(){}
         * </code>
         */
        public StateAdapter()
        {
            string a = "aaa";
        }

        static StateAdapter() {
            state = new StateAdapter();
        }
        

        //protected State State = new State();

        public static StateAdapter Instance {
            get
            {
                return state;
            }
        }
        public static StateAdapter GetInstance()
        {
            return state;
        }

        //void BeginInit() { 
        //}

        //void EndInit() { 
        //}

        public static string getXmlPath()
        {
            string result = Application.ExecutablePath;
            result = Path.GetDirectoryName(result);
            result = result + "\\State.xml";
            return result;
        }


        public static void load() 
        { 
            string xmlPath = getXmlPath();
            if (!File.Exists(xmlPath)) {
                return;
            }
            state.ReadXml(xmlPath);
        }

        public static void save()
        {
            string xmlPath = getXmlPath();
            state.WriteXml(xmlPath);
        }


        public static class DirsAdapter {
            public static void set(
                string dirInp,
                string dirOut = null,
                Nullable<bool> isActive = null
            )
            {
                bool isInsert = false;
                DirsRow row = state.Dirs.FindByDirInp( dirInp );
                if ( row == null )
                {
                    isInsert = true;
                    row = state.Dirs.NewDirsRow();
                    row.DirInp = dirInp;   
                }
                if(dirOut != null) { 
                    row.DirOut = dirOut;
                }
                if ( isActive != null )
                {
                    row.IsActive = isActive.Value;
                }
                if (isInsert) {
                    state.Dirs.Rows.Add( row );
                }
            }
        }

    }
}
