using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using AppFileMonitoring.StateSchema;

namespace AppFileMonitoring
{
    public partial class StateAdapter : 
        State 
//        , System.ComponentModel.ISupportInitialize
    {
        public static StateAdapter state;
        public static List<StateAdapter> instances = new List<StateAdapter>();


        /** 
         * Классический Singleton не проходит т.к. конструктор форм использует публичный конструктор.
         * <code>
         * private StateAdapter(){}
         * </code>
         */
        public StateAdapter()
        {
            instances.Add(this);    
        }

        static StateAdapter() {
            //state = new StateAdapter();
            if (instances.Count < 1) {
                state = new StateAdapter();
            } else
            {
                state = instances[0];
            }
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
    }

}
