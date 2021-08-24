namespace Demo18_08_2021
{
	partial class AdminForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.cbbFloor = new System.Windows.Forms.ComboBox();
			this.txtTableName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTableId = new System.Windows.Forms.TextBox();
			this.lvTableList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ctmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.xemDanhSáchHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.ctmsListView.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(576, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Mã bàn:";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1011, 725);
			this.tabControl1.TabIndex = 14;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnDelete);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.btnUpdate);
			this.tabPage1.Controls.Add(this.btnAdd);
			this.tabPage1.Controls.Add(this.cbbFloor);
			this.tabPage1.Controls.Add(this.txtTableName);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.txtTableId);
			this.tabPage1.Controls.Add(this.lvTableList);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1003, 699);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Danh sách bàn ăn";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1003, 677);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Món ăn/uống";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Enabled = false;
			this.btnDelete.Location = new System.Drawing.Point(815, 188);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(82, 26);
			this.btnDelete.TabIndex = 26;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Location = new System.Drawing.Point(701, 188);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(82, 26);
			this.btnUpdate.TabIndex = 27;
			this.btnUpdate.Text = "Sửa";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(579, 188);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(82, 26);
			this.btnAdd.TabIndex = 28;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// cbbFloor
			// 
			this.cbbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbFloor.FormattingEnabled = true;
			this.cbbFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.cbbFloor.Location = new System.Drawing.Point(663, 133);
			this.cbbFloor.Name = "cbbFloor";
			this.cbbFloor.Size = new System.Drawing.Size(233, 21);
			this.cbbFloor.TabIndex = 25;
			// 
			// txtTableName
			// 
			this.txtTableName.Location = new System.Drawing.Point(663, 95);
			this.txtTableName.Name = "txtTableName";
			this.txtTableName.Size = new System.Drawing.Size(234, 20);
			this.txtTableName.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(576, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 21;
			this.label3.Text = "Tầng:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(576, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 22;
			this.label2.Text = "Tên bàn:";
			// 
			// txtTableId
			// 
			this.txtTableId.Location = new System.Drawing.Point(663, 59);
			this.txtTableId.Name = "txtTableId";
			this.txtTableId.ReadOnly = true;
			this.txtTableId.Size = new System.Drawing.Size(234, 20);
			this.txtTableId.TabIndex = 24;
			// 
			// lvTableList
			// 
			this.lvTableList.CheckBoxes = true;
			this.lvTableList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvTableList.ContextMenuStrip = this.ctmsListView;
			this.lvTableList.FullRowSelect = true;
			this.lvTableList.GridLines = true;
			this.lvTableList.Location = new System.Drawing.Point(8, 10);
			this.lvTableList.MultiSelect = false;
			this.lvTableList.Name = "lvTableList";
			this.lvTableList.Size = new System.Drawing.Size(498, 606);
			this.lvTableList.TabIndex = 20;
			this.lvTableList.UseCompatibleStateImageBehavior = false;
			this.lvTableList.View = System.Windows.Forms.View.Details;
			this.lvTableList.SelectedIndexChanged += new System.EventHandler(this.lvTableList_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã bàn";
			this.columnHeader1.Width = 107;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên bàn";
			this.columnHeader2.Width = 210;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Trạng thái";
			this.columnHeader3.Width = 73;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tầng";
			this.columnHeader4.Width = 82;
			// 
			// ctmsListView
			// 
			this.ctmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.xemDanhSáchHóaĐơnToolStripMenuItem});
			this.ctmsListView.Name = "ctmsListView";
			this.ctmsListView.Size = new System.Drawing.Size(203, 48);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(202, 22);
			this.tsmiDelete.Text = "Xóa tất cả";
			this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
			// 
			// xemDanhSáchHóaĐơnToolStripMenuItem
			// 
			this.xemDanhSáchHóaĐơnToolStripMenuItem.Name = "xemDanhSáchHóaĐơnToolStripMenuItem";
			this.xemDanhSáchHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.xemDanhSáchHóaĐơnToolStripMenuItem.Text = "Xem danh sách hóa đơn";
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.tabControl1);
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý";
			this.Load += new System.EventHandler(this.AdminForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ctmsListView.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cbbFloor;
		private System.Windows.Forms.TextBox txtTableName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTableId;
		private System.Windows.Forms.ListView lvTableList;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ContextMenuStrip ctmsListView;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.ToolStripMenuItem xemDanhSáchHóaĐơnToolStripMenuItem;
	}
}