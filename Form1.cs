using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplaceFileKeyWord
{
    public partial class Form1 : Form
    {
        private string folderPath = "";
        private SortedDictionary<string, string> dirction = new SortedDictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            initListView();
            gridViewEnable(false);
        }

        private void initListView() 
        {
            DataGridViewTextBoxColumn oldNameColumn = new DataGridViewTextBoxColumn();
            oldNameColumn.Name = "old_name";
            oldNameColumn.DataPropertyName = "old_name";
            oldNameColumn.HeaderText = "旧的关键词";
            data_grid_view.Columns.Add(oldNameColumn);

            DataGridViewTextBoxColumn newNameColumn = new DataGridViewTextBoxColumn();
            newNameColumn.Name = "new_name";
            newNameColumn.DataPropertyName = "new_name";
            newNameColumn.HeaderText = "新的关键词";
            data_grid_view.Columns.Add(newNameColumn);
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
            gridViewEnable(true);
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

        private void btn_replace_Click(object sender, EventArgs e)
        {
            getUpdateKeyWord();//获取关键词
            //在选择的文件夹里面找文件和文件夹
            if (!File.Exists(folderPath)) {
                MessageBox.Show("没有这个文件夹");
                return;
            }
        }

        private void getUpdateKeyWord() {

            if (dirction.Count > 0)
            {
                dirction.Clear();
            }
            //先遍历里面的数据
            for (int i = 0; i < data_grid_view.Rows.Count - 1; i++)
            {
                string oldName = data_grid_view.Rows[i].Cells[0].Value.ToString();
                string newName = data_grid_view.Rows[i].Cells[1].Value.ToString();
                dirction.Add(oldName, newName);
            }
        }


        private void gridViewEnable(bool b = false) 
        {
            data_grid_view.Enabled = b;
            btn_replace.Enabled = b;
        }
    }
}
