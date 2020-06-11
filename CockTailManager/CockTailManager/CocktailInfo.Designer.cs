namespace CockTailManager
{
    partial class CocktailInfo
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbRecipe = new System.Windows.Forms.TextBox();
            this.tbMaterial = new System.Windows.Forms.TextBox();
            this.tbBaseLiquor = new System.Windows.Forms.TextBox();
            this.tbAlcohol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tbRecipe);
            this.panel1.Controls.Add(this.tbMaterial);
            this.panel1.Controls.Add(this.tbBaseLiquor);
            this.panel1.Controls.Add(this.tbAlcohol);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 800);
            this.panel1.TabIndex = 0;
            // 
            // tbRecipe
            // 
            this.tbRecipe.Font = new System.Drawing.Font("굴림", 12F);
            this.tbRecipe.Location = new System.Drawing.Point(168, 443);
            this.tbRecipe.Multiline = true;
            this.tbRecipe.Name = "tbRecipe";
            this.tbRecipe.Size = new System.Drawing.Size(329, 336);
            this.tbRecipe.TabIndex = 9;
            this.tbRecipe.Tag = "tbInfo";
            // 
            // tbMaterial
            // 
            this.tbMaterial.Font = new System.Drawing.Font("굴림", 12F);
            this.tbMaterial.Location = new System.Drawing.Point(168, 210);
            this.tbMaterial.Multiline = true;
            this.tbMaterial.Name = "tbMaterial";
            this.tbMaterial.Size = new System.Drawing.Size(329, 208);
            this.tbMaterial.TabIndex = 8;
            this.tbMaterial.Tag = "tbInfo";
            // 
            // tbBaseLiquor
            // 
            this.tbBaseLiquor.Font = new System.Drawing.Font("굴림", 12F);
            this.tbBaseLiquor.Location = new System.Drawing.Point(168, 147);
            this.tbBaseLiquor.Name = "tbBaseLiquor";
            this.tbBaseLiquor.Size = new System.Drawing.Size(329, 35);
            this.tbBaseLiquor.TabIndex = 7;
            this.tbBaseLiquor.Tag = "tbInfo";
            // 
            // tbAlcohol
            // 
            this.tbAlcohol.Font = new System.Drawing.Font("굴림", 12F);
            this.tbAlcohol.Location = new System.Drawing.Point(168, 87);
            this.tbAlcohol.Name = "tbAlcohol";
            this.tbAlcohol.Size = new System.Drawing.Size(329, 35);
            this.tbAlcohol.TabIndex = 6;
            this.tbAlcohol.Tag = "tbInfo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F);
            this.label5.Location = new System.Drawing.Point(30, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "레시피 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(30, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "재료    : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(30, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "베이스 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "도수    : ";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("굴림", 12F);
            this.tbName.Location = new System.Drawing.Point(168, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(329, 35);
            this.tbName.TabIndex = 1;
            this.tbName.Tag = "tbInfo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름    : ";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(40, 830);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 50);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(203, 830);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 50);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(367, 830);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 50);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CocktailInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(549, 892);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CocktailInfo";
            this.ShowIcon = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbRecipe;
        private System.Windows.Forms.TextBox tbMaterial;
        private System.Windows.Forms.TextBox tbBaseLiquor;
        private System.Windows.Forms.TextBox tbAlcohol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnSave;
    }
}
