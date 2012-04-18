namespace ZfactorCal
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabData = new System.Windows.Forms.TabControl();
            this.tabComposition = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.boxTableName = new System.Windows.Forms.ComboBox();
            this.inputDataBase = new System.Windows.Forms.Button();
            this.inputExcel = new System.Windows.Forms.Button();
            this.dgComposition = new System.Windows.Forms.DataGridView();
            this.tabReDen = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelReDen = new System.Windows.Forms.Label();
            this.radioNormal = new System.Windows.Forms.RadioButton();
            this.radioCondensate = new System.Windows.Forms.RadioButton();
            this.radioHP = new System.Windows.Forms.RadioButton();
            this.radioSoar = new System.Windows.Forms.RadioButton();
            this.groupGas = new System.Windows.Forms.GroupBox();
            this.checkAdvance = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GXQ = new System.Windows.Forms.RadioButton();
            this.WichertAziz = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DPR = new System.Windows.Forms.RadioButton();
            this.DAK = new System.Windows.Forms.RadioButton();
            this.HY = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sutton05 = new System.Windows.Forms.RadioButton();
            this.Sutton85 = new System.Windows.Forms.RadioButton();
            this.Standing = new System.Windows.Forms.RadioButton();
            this.SSBV = new System.Windows.Forms.RadioButton();
            this.SBV = new System.Windows.Forms.RadioButton();
            this.Kay = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalculationBut = new System.Windows.Forms.Button();
            this.LXF = new System.Windows.Forms.RadioButton();
            this.tabData.SuspendLayout();
            this.tabComposition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgComposition)).BeginInit();
            this.tabReDen.SuspendLayout();
            this.groupGas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabData
            // 
            this.tabData.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabData.Controls.Add(this.tabComposition);
            this.tabData.Controls.Add(this.tabReDen);
            this.tabData.Location = new System.Drawing.Point(12, 12);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(418, 419);
            this.tabData.TabIndex = 0;
            this.tabData.SelectedIndexChanged += new System.EventHandler(this.tabData_SelectedIndexChanged);
            // 
            // tabComposition
            // 
            this.tabComposition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabComposition.Controls.Add(this.label3);
            this.tabComposition.Controls.Add(this.boxTableName);
            this.tabComposition.Controls.Add(this.inputDataBase);
            this.tabComposition.Controls.Add(this.inputExcel);
            this.tabComposition.Controls.Add(this.dgComposition);
            this.tabComposition.Location = new System.Drawing.Point(4, 25);
            this.tabComposition.Name = "tabComposition";
            this.tabComposition.Padding = new System.Windows.Forms.Padding(3);
            this.tabComposition.Size = new System.Drawing.Size(410, 390);
            this.tabComposition.TabIndex = 0;
            this.tabComposition.Text = "已知天然气组分";
            this.tabComposition.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(134, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "选择表单";
            // 
            // boxTableName
            // 
            this.boxTableName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.boxTableName.FormattingEnabled = true;
            this.boxTableName.Location = new System.Drawing.Point(128, 300);
            this.boxTableName.Name = "boxTableName";
            this.boxTableName.Size = new System.Drawing.Size(121, 24);
            this.boxTableName.TabIndex = 3;
            this.boxTableName.SelectedIndexChanged += new System.EventHandler(this.boxTableName_SelectedIndexChanged);
            // 
            // inputDataBase
            // 
            this.inputDataBase.Location = new System.Drawing.Point(6, 343);
            this.inputDataBase.Name = "inputDataBase";
            this.inputDataBase.Size = new System.Drawing.Size(100, 28);
            this.inputDataBase.TabIndex = 2;
            this.inputDataBase.Text = "数据库导入";
            this.inputDataBase.UseVisualStyleBackColor = true;
            this.inputDataBase.Click += new System.EventHandler(this.inputDataBase_Click);
            // 
            // inputExcel
            // 
            this.inputExcel.Location = new System.Drawing.Point(6, 285);
            this.inputExcel.Name = "inputExcel";
            this.inputExcel.Size = new System.Drawing.Size(100, 28);
            this.inputExcel.TabIndex = 1;
            this.inputExcel.Text = "导入Excel表格";
            this.inputExcel.UseVisualStyleBackColor = true;
            this.inputExcel.Click += new System.EventHandler(this.inputData_Click);
            // 
            // dgComposition
            // 
            this.dgComposition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComposition.Location = new System.Drawing.Point(-1, -1);
            this.dgComposition.Name = "dgComposition";
            this.dgComposition.RowTemplate.Height = 23;
            this.dgComposition.Size = new System.Drawing.Size(410, 269);
            this.dgComposition.TabIndex = 0;
            // 
            // tabReDen
            // 
            this.tabReDen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabReDen.Controls.Add(this.textBox1);
            this.tabReDen.Controls.Add(this.labelReDen);
            this.tabReDen.Location = new System.Drawing.Point(4, 25);
            this.tabReDen.Name = "tabReDen";
            this.tabReDen.Padding = new System.Windows.Forms.Padding(3);
            this.tabReDen.Size = new System.Drawing.Size(410, 390);
            this.tabReDen.TabIndex = 1;
            this.tabReDen.Text = "已知天然气相对密度";
            this.tabReDen.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 21);
            this.textBox1.TabIndex = 1;
            // 
            // labelReDen
            // 
            this.labelReDen.AutoSize = true;
            this.labelReDen.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelReDen.Location = new System.Drawing.Point(3, 40);
            this.labelReDen.Name = "labelReDen";
            this.labelReDen.Size = new System.Drawing.Size(221, 25);
            this.labelReDen.TabIndex = 0;
            this.labelReDen.Text = "请输入天然气相对密度：";
            // 
            // radioNormal
            // 
            this.radioNormal.AutoSize = true;
            this.radioNormal.Checked = true;
            this.radioNormal.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioNormal.Location = new System.Drawing.Point(19, 37);
            this.radioNormal.Name = "radioNormal";
            this.radioNormal.Size = new System.Drawing.Size(103, 23);
            this.radioNormal.TabIndex = 1;
            this.radioNormal.TabStop = true;
            this.radioNormal.Text = "普通气藏";
            this.radioNormal.UseVisualStyleBackColor = true;
            // 
            // radioCondensate
            // 
            this.radioCondensate.AutoSize = true;
            this.radioCondensate.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioCondensate.Location = new System.Drawing.Point(295, 37);
            this.radioCondensate.Name = "radioCondensate";
            this.radioCondensate.Size = new System.Drawing.Size(103, 23);
            this.radioCondensate.TabIndex = 2;
            this.radioCondensate.Text = "凝析气藏";
            this.radioCondensate.UseVisualStyleBackColor = true;
            // 
            // radioHP
            // 
            this.radioHP.AutoSize = true;
            this.radioHP.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioHP.Location = new System.Drawing.Point(151, 37);
            this.radioHP.Name = "radioHP";
            this.radioHP.Size = new System.Drawing.Size(103, 23);
            this.radioHP.TabIndex = 3;
            this.radioHP.Text = "高压气藏";
            this.radioHP.UseVisualStyleBackColor = true;
            // 
            // radioSoar
            // 
            this.radioSoar.AutoSize = true;
            this.radioSoar.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioSoar.Location = new System.Drawing.Point(435, 37);
            this.radioSoar.Name = "radioSoar";
            this.radioSoar.Size = new System.Drawing.Size(103, 23);
            this.radioSoar.TabIndex = 4;
            this.radioSoar.Text = "酸气气藏";
            this.radioSoar.UseVisualStyleBackColor = true;
            // 
            // groupGas
            // 
            this.groupGas.Controls.Add(this.radioSoar);
            this.groupGas.Controls.Add(this.radioHP);
            this.groupGas.Controls.Add(this.radioCondensate);
            this.groupGas.Controls.Add(this.radioNormal);
            this.groupGas.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupGas.Location = new System.Drawing.Point(458, 12);
            this.groupGas.Name = "groupGas";
            this.groupGas.Size = new System.Drawing.Size(559, 79);
            this.groupGas.TabIndex = 5;
            this.groupGas.TabStop = false;
            this.groupGas.Text = "气藏类型";
            // 
            // checkAdvance
            // 
            this.checkAdvance.AutoSize = true;
            this.checkAdvance.Location = new System.Drawing.Point(3, 3);
            this.checkAdvance.Name = "checkAdvance";
            this.checkAdvance.Size = new System.Drawing.Size(72, 16);
            this.checkAdvance.TabIndex = 3;
            this.checkAdvance.Text = "高级模式";
            this.checkAdvance.UseVisualStyleBackColor = true;
            this.checkAdvance.CheckedChanged += new System.EventHandler(this.checkAdvance_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.checkAdvance);
            this.panel1.Location = new System.Drawing.Point(458, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 324);
            this.panel1.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GXQ);
            this.groupBox3.Controls.Add(this.WichertAziz);
            this.groupBox3.Location = new System.Drawing.Point(19, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 82);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "非烃气体校正式";
            this.groupBox3.Visible = false;
            // 
            // GXQ
            // 
            this.GXQ.AutoSize = true;
            this.GXQ.Enabled = false;
            this.GXQ.Location = new System.Drawing.Point(166, 31);
            this.GXQ.Name = "GXQ";
            this.GXQ.Size = new System.Drawing.Size(41, 16);
            this.GXQ.TabIndex = 1;
            this.GXQ.TabStop = true;
            this.GXQ.Text = "GXQ";
            this.GXQ.UseVisualStyleBackColor = true;
            // 
            // WichertAziz
            // 
            this.WichertAziz.AutoSize = true;
            this.WichertAziz.Enabled = false;
            this.WichertAziz.Location = new System.Drawing.Point(32, 31);
            this.WichertAziz.Name = "WichertAziz";
            this.WichertAziz.Size = new System.Drawing.Size(95, 16);
            this.WichertAziz.TabIndex = 0;
            this.WichertAziz.TabStop = true;
            this.WichertAziz.Text = "Wichert-Aziz";
            this.WichertAziz.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LXF);
            this.groupBox2.Controls.Add(this.DPR);
            this.groupBox2.Controls.Add(this.DAK);
            this.groupBox2.Controls.Add(this.HY);
            this.groupBox2.Location = new System.Drawing.Point(19, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 94);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "计算公式";
            this.groupBox2.Visible = false;
            // 
            // DPR
            // 
            this.DPR.AutoSize = true;
            this.DPR.Enabled = false;
            this.DPR.Location = new System.Drawing.Point(330, 25);
            this.DPR.Name = "DPR";
            this.DPR.Size = new System.Drawing.Size(167, 16);
            this.DPR.TabIndex = 2;
            this.DPR.TabStop = true;
            this.DPR.Text = "Dranchuk-Purvis-Robinson";
            this.DPR.UseVisualStyleBackColor = true;
            // 
            // DAK
            // 
            this.DAK.AutoSize = true;
            this.DAK.Enabled = false;
            this.DAK.Location = new System.Drawing.Point(166, 25);
            this.DAK.Name = "DAK";
            this.DAK.Size = new System.Drawing.Size(143, 16);
            this.DAK.TabIndex = 1;
            this.DAK.TabStop = true;
            this.DAK.Text = "Dranchuk-Abou-Kassem";
            this.DAK.UseVisualStyleBackColor = true;
            // 
            // HY
            // 
            this.HY.AutoSize = true;
            this.HY.Enabled = false;
            this.HY.Location = new System.Drawing.Point(32, 25);
            this.HY.Name = "HY";
            this.HY.Size = new System.Drawing.Size(107, 16);
            this.HY.TabIndex = 0;
            this.HY.TabStop = true;
            this.HY.Text = "Hall-Yaborough";
            this.HY.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sutton05);
            this.groupBox1.Controls.Add(this.Sutton85);
            this.groupBox1.Controls.Add(this.Standing);
            this.groupBox1.Controls.Add(this.SSBV);
            this.groupBox1.Controls.Add(this.SBV);
            this.groupBox1.Controls.Add(this.Kay);
            this.groupBox1.Location = new System.Drawing.Point(19, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "混合规则";
            this.groupBox1.Visible = false;
            // 
            // Sutton05
            // 
            this.Sutton05.AutoSize = true;
            this.Sutton05.Enabled = false;
            this.Sutton05.Location = new System.Drawing.Point(300, 56);
            this.Sutton05.Name = "Sutton05";
            this.Sutton05.Size = new System.Drawing.Size(83, 16);
            this.Sutton05.TabIndex = 5;
            this.Sutton05.TabStop = true;
            this.Sutton05.Text = "Sutton 05\'";
            this.Sutton05.UseVisualStyleBackColor = true;
            // 
            // Sutton85
            // 
            this.Sutton85.AutoSize = true;
            this.Sutton85.Enabled = false;
            this.Sutton85.Location = new System.Drawing.Point(166, 56);
            this.Sutton85.Name = "Sutton85";
            this.Sutton85.Size = new System.Drawing.Size(83, 16);
            this.Sutton85.TabIndex = 4;
            this.Sutton85.TabStop = true;
            this.Sutton85.Text = "Sutton 85\'";
            this.Sutton85.UseVisualStyleBackColor = true;
            // 
            // Standing
            // 
            this.Standing.AutoSize = true;
            this.Standing.Enabled = false;
            this.Standing.Location = new System.Drawing.Point(32, 56);
            this.Standing.Name = "Standing";
            this.Standing.Size = new System.Drawing.Size(71, 16);
            this.Standing.TabIndex = 3;
            this.Standing.TabStop = true;
            this.Standing.Text = "Standing";
            this.Standing.UseVisualStyleBackColor = true;
            // 
            // SSBV
            // 
            this.SSBV.AutoSize = true;
            this.SSBV.Location = new System.Drawing.Point(300, 20);
            this.SSBV.Name = "SSBV";
            this.SSBV.Size = new System.Drawing.Size(47, 16);
            this.SSBV.TabIndex = 2;
            this.SSBV.TabStop = true;
            this.SSBV.Text = "SSBV";
            this.SSBV.UseVisualStyleBackColor = true;
            // 
            // SBV
            // 
            this.SBV.AutoSize = true;
            this.SBV.Location = new System.Drawing.Point(166, 20);
            this.SBV.Name = "SBV";
            this.SBV.Size = new System.Drawing.Size(41, 16);
            this.SBV.TabIndex = 1;
            this.SBV.TabStop = true;
            this.SBV.Text = "SBV";
            this.SBV.UseVisualStyleBackColor = true;
            // 
            // Kay
            // 
            this.Kay.AutoSize = true;
            this.Kay.Location = new System.Drawing.Point(32, 20);
            this.Kay.Name = "Kay";
            this.Kay.Size = new System.Drawing.Size(41, 16);
            this.Kay.TabIndex = 0;
            this.Kay.TabStop = true;
            this.Kay.Text = "Kay";
            this.Kay.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 475);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 21);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(442, 469);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 21);
            this.textBox3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // CalculationBut
            // 
            this.CalculationBut.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CalculationBut.Location = new System.Drawing.Point(918, 469);
            this.CalculationBut.Name = "CalculationBut";
            this.CalculationBut.Size = new System.Drawing.Size(99, 34);
            this.CalculationBut.TabIndex = 11;
            this.CalculationBut.Text = "计算";
            this.CalculationBut.UseVisualStyleBackColor = true;
            // 
            // LXF
            // 
            this.LXF.AutoSize = true;
            this.LXF.Enabled = false;
            this.LXF.Location = new System.Drawing.Point(32, 61);
            this.LXF.Name = "LXF";
            this.LXF.Size = new System.Drawing.Size(41, 16);
            this.LXF.TabIndex = 3;
            this.LXF.TabStop = true;
            this.LXF.Text = "LXF";
            this.LXF.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 574);
            this.Controls.Add(this.CalculationBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupGas);
            this.Controls.Add(this.tabData);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "天然气压缩因子计算";
            this.tabData.ResumeLayout(false);
            this.tabComposition.ResumeLayout(false);
            this.tabComposition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgComposition)).EndInit();
            this.tabReDen.ResumeLayout(false);
            this.tabReDen.PerformLayout();
            this.groupGas.ResumeLayout(false);
            this.groupGas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabData;
        private System.Windows.Forms.TabPage tabComposition;
        private System.Windows.Forms.TabPage tabReDen;
        private System.Windows.Forms.Button inputExcel;
        private System.Windows.Forms.DataGridView dgComposition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelReDen;
        private System.Windows.Forms.Button inputDataBase;
        private System.Windows.Forms.RadioButton radioNormal;
        private System.Windows.Forms.RadioButton radioCondensate;
        private System.Windows.Forms.RadioButton radioHP;
        private System.Windows.Forms.RadioButton radioSoar;
        private System.Windows.Forms.GroupBox groupGas;
        private System.Windows.Forms.CheckBox checkAdvance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Kay;
        private System.Windows.Forms.ComboBox boxTableName;
        private System.Windows.Forms.RadioButton Sutton05;
        private System.Windows.Forms.RadioButton Sutton85;
        private System.Windows.Forms.RadioButton Standing;
        private System.Windows.Forms.RadioButton SSBV;
        private System.Windows.Forms.RadioButton SBV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton GXQ;
        private System.Windows.Forms.RadioButton WichertAziz;
        private System.Windows.Forms.RadioButton DPR;
        private System.Windows.Forms.RadioButton DAK;
        private System.Windows.Forms.RadioButton HY;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalculationBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton LXF;
        
    }
}

