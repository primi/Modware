namespace Modware.Views
{
    partial class TCPSlaveForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.SlaveIDTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeoutTextBox = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LogListBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.IPTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PortTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SlaveIDTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TimeoutTextBox, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 456);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Slave ID";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Timeout";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameTextBox.Location = new System.Drawing.Point(155, 11);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.NameTextBox, "Name of the slave");
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // LogListBox
            // 
            this.LogListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.IntegralHeight = false;
            this.LogListBox.Location = new System.Drawing.Point(155, 209);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(617, 243);
            this.LogListBox.TabIndex = 3;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IPTextBox.Location = new System.Drawing.Point(155, 52);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(100, 20);
            this.IPTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.IPTextBox, "The IP address of the modbus/TCP slave");
            this.IPTextBox.TextChanged += new System.EventHandler(this.IPTextBox_TextChanged);
            // 
            // PortTextBox
            // 
            this.PortTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PortTextBox.Location = new System.Drawing.Point(155, 93);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 20);
            this.PortTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.PortTextBox, "The port of the modbus/TCP slave");
            this.PortTextBox.TextChanged += new System.EventHandler(this.PortTextBox_TextChanged);
            // 
            // SlaveIDTextBox
            // 
            this.SlaveIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SlaveIDTextBox.Location = new System.Drawing.Point(155, 134);
            this.SlaveIDTextBox.Name = "SlaveIDTextBox";
            this.SlaveIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.SlaveIDTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.SlaveIDTextBox, "The slave ID of the modbus/TCP slave");
            this.SlaveIDTextBox.TextChanged += new System.EventHandler(this.SlaveIDTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Activity Log";
            // 
            // TimeoutTextBox
            // 
            this.TimeoutTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TimeoutTextBox.Location = new System.Drawing.Point(155, 175);
            this.TimeoutTextBox.Name = "TimeoutTextBox";
            this.TimeoutTextBox.Size = new System.Drawing.Size(100, 20);
            this.TimeoutTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.TimeoutTextBox, "The connection timeout of the modbus/TCP slave connection");
            this.TimeoutTextBox.TextChanged += new System.EventHandler(this.TimeoutTextBox_TextChanged);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ApplyButton.Location = new System.Drawing.Point(3, 3);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 30);
            this.ApplyButton.TabIndex = 4;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.ApplyButton);
            this.flowLayoutPanel1.Controls.Add(this.ConnectButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 474);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 36);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConnectButton.Location = new System.Drawing.Point(84, 3);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 30);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // TCPSlaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TCPSlaveForm";
            this.Text = "TCPSlaveForm";
            this.Load += new System.EventHandler(this.TCPSlaveForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListBox LogListBox;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.TextBox SlaveIDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TimeoutTextBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}