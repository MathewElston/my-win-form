namespace WindowsFormsApp1
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
            this.AddButton = new System.Windows.Forms.Button();
            this.ItemInput = new System.Windows.Forms.TextBox();
            this.ToDoList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(416, 326);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 20);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Item";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ItemInput
            // 
            this.ItemInput.Location = new System.Drawing.Point(283, 326);
            this.ItemInput.Name = "ItemInput";
            this.ItemInput.Size = new System.Drawing.Size(127, 20);
            this.ItemInput.TabIndex = 1;
            this.ItemInput.TextChanged += new System.EventHandler(this.ItemInput_TextChanged);
            // 
            // ToDoList
            // 
            this.ToDoList.FormattingEnabled = true;
            this.ToDoList.Location = new System.Drawing.Point(275, 159);
            this.ToDoList.Name = "ToDoList";
            this.ToDoList.Size = new System.Drawing.Size(237, 109);
            this.ToDoList.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToDoList);
            this.Controls.Add(this.ItemInput);
            this.Controls.Add(this.AddButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox ItemInput;
        private System.Windows.Forms.CheckedListBox ToDoList;
    }
}

