using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplaceFileKeyWord
{
    public partial class Form1 : Form
    {
        private string folderPath = "";
        public Form1()
        {
            InitializeComponent();
            initListView();
        }
        private void initListView() 
        {
            //初始化listview
            list_view.View = View.Details;
            list_view.Columns.Add("原关键词",list_view.Width/2);
            list_view.Columns.Add("修改后的关键词", list_view.Width / 2);
         }

        private void btn_select_dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) 
            {
                folderPath = folderBrowserDialog.SelectedPath;
                selectFolderComplete();
            }
        }

        private void  selectFolderComplete() 
        {
            updateLabelSelectFolderText();

        }



        private void updateLabelSelectFolderText(string text = "") 
        {
            if (string.IsNullOrEmpty(text))
            {
                label_select_folder.Text = folderPath;
            }
            else 
            {
                label_select_folder.Text = text;
            }
        }
    }
}
