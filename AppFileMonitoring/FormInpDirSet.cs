using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppFileMonitoring.StateSchema;

namespace AppFileMonitoring
{
    public partial class FormInpDirSet : Form
    {
        FolderBrowserDialog folderDialog = new FolderBrowserDialog();
        public FormInpDirSet()
        {
            InitializeComponent();
        }
        public FormInpDirSet(
            string inpDir
        )
        {
            InitializeComponent();
            this.inpDir.Text = inpDir;
        }

            private void inpDirSelect_Click(object sender, EventArgs e)
        {
            
            if (folderDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            inpDir.Text = folderDialog.SelectedPath;
        }

        private void outDirSelect_Click(object sender, EventArgs e)
        {                
            
            if (folderDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            outDir.Text = folderDialog.SelectedPath;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StateAdapter.DirsAdapter.set(
                inpDir.Text,
                outDir.Text,
                isActive.Checked    
            );
            //new State.DirsRow();
            /*
            StateSchema.State.DirsRow row = StateAdapter.state.Dirs.NewDirsRow();
            row.DirInp = inpDir.Text;
            row.DirOut = outDir.Text;
            row.IsActive = isActive.Checked;
            row.RegexOutFileName = regexFileName.Text;  
            row.RegexOutPath = regexDirName.Text;
            StateAdapter.dirInpSet(row);
            */
        }
    }
}
