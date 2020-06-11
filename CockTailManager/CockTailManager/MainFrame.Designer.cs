namespace CockTailManager
{
    partial class MainFrame
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreat = new System.Windows.Forms.Button();
            this.cockTailDGV = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseLiqur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cockTailDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.btnDelete);
            this.mainPanel.Controls.Add(this.btnCreat);
            this.mainPanel.Controls.Add(this.cockTailDGV);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(440, 696);
            this.mainPanel.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(246, 624);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 60);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreat
            // 
            this.btnCreat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreat.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.btnCreat.Location = new System.Drawing.Point(56, 624);
            this.btnCreat.Name = "btnCreat";
            this.btnCreat.Size = new System.Drawing.Size(150, 60);
            this.btnCreat.TabIndex = 1;
            this.btnCreat.Text = "생성";
            this.btnCreat.UseVisualStyleBackColor = false;
            this.btnCreat.Click += new System.EventHandler(this.btnCreat_Click);
            // 
            // cockTailDGV
            // 
            this.cockTailDGV.AllowUserToAddRows = false;
            this.cockTailDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cockTailDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.cockTailDGV.ColumnHeadersHeight = 45;
            this.cockTailDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cockTailDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.alcohol,
            this.baseLiqur});
            this.cockTailDGV.GridColor = System.Drawing.SystemColors.Control;
            this.cockTailDGV.Location = new System.Drawing.Point(10, 10);
            this.cockTailDGV.Name = "cockTailDGV";
            this.cockTailDGV.ReadOnly = true;
            this.cockTailDGV.RowHeadersVisible = false;
            this.cockTailDGV.RowHeadersWidth = 62;
            this.cockTailDGV.RowTemplate.Height = 30;
            this.cockTailDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cockTailDGV.Size = new System.Drawing.Size(421, 604);
            this.cockTailDGV.TabIndex = 0;
            this.cockTailDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cockTailDGV_CellContentDoubleClick);
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "이름";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 160;
            // 
            // alcohol
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.alcohol.DefaultCellStyle = dataGridViewCellStyle8;
            this.alcohol.Frozen = true;
            this.alcohol.HeaderText = "도수";
            this.alcohol.MinimumWidth = 8;
            this.alcohol.Name = "alcohol";
            this.alcohol.ReadOnly = true;
            this.alcohol.Width = 130;
            // 
            // baseLiqur
            // 
            this.baseLiqur.Frozen = true;
            this.baseLiqur.HeaderText = "베이스";
            this.baseLiqur.MinimumWidth = 8;
            this.baseLiqur.Name = "baseLiqur";
            this.baseLiqur.ReadOnly = true;
            this.baseLiqur.Width = 130;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 696);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("굴림", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "칵테일 레시피 데이터베이스 관리 프로그램";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cockTailDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView cockTailDGV;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreat;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseLiqur;
    }
}

