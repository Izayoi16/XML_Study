namespace Spider
{
    partial class XML_Study_Form
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
            this.Run = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Select_Location = new System.Windows.Forms.Button();
            this.StateList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Value_203 = new System.Windows.Forms.TextBox();
            this.TB_Value_202 = new System.Windows.Forms.TextBox();
            this.TB_Value_201 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Value_200 = new System.Windows.Forms.Label();
            this.Value_201 = new System.Windows.Forms.Label();
            this.Value_202 = new System.Windows.Forms.Label();
            this.Value_203 = new System.Windows.Forms.Label();
            this.TB_Value_200 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(713, 26);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 0;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_ClickAsync);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(12, 27);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(656, 23);
            this.Path.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "State";
            // 
            // Select_Location
            // 
            this.Select_Location.Location = new System.Drawing.Point(674, 26);
            this.Select_Location.Name = "Select_Location";
            this.Select_Location.Size = new System.Drawing.Size(33, 23);
            this.Select_Location.TabIndex = 0;
            this.Select_Location.Text = "...";
            this.Select_Location.UseVisualStyleBackColor = true;
            this.Select_Location.Click += new System.EventHandler(this.Select_Location_Click);
            // 
            // StateList
            // 
            this.StateList.FormattingEnabled = true;
            this.StateList.ItemHeight = 15;
            this.StateList.Location = new System.Drawing.Point(12, 71);
            this.StateList.Name = "StateList";
            this.StateList.Size = new System.Drawing.Size(656, 94);
            this.StateList.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.08772F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.59649F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel1.Controls.Add(this.TB_Value_203, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TB_Value_202, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TB_Value_201, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Value_200, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Value_201, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Value_202, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Value_203, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TB_Value_200, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(674, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(114, 94);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // TB_Value_203
            // 
            this.TB_Value_203.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Value_203.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_Value_203.Location = new System.Drawing.Point(3, 72);
            this.TB_Value_203.Name = "TB_Value_203";
            this.TB_Value_203.Size = new System.Drawing.Size(34, 21);
            this.TB_Value_203.TabIndex = 4;
            // 
            // TB_Value_202
            // 
            this.TB_Value_202.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Value_202.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_Value_202.Location = new System.Drawing.Point(3, 49);
            this.TB_Value_202.Name = "TB_Value_202";
            this.TB_Value_202.Size = new System.Drawing.Size(34, 21);
            this.TB_Value_202.TabIndex = 3;
            // 
            // TB_Value_201
            // 
            this.TB_Value_201.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Value_201.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_Value_201.Location = new System.Drawing.Point(3, 26);
            this.TB_Value_201.Name = "TB_Value_201";
            this.TB_Value_201.Size = new System.Drawing.Size(34, 21);
            this.TB_Value_201.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "D200";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "D201";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "D202";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "D203";
            // 
            // Value_200
            // 
            this.Value_200.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Value_200.AutoSize = true;
            this.Value_200.Location = new System.Drawing.Point(97, 4);
            this.Value_200.Name = "Value_200";
            this.Value_200.Size = new System.Drawing.Size(14, 15);
            this.Value_200.TabIndex = 0;
            this.Value_200.Text = "0";
            // 
            // Value_201
            // 
            this.Value_201.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Value_201.AutoSize = true;
            this.Value_201.Location = new System.Drawing.Point(97, 27);
            this.Value_201.Name = "Value_201";
            this.Value_201.Size = new System.Drawing.Size(14, 15);
            this.Value_201.TabIndex = 0;
            this.Value_201.Text = "0";
            // 
            // Value_202
            // 
            this.Value_202.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Value_202.AutoSize = true;
            this.Value_202.Location = new System.Drawing.Point(97, 50);
            this.Value_202.Name = "Value_202";
            this.Value_202.Size = new System.Drawing.Size(14, 15);
            this.Value_202.TabIndex = 0;
            this.Value_202.Text = "0";
            // 
            // Value_203
            // 
            this.Value_203.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Value_203.AutoSize = true;
            this.Value_203.Location = new System.Drawing.Point(97, 74);
            this.Value_203.Name = "Value_203";
            this.Value_203.Size = new System.Drawing.Size(14, 15);
            this.Value_203.TabIndex = 0;
            this.Value_203.Text = "0";
            // 
            // TB_Value_200
            // 
            this.TB_Value_200.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Value_200.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_Value_200.Location = new System.Drawing.Point(3, 3);
            this.TB_Value_200.Name = "TB_Value_200";
            this.TB_Value_200.Size = new System.Drawing.Size(34, 21);
            this.TB_Value_200.TabIndex = 1;
            // 
            // XML_Study_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 177);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.StateList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.Select_Location);
            this.Controls.Add(this.Run);
            this.Name = "XML_Study_Form";
            this.Text = "XML_Study";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Run;
        private TextBox Path;
        private Label label1;
        private Label label2;
        private Button Select_Location;
        private ListBox StateList;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label Value_200;
        private Label Value_201;
        private Label Value_202;
        private Label Value_203;
        private TextBox TB_Value_203;
        private TextBox TB_Value_202;
        private TextBox TB_Value_201;
        private TextBox TB_Value_200;
    }
}