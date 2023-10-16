namespace ReplaceFileKeyWord
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_select_dir = new System.Windows.Forms.Button();
            this.label_select_folder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_select_dir
            // 
            this.btn_select_dir.Location = new System.Drawing.Point(12, 12);
            this.btn_select_dir.Name = "btn_select_dir";
            this.btn_select_dir.Size = new System.Drawing.Size(75, 23);
            this.btn_select_dir.TabIndex = 0;
            this.btn_select_dir.Text = "选择文件夹";
            this.btn_select_dir.UseVisualStyleBackColor = true;
            this.btn_select_dir.Click += new System.EventHandler(this.btn_select_dir_Click);
            // 
            // label_select_folder
            // 
            this.label_select_folder.AutoSize = true;
            this.label_select_folder.Location = new System.Drawing.Point(103, 17);
            this.label_select_folder.Name = "label_select_folder";
            this.label_select_folder.Size = new System.Drawing.Size(77, 12);
            this.label_select_folder.TabIndex = 1;
            this.label_select_folder.Text = "请选择文件夹";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_select_folder);
            this.Controls.Add(this.btn_select_dir);
            this.Name = "Form1";
            this.Text = "修改文件名和关键词";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select_dir;
        private System.Windows.Forms.Label label_select_folder;
    }
}

