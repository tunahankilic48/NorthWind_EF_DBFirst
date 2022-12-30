namespace NorthWind_EF_DBFirst.Forms
{
    partial class frmTerritories
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
            this.rdbRegion = new System.Windows.Forms.RadioButton();
            this.rdbDescription = new System.Windows.Forms.RadioButton();
            this.btnListTerritories = new System.Windows.Forms.Button();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbRegionSearch = new System.Windows.Forms.ComboBox();
            this.txtTerritoryDescriptionSearch = new System.Windows.Forms.TextBox();
            this.txtTerritoryIDSearch = new System.Windows.Forms.TextBox();
            this.lblTerritoryIDSearch = new System.Windows.Forms.Label();
            this.lblRegioSearch = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTerritoryDescriptionSearch = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbRegion = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRegionID = new System.Windows.Forms.Label();
            this.lblTerritoryDescription = new System.Windows.Forms.Label();
            this.lblTerritories = new System.Windows.Forms.Label();
            this.lblTerritoryID = new System.Windows.Forms.Label();
            this.txtTerritoryDescription = new System.Windows.Forms.TextBox();
            this.txtTerritoryID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbRegion
            // 
            this.rdbRegion.AutoSize = true;
            this.rdbRegion.ForeColor = System.Drawing.Color.White;
            this.rdbRegion.Location = new System.Drawing.Point(374, 108);
            this.rdbRegion.Name = "rdbRegion";
            this.rdbRegion.Size = new System.Drawing.Size(84, 27);
            this.rdbRegion.TabIndex = 12;
            this.rdbRegion.TabStop = true;
            this.rdbRegion.Text = "Region";
            this.rdbRegion.UseVisualStyleBackColor = true;
            // 
            // rdbDescription
            // 
            this.rdbDescription.AutoSize = true;
            this.rdbDescription.ForeColor = System.Drawing.Color.White;
            this.rdbDescription.Location = new System.Drawing.Point(374, 68);
            this.rdbDescription.Name = "rdbDescription";
            this.rdbDescription.Size = new System.Drawing.Size(117, 27);
            this.rdbDescription.TabIndex = 11;
            this.rdbDescription.TabStop = true;
            this.rdbDescription.Text = "Description";
            this.rdbDescription.UseVisualStyleBackColor = true;
            // 
            // btnListTerritories
            // 
            this.btnListTerritories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnListTerritories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListTerritories.Location = new System.Drawing.Point(510, 92);
            this.btnListTerritories.Name = "btnListTerritories";
            this.btnListTerritories.Size = new System.Drawing.Size(139, 39);
            this.btnListTerritories.TabIndex = 14;
            this.btnListTerritories.Text = "List Territories";
            this.btnListTerritories.UseVisualStyleBackColor = false;
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.ForeColor = System.Drawing.Color.White;
            this.rdbID.Location = new System.Drawing.Point(374, 30);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(48, 27);
            this.rdbID.TabIndex = 10;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "ID";
            this.rdbID.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(510, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 39);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cbbRegionSearch
            // 
            this.cbbRegionSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbRegionSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRegionSearch.ForeColor = System.Drawing.Color.White;
            this.cbbRegionSearch.FormattingEnabled = true;
            this.cbbRegionSearch.Location = new System.Drawing.Point(174, 105);
            this.cbbRegionSearch.Name = "cbbRegionSearch";
            this.cbbRegionSearch.Size = new System.Drawing.Size(194, 31);
            this.cbbRegionSearch.TabIndex = 9;
            // 
            // txtTerritoryDescriptionSearch
            // 
            this.txtTerritoryDescriptionSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtTerritoryDescriptionSearch.ForeColor = System.Drawing.Color.White;
            this.txtTerritoryDescriptionSearch.Location = new System.Drawing.Point(174, 66);
            this.txtTerritoryDescriptionSearch.Name = "txtTerritoryDescriptionSearch";
            this.txtTerritoryDescriptionSearch.Size = new System.Drawing.Size(194, 30);
            this.txtTerritoryDescriptionSearch.TabIndex = 8;
            // 
            // txtTerritoryIDSearch
            // 
            this.txtTerritoryIDSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtTerritoryIDSearch.ForeColor = System.Drawing.Color.White;
            this.txtTerritoryIDSearch.Location = new System.Drawing.Point(174, 30);
            this.txtTerritoryIDSearch.Name = "txtTerritoryIDSearch";
            this.txtTerritoryIDSearch.Size = new System.Drawing.Size(194, 30);
            this.txtTerritoryIDSearch.TabIndex = 7;
            // 
            // lblTerritoryIDSearch
            // 
            this.lblTerritoryIDSearch.AutoSize = true;
            this.lblTerritoryIDSearch.ForeColor = System.Drawing.Color.White;
            this.lblTerritoryIDSearch.Location = new System.Drawing.Point(73, 34);
            this.lblTerritoryIDSearch.Name = "lblTerritoryIDSearch";
            this.lblTerritoryIDSearch.Size = new System.Drawing.Size(98, 23);
            this.lblTerritoryIDSearch.TabIndex = 1;
            this.lblTerritoryIDSearch.Text = "Territory ID:";
            // 
            // lblRegioSearch
            // 
            this.lblRegioSearch.AutoSize = true;
            this.lblRegioSearch.ForeColor = System.Drawing.Color.White;
            this.lblRegioSearch.Location = new System.Drawing.Point(104, 108);
            this.lblRegioSearch.Name = "lblRegioSearch";
            this.lblRegioSearch.Size = new System.Drawing.Size(67, 23);
            this.lblRegioSearch.TabIndex = 1;
            this.lblRegioSearch.Text = "Region:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbRegion);
            this.groupBox2.Controls.Add(this.rdbDescription);
            this.groupBox2.Controls.Add(this.btnListTerritories);
            this.groupBox2.Controls.Add(this.rdbID);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.cbbRegionSearch);
            this.groupBox2.Controls.Add(this.txtTerritoryDescriptionSearch);
            this.groupBox2.Controls.Add(this.txtTerritoryIDSearch);
            this.groupBox2.Controls.Add(this.lblTerritoryIDSearch);
            this.groupBox2.Controls.Add(this.lblTerritoryDescriptionSearch);
            this.groupBox2.Controls.Add(this.lblRegioSearch);
            this.groupBox2.Location = new System.Drawing.Point(11, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 151);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // lblTerritoryDescriptionSearch
            // 
            this.lblTerritoryDescriptionSearch.AutoSize = true;
            this.lblTerritoryDescriptionSearch.ForeColor = System.Drawing.Color.White;
            this.lblTerritoryDescriptionSearch.Location = new System.Drawing.Point(4, 70);
            this.lblTerritoryDescriptionSearch.Name = "lblTerritoryDescriptionSearch";
            this.lblTerritoryDescriptionSearch.Size = new System.Drawing.Size(167, 23);
            this.lblTerritoryDescriptionSearch.TabIndex = 1;
            this.lblTerritoryDescriptionSearch.Text = "Territory Description:";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(1076, -1);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(32, 33);
            this.btnX.TabIndex = 20;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbRegion);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblRegionID);
            this.groupBox1.Controls.Add(this.lblTerritoryDescription);
            this.groupBox1.Controls.Add(this.lblTerritories);
            this.groupBox1.Controls.Add(this.lblTerritoryID);
            this.groupBox1.Controls.Add(this.txtTerritoryDescription);
            this.groupBox1.Controls.Add(this.txtTerritoryID);
            this.groupBox1.Location = new System.Drawing.Point(676, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 451);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // cbbRegion
            // 
            this.cbbRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRegion.ForeColor = System.Drawing.Color.White;
            this.cbbRegion.FormattingEnabled = true;
            this.cbbRegion.Location = new System.Drawing.Point(183, 191);
            this.cbbRegion.Name = "cbbRegion";
            this.cbbRegion.Size = new System.Drawing.Size(194, 31);
            this.cbbRegion.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(183, 328);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 39);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(183, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(194, 39);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(183, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblRegionID
            // 
            this.lblRegionID.AutoSize = true;
            this.lblRegionID.ForeColor = System.Drawing.Color.White;
            this.lblRegionID.Location = new System.Drawing.Point(113, 194);
            this.lblRegionID.Name = "lblRegionID";
            this.lblRegionID.Size = new System.Drawing.Size(67, 23);
            this.lblRegionID.TabIndex = 1;
            this.lblRegionID.Text = "Region:";
            // 
            // lblTerritoryDescription
            // 
            this.lblTerritoryDescription.AutoSize = true;
            this.lblTerritoryDescription.ForeColor = System.Drawing.Color.White;
            this.lblTerritoryDescription.Location = new System.Drawing.Point(13, 156);
            this.lblTerritoryDescription.Name = "lblTerritoryDescription";
            this.lblTerritoryDescription.Size = new System.Drawing.Size(167, 23);
            this.lblTerritoryDescription.TabIndex = 1;
            this.lblTerritoryDescription.Text = "Territory Description:";
            // 
            // lblTerritories
            // 
            this.lblTerritories.AutoSize = true;
            this.lblTerritories.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTerritories.ForeColor = System.Drawing.Color.White;
            this.lblTerritories.Location = new System.Drawing.Point(119, 26);
            this.lblTerritories.Name = "lblTerritories";
            this.lblTerritories.Size = new System.Drawing.Size(188, 35);
            this.lblTerritories.TabIndex = 1;
            this.lblTerritories.Text = "TERRITORIES";
            // 
            // lblTerritoryID
            // 
            this.lblTerritoryID.AutoSize = true;
            this.lblTerritoryID.ForeColor = System.Drawing.Color.White;
            this.lblTerritoryID.Location = new System.Drawing.Point(82, 120);
            this.lblTerritoryID.Name = "lblTerritoryID";
            this.lblTerritoryID.Size = new System.Drawing.Size(98, 23);
            this.lblTerritoryID.TabIndex = 1;
            this.lblTerritoryID.Text = "Territory ID:";
            // 
            // txtTerritoryDescription
            // 
            this.txtTerritoryDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtTerritoryDescription.ForeColor = System.Drawing.Color.White;
            this.txtTerritoryDescription.Location = new System.Drawing.Point(183, 152);
            this.txtTerritoryDescription.Name = "txtTerritoryDescription";
            this.txtTerritoryDescription.Size = new System.Drawing.Size(194, 30);
            this.txtTerritoryDescription.TabIndex = 2;
            // 
            // txtTerritoryID
            // 
            this.txtTerritoryID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtTerritoryID.ForeColor = System.Drawing.Color.White;
            this.txtTerritoryID.Location = new System.Drawing.Point(183, 116);
            this.txtTerritoryID.Name = "txtTerritoryID";
            this.txtTerritoryID.Size = new System.Drawing.Size(194, 30);
            this.txtTerritoryID.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 173);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(664, 299);
            this.dataGridView1.TabIndex = 19;
            // 
            // frmTerritories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1107, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTerritories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTerritories";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton rdbRegion;
        private RadioButton rdbDescription;
        private Button btnListTerritories;
        private RadioButton rdbID;
        private Button btnSearch;
        private ComboBox cbbRegionSearch;
        private TextBox txtTerritoryDescriptionSearch;
        private TextBox txtTerritoryIDSearch;
        private Label lblTerritoryIDSearch;
        private Label lblRegioSearch;
        private GroupBox groupBox2;
        private Label lblTerritoryDescriptionSearch;
        private Button btnX;
        private GroupBox groupBox1;
        private ComboBox cbbRegion;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label lblRegionID;
        private Label lblTerritoryDescription;
        private Label lblTerritories;
        private Label lblTerritoryID;
        private TextBox txtTerritoryDescription;
        private TextBox txtTerritoryID;
        private DataGridView dataGridView1;
    }
}