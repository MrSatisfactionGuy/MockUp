namespace MockUp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            columnHeader1 = new ColumnHeader();
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Technisches Büro";
            columnHeader1.Width = 120;
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            listView1.Location = new Point(498, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(290, 167);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "TB";
            columnHeader2.Width = 120;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 12);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(311, 94);
            checkedListBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 156);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(listView1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ColumnHeader columnHeader1;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private Button button1;
    }
}
