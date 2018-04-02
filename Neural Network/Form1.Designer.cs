namespace Neural_Network
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.InputList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Init";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(118, 305);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 305);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(100, 20);
            this.InputBox.TabIndex = 3;
            // 
            // InputList
            // 
            this.InputList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.InputList.Location = new System.Drawing.Point(12, 41);
            this.InputList.Name = "InputList";
            this.InputList.Size = new System.Drawing.Size(75, 258);
            this.InputList.TabIndex = 4;
            this.InputList.UseCompatibleStateImageBehavior = false;
            this.InputList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Value";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(93, 12);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 5;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 357);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.InputList);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.ListView InputList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button CalculateBtn;
    }
}

