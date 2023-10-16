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
            //先遍历里面的数据
            for (int i =0;i<data_grid_view.Rows.Count-1;i++) {
                string oldName = data_grid_view.Rows[i].Cells[0].Value.ToString();
                string newName = data_grid_view.Rows[i].Cells[1].Value.ToString();
                Console.WriteLine(oldName + " " + newName);
            }
        }
    }
}
