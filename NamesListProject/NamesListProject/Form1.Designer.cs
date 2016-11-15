namespace NamesListProject
{
    partial class NameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewName = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnFindName = new System.Windows.Forms.Button();
            this.lBoxNames = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(202, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnAddNewName
            // 
            this.btnAddNewName.Location = new System.Drawing.Point(62, 149);
            this.btnAddNewName.Name = "btnAddNewName";
            this.btnAddNewName.Size = new System.Drawing.Size(116, 21);
            this.btnAddNewName.TabIndex = 2;
            this.btnAddNewName.Text = "Add New Name";
            this.btnAddNewName.UseVisualStyleBackColor = true;
            this.btnAddNewName.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(216, 146);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(115, 24);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "Show All Names";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(367, 148);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteAll.TabIndex = 4;
            this.btnDeleteAll.Text = "Delete Name";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnFindName
            // 
            this.btnFindName.Location = new System.Drawing.Point(367, 82);
            this.btnFindName.Name = "btnFindName";
            this.btnFindName.Size = new System.Drawing.Size(75, 23);
            this.btnFindName.TabIndex = 5;
            this.btnFindName.Text = "Find Name";
            this.btnFindName.UseVisualStyleBackColor = true;
            this.btnFindName.Click += new System.EventHandler(this.btnFindName_Click);
            // 
            // lBoxNames
            // 
            this.lBoxNames.FormattingEnabled = true;
            this.lBoxNames.Location = new System.Drawing.Point(155, 201);
            this.lBoxNames.Name = "lBoxNames";
            this.lBoxNames.Size = new System.Drawing.Size(227, 121);
            this.lBoxNames.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lBoxNames);
            this.Controls.Add(this.btnFindName);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnAddNewName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "NameForm";
            this.Text = "Name List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewName;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnFindName;
        private System.Windows.Forms.ListBox lBoxNames;
        private System.Windows.Forms.Label label2;
    }
}

