namespace tpr_1_Maybe
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.labelN = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRecreateTable = new System.Windows.Forms.Button();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownS = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStages = new System.Windows.Forms.NumericUpDown();
            this.gridQ = new System.Windows.Forms.DataGridView();
            this.gridF = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.legend = new System.Windows.Forms.ListBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridF)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(129, 7);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 50;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grid.RowTemplate.Height = 25;
            this.grid.Size = new System.Drawing.Size(421, 244);
            this.grid.TabIndex = 0;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(10, 14);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(30, 15);
            this.labelN.TabIndex = 1;
            this.labelN.Text = "N = ";
            this.labelN.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(12, 40);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(27, 15);
            this.labelS.TabIndex = 2;
            this.labelS.Text = "S = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "n = ";
            // 
            // buttonRecreateTable
            // 
            this.buttonRecreateTable.Location = new System.Drawing.Point(14, 99);
            this.buttonRecreateTable.Name = "buttonRecreateTable";
            this.buttonRecreateTable.Size = new System.Drawing.Size(97, 23);
            this.buttonRecreateTable.TabIndex = 4;
            this.buttonRecreateTable.Text = "create table";
            this.buttonRecreateTable.UseVisualStyleBackColor = true;
            this.buttonRecreateTable.Click += new System.EventHandler(this.buttonRecreateTable_Click);
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(39, 12);
            this.numericUpDownN.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(84, 23);
            this.numericUpDownN.TabIndex = 5;
            this.numericUpDownN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownS
            // 
            this.numericUpDownS.Location = new System.Drawing.Point(39, 38);
            this.numericUpDownS.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownS.Name = "numericUpDownS";
            this.numericUpDownS.Size = new System.Drawing.Size(84, 23);
            this.numericUpDownS.TabIndex = 6;
            this.numericUpDownS.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownStages
            // 
            this.numericUpDownStages.Location = new System.Drawing.Point(39, 64);
            this.numericUpDownStages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStages.Name = "numericUpDownStages";
            this.numericUpDownStages.Size = new System.Drawing.Size(84, 23);
            this.numericUpDownStages.TabIndex = 7;
            this.numericUpDownStages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gridQ
            // 
            this.gridQ.AllowUserToAddRows = false;
            this.gridQ.AllowUserToDeleteRows = false;
            this.gridQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQ.Location = new System.Drawing.Point(556, 7);
            this.gridQ.Name = "gridQ";
            this.gridQ.RowHeadersWidth = 51;
            this.gridQ.RowTemplate.Height = 29;
            this.gridQ.Size = new System.Drawing.Size(421, 244);
            this.gridQ.TabIndex = 7;
            // 
            // gridF
            // 
            this.gridF.AllowUserToAddRows = false;
            this.gridF.AllowUserToDeleteRows = false;
            this.gridF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridF.Location = new System.Drawing.Point(556, 257);
            this.gridF.Name = "gridF";
            this.gridF.ReadOnly = true;
            this.gridF.RowTemplate.Height = 29;
            this.gridF.Size = new System.Drawing.Size(421, 244);
            this.gridF.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 127);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 22);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 153);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 22);
            this.button3.TabIndex = 13;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "Входные данные |*.txt";
            // 
            // sfd
            // 
            this.sfd.Filter = "Входные данные |*.txt";
            // 
            // legend
            // 
            this.legend.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.legend.FormattingEnabled = true;
            this.legend.ItemHeight = 20;
            this.legend.Location = new System.Drawing.Point(10, 337);
            this.legend.Name = "legend";
            this.legend.Size = new System.Drawing.Size(113, 164);
            this.legend.TabIndex = 9;
            this.legend.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.legend_DrawItem_1);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(10, 257);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(113, 23);
            this.comboBox.TabIndex = 17;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(129, 257);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(421, 244);
            this.panel.TabIndex = 10;
            this.panel.Click += new System.EventHandler(this.panel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 524);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.legend);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridF);
            this.Controls.Add(this.gridQ);
            this.Controls.Add(this.numericUpDownStages);
            this.Controls.Add(this.numericUpDownS);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.buttonRecreateTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grid;
        private Label labelN;
        private Label labelS;
        private Label label1;
        private Button buttonRecreateTable;
        private NumericUpDown numericUpDownN;
        private NumericUpDown numericUpDownS;
        private NumericUpDown numericUpDownStages;
        private DataGridView gridQ;
        private DataGridView gridF;
        private Button button1;
        private Button button2;
        private Button button3;
        private OpenFileDialog ofd;
        private SaveFileDialog sfd;
        private ListBox legend;
        private ComboBox comboBox;
        private Panel panel;
    }
}