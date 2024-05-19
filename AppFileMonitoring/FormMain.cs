using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using AppFileMonitoring.StateSchema;


namespace AppFileMonitoring
{
    public partial class FormMain : Form
    {
        //private State state;
        public FormMain()
        {
            InitializeComponent();
            //InitializeComponentCustomization();
            InitializeComponentCustom();
        }
        private void InitializeComponentCustom()
        {
            // this.state = StateAdapter.state;
        }
/*
        using System.Runtime.CompilerServices;
        [ModuleInitializer]
        public static void Init2()
        {
            Text += "Hello from Init2! ";
        }
*/

/*
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static State state
        {
            get
            {
                return StateAdapter.state;
            }
            set
            {
                //stringPropValue = value;
            }
        }
*/

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            StateAdapter.save();
        }

        private void dirAdd_Click(object sender, EventArgs e)
        {
            FormInpDirSet form = new FormInpDirSet();
            form.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cnt1 = StateAdapter.state.Dirs.Count;
            var ds = dirsBindingSource.DataSource;
            int cnt2 = dirsBindingSource.Count;
        }
    }
}
