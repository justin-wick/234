using System.Windows.Forms;

namespace 草堂街道社会智能数据管理系统
{
    partial class ppmanager
    {
        public Form main = null; 
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckb_educational = new System.Windows.Forms.CheckBox();
            this.ckb_vip = new System.Windows.Forms.CheckBox();
            this.ckb_unjob = new System.Windows.Forms.CheckBox();
            this.ckb_clean = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.ckb_kongchao = new System.Windows.Forms.CheckBox();
            this.cbk_mind = new System.Windows.Forms.CheckBox();
            this.ckb_dope = new System.Windows.Forms.CheckBox();
            this.ckb_jwry = new System.Windows.Forms.CheckBox();
            this.ckb_released = new System.Windows.Forms.CheckBox();
            this.ckb_correction = new System.Windows.Forms.CheckBox();
            this.ckb_poor = new System.Windows.Forms.CheckBox();
            this.ckb_oldman = new System.Windows.Forms.CheckBox();
            this.ckb_canjiren = new System.Windows.Forms.CheckBox();
            this.ckb_changzhu = new System.Windows.Forms.CheckBox();
            this.ckb_liudong = new System.Windows.Forms.CheckBox();
            this.ssyl_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sswg_cb = new System.Windows.Forms.ComboBox();
            this.sssq_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.block = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handicapped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.old = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jwry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.released = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加人员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ckb_educational);
            this.groupBox1.Controls.Add(this.ckb_vip);
            this.groupBox1.Controls.Add(this.ckb_unjob);
            this.groupBox1.Controls.Add(this.ckb_clean);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.ckb_kongchao);
            this.groupBox1.Controls.Add(this.cbk_mind);
            this.groupBox1.Controls.Add(this.ckb_dope);
            this.groupBox1.Controls.Add(this.ckb_jwry);
            this.groupBox1.Controls.Add(this.ckb_released);
            this.groupBox1.Controls.Add(this.ckb_correction);
            this.groupBox1.Controls.Add(this.ckb_poor);
            this.groupBox1.Controls.Add(this.ckb_oldman);
            this.groupBox1.Controls.Add(this.ckb_canjiren);
            this.groupBox1.Controls.Add(this.ckb_changzhu);
            this.groupBox1.Controls.Add(this.ckb_liudong);
            this.groupBox1.Controls.Add(this.ssyl_cb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sswg_cb);
            this.groupBox1.Controls.Add(this.sssq_cb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdCard);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 141);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人员管理";
            // 
            // ckb_educational
            // 
            this.ckb_educational.AutoSize = true;
            this.ckb_educational.Location = new System.Drawing.Point(698, 87);
            this.ckb_educational.Name = "ckb_educational";
            this.ckb_educational.Size = new System.Drawing.Size(48, 16);
            this.ckb_educational.TabIndex = 26;
            this.ckb_educational.Text = "党员";
            this.ckb_educational.UseVisualStyleBackColor = true;
            // 
            // ckb_vip
            // 
            this.ckb_vip.AutoSize = true;
            this.ckb_vip.Location = new System.Drawing.Point(698, 65);
            this.ckb_vip.Name = "ckb_vip";
            this.ckb_vip.Size = new System.Drawing.Size(72, 16);
            this.ckb_vip.TabIndex = 25;
            this.ckb_vip.Text = "重要人员";
            this.ckb_vip.UseVisualStyleBackColor = true;
            // 
            // ckb_unjob
            // 
            this.ckb_unjob.AutoSize = true;
            this.ckb_unjob.Location = new System.Drawing.Point(698, 42);
            this.ckb_unjob.Name = "ckb_unjob";
            this.ckb_unjob.Size = new System.Drawing.Size(72, 16);
            this.ckb_unjob.TabIndex = 24;
            this.ckb_unjob.Text = "失业人员";
            this.ckb_unjob.UseVisualStyleBackColor = true;
            // 
            // ckb_clean
            // 
            this.ckb_clean.AutoSize = true;
            this.ckb_clean.Location = new System.Drawing.Point(698, 20);
            this.ckb_clean.Name = "ckb_clean";
            this.ckb_clean.Size = new System.Drawing.Size(72, 16);
            this.ckb_clean.TabIndex = 23;
            this.ckb_clean.Text = "清洁人员";
            this.ckb_clean.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(903, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(819, 112);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 21;
            this.search.Text = "筛选";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // ckb_kongchao
            // 
            this.ckb_kongchao.AutoSize = true;
            this.ckb_kongchao.Enabled = false;
            this.ckb_kongchao.Location = new System.Drawing.Point(500, 86);
            this.ckb_kongchao.Name = "ckb_kongchao";
            this.ckb_kongchao.Size = new System.Drawing.Size(48, 16);
            this.ckb_kongchao.TabIndex = 20;
            this.ckb_kongchao.Text = "空巢";
            this.ckb_kongchao.UseVisualStyleBackColor = true;
            // 
            // cbk_mind
            // 
            this.cbk_mind.AutoSize = true;
            this.cbk_mind.Enabled = false;
            this.cbk_mind.Location = new System.Drawing.Point(500, 64);
            this.cbk_mind.Name = "cbk_mind";
            this.cbk_mind.Size = new System.Drawing.Size(48, 16);
            this.cbk_mind.TabIndex = 19;
            this.cbk_mind.Text = "精神";
            this.cbk_mind.UseVisualStyleBackColor = true;
            // 
            // ckb_dope
            // 
            this.ckb_dope.AutoSize = true;
            this.ckb_dope.Location = new System.Drawing.Point(596, 87);
            this.ckb_dope.Name = "ckb_dope";
            this.ckb_dope.Size = new System.Drawing.Size(72, 16);
            this.ckb_dope.TabIndex = 18;
            this.ckb_dope.Text = "吸毒人员";
            this.ckb_dope.UseVisualStyleBackColor = true;
            // 
            // ckb_jwry
            // 
            this.ckb_jwry.AutoSize = true;
            this.ckb_jwry.Location = new System.Drawing.Point(434, 108);
            this.ckb_jwry.Name = "ckb_jwry";
            this.ckb_jwry.Size = new System.Drawing.Size(72, 16);
            this.ckb_jwry.TabIndex = 17;
            this.ckb_jwry.Text = "境外人员";
            this.ckb_jwry.UseVisualStyleBackColor = true;
            // 
            // ckb_released
            // 
            this.ckb_released.AutoSize = true;
            this.ckb_released.Location = new System.Drawing.Point(596, 42);
            this.ckb_released.Name = "ckb_released";
            this.ckb_released.Size = new System.Drawing.Size(72, 16);
            this.ckb_released.TabIndex = 16;
            this.ckb_released.Text = "刑满人员";
            this.ckb_released.UseVisualStyleBackColor = true;
            // 
            // ckb_correction
            // 
            this.ckb_correction.AutoSize = true;
            this.ckb_correction.Location = new System.Drawing.Point(596, 20);
            this.ckb_correction.Name = "ckb_correction";
            this.ckb_correction.Size = new System.Drawing.Size(72, 16);
            this.ckb_correction.TabIndex = 15;
            this.ckb_correction.Text = "矫正人员";
            this.ckb_correction.UseVisualStyleBackColor = true;
            // 
            // ckb_poor
            // 
            this.ckb_poor.AutoSize = true;
            this.ckb_poor.Location = new System.Drawing.Point(596, 65);
            this.ckb_poor.Name = "ckb_poor";
            this.ckb_poor.Size = new System.Drawing.Size(72, 16);
            this.ckb_poor.TabIndex = 14;
            this.ckb_poor.Text = "低保人员";
            this.ckb_poor.UseVisualStyleBackColor = true;
            // 
            // ckb_oldman
            // 
            this.ckb_oldman.AutoSize = true;
            this.ckb_oldman.Location = new System.Drawing.Point(434, 86);
            this.ckb_oldman.Name = "ckb_oldman";
            this.ckb_oldman.Size = new System.Drawing.Size(60, 16);
            this.ckb_oldman.TabIndex = 13;
            this.ckb_oldman.Text = "老年人";
            this.ckb_oldman.UseVisualStyleBackColor = true;
            this.ckb_oldman.CheckedChanged += new System.EventHandler(this.ckb_oldman_CheckedChanged);
            // 
            // ckb_canjiren
            // 
            this.ckb_canjiren.AutoSize = true;
            this.ckb_canjiren.Location = new System.Drawing.Point(434, 64);
            this.ckb_canjiren.Name = "ckb_canjiren";
            this.ckb_canjiren.Size = new System.Drawing.Size(60, 16);
            this.ckb_canjiren.TabIndex = 12;
            this.ckb_canjiren.Text = "残疾人";
            this.ckb_canjiren.UseVisualStyleBackColor = true;
            this.ckb_canjiren.CheckedChanged += new System.EventHandler(this.ckb_canjiren_CheckedChanged);
            // 
            // ckb_changzhu
            // 
            this.ckb_changzhu.AutoSize = true;
            this.ckb_changzhu.Location = new System.Drawing.Point(434, 42);
            this.ckb_changzhu.Name = "ckb_changzhu";
            this.ckb_changzhu.Size = new System.Drawing.Size(72, 16);
            this.ckb_changzhu.TabIndex = 11;
            this.ckb_changzhu.Text = "常住人员";
            this.ckb_changzhu.UseVisualStyleBackColor = true;
            // 
            // ckb_liudong
            // 
            this.ckb_liudong.AutoSize = true;
            this.ckb_liudong.Location = new System.Drawing.Point(434, 20);
            this.ckb_liudong.Name = "ckb_liudong";
            this.ckb_liudong.Size = new System.Drawing.Size(72, 16);
            this.ckb_liudong.TabIndex = 10;
            this.ckb_liudong.Text = "流动人员";
            this.ckb_liudong.UseVisualStyleBackColor = true;
            // 
            // ssyl_cb
            // 
            this.ssyl_cb.FormattingEnabled = true;
            this.ssyl_cb.Location = new System.Drawing.Point(233, 95);
            this.ssyl_cb.Name = "ssyl_cb";
            this.ssyl_cb.Size = new System.Drawing.Size(121, 20);
            this.ssyl_cb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "所属院落";
            // 
            // sswg_cb
            // 
            this.sswg_cb.FormattingEnabled = true;
            this.sswg_cb.Location = new System.Drawing.Point(233, 60);
            this.sswg_cb.Name = "sswg_cb";
            this.sswg_cb.Size = new System.Drawing.Size(121, 20);
            this.sswg_cb.TabIndex = 7;
            this.sswg_cb.SelectedIndexChanged += new System.EventHandler(this.sswg_cb_SelectedIndexChanged);
            // 
            // sssq_cb
            // 
            this.sssq_cb.FormattingEnabled = true;
            this.sssq_cb.Location = new System.Drawing.Point(233, 22);
            this.sssq_cb.Name = "sssq_cb";
            this.sssq_cb.Size = new System.Drawing.Size(121, 20);
            this.sssq_cb.TabIndex = 6;
            this.sssq_cb.SelectedIndexChanged += new System.EventHandler(this.sssq_cb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "所属网格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "所属社区";
            // 
            // txtIdCard
            // 
            this.txtIdCard.Location = new System.Drawing.Point(57, 60);
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(100, 21);
            this.txtIdCard.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "身份证";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(57, 22);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 523);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.district,
            this.grid,
            this.cardid,
            this.block,
            this.ad,
            this.member,
            this.resident,
            this.handicapped,
            this.old,
            this.alone,
            this.jwry,
            this.syry,
            this.vip,
            this.clear,
            this.correction,
            this.released,
            this.poor,
            this.dope});
            this.dgv.Location = new System.Drawing.Point(3, 17);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(978, 503);
            this.dgv.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.DataPropertyName = "na";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 54;
            // 
            // district
            // 
            this.district.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.district.DataPropertyName = "nd";
            this.district.HeaderText = "所属社区";
            this.district.Name = "district";
            this.district.ReadOnly = true;
            this.district.Width = 78;
            // 
            // grid
            // 
            this.grid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.grid.DataPropertyName = "ng";
            this.grid.HeaderText = "所属网格";
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Width = 78;
            // 
            // cardid
            // 
            this.cardid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cardid.DataPropertyName = "cid";
            this.cardid.HeaderText = "身份证";
            this.cardid.Name = "cardid";
            this.cardid.ReadOnly = true;
            this.cardid.Width = 66;
            // 
            // block
            // 
            this.block.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.block.DataPropertyName = "nb";
            this.block.HeaderText = "所属院落";
            this.block.Name = "block";
            this.block.ReadOnly = true;
            this.block.Width = 78;
            // 
            // ad
            // 
            this.ad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ad.DataPropertyName = "ad";
            this.ad.HeaderText = "居住地址";
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            this.ad.Width = 78;
            // 
            // member
            // 
            this.member.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.member.DataPropertyName = "edu";
            this.member.HeaderText = "党员";
            this.member.Name = "member";
            this.member.ReadOnly = true;
            this.member.Width = 54;
            // 
            // resident
            // 
            this.resident.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.resident.DataPropertyName = "res";
            this.resident.HeaderText = "常住人员";
            this.resident.Name = "resident";
            this.resident.ReadOnly = true;
            this.resident.Width = 78;
            // 
            // handicapped
            // 
            this.handicapped.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.handicapped.DataPropertyName = "hand";
            this.handicapped.HeaderText = "残疾人";
            this.handicapped.Name = "handicapped";
            this.handicapped.ReadOnly = true;
            this.handicapped.Width = 66;
            // 
            // old
            // 
            this.old.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.old.DataPropertyName = "old";
            this.old.HeaderText = "老年人";
            this.old.Name = "old";
            this.old.ReadOnly = true;
            this.old.Width = 66;
            // 
            // alone
            // 
            this.alone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alone.DataPropertyName = "olda";
            this.alone.HeaderText = "空巢老人";
            this.alone.Name = "alone";
            this.alone.ReadOnly = true;
            this.alone.Width = 78;
            // 
            // jwry
            // 
            this.jwry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jwry.DataPropertyName = "fore";
            this.jwry.HeaderText = "境外人员";
            this.jwry.Name = "jwry";
            this.jwry.ReadOnly = true;
            this.jwry.Width = 78;
            // 
            // syry
            // 
            this.syry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.syry.DataPropertyName = "unjob";
            this.syry.HeaderText = "失业人员";
            this.syry.Name = "syry";
            this.syry.ReadOnly = true;
            this.syry.Width = 78;
            // 
            // vip
            // 
            this.vip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vip.DataPropertyName = "vip";
            this.vip.HeaderText = "重要人员";
            this.vip.Name = "vip";
            this.vip.ReadOnly = true;
            this.vip.Width = 78;
            // 
            // clear
            // 
            this.clear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clear.DataPropertyName = "cle";
            this.clear.HeaderText = "清洁人员 ";
            this.clear.Name = "clear";
            this.clear.ReadOnly = true;
            this.clear.Width = 78;
            // 
            // correction
            // 
            this.correction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.correction.DataPropertyName = "cor";
            this.correction.HeaderText = "矫正人员";
            this.correction.Name = "correction";
            this.correction.ReadOnly = true;
            this.correction.Width = 78;
            // 
            // released
            // 
            this.released.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.released.DataPropertyName = "rel";
            this.released.HeaderText = "刑满人员";
            this.released.Name = "released";
            this.released.ReadOnly = true;
            this.released.Width = 78;
            // 
            // poor
            // 
            this.poor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.poor.DataPropertyName = "poor";
            this.poor.HeaderText = "低保人员";
            this.poor.Name = "poor";
            this.poor.ReadOnly = true;
            this.poor.Width = 78;
            // 
            // dope
            // 
            this.dope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dope.DataPropertyName = "dope";
            this.dope.HeaderText = "吸毒人员";
            this.dope.Name = "dope";
            this.dope.ReadOnly = true;
            this.dope.Width = 78;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加人员ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(76, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加人员ToolStripMenuItem
            // 
            this.添加人员ToolStripMenuItem.Name = "添加人员ToolStripMenuItem";
            this.添加人员ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加人员ToolStripMenuItem.Tag = "add";
            this.添加人员ToolStripMenuItem.Text = "添加人员";
            this.添加人员ToolStripMenuItem.Click += new System.EventHandler(this.添加人员ToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(730, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "导出结果";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ppmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 707);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ppmanager";
            this.Text = "人员管理";
            this.Load += new System.EventHandler(this.ppmanager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckb_jwry;
        private System.Windows.Forms.CheckBox ckb_released;
        private System.Windows.Forms.CheckBox ckb_correction;
        private System.Windows.Forms.CheckBox ckb_poor;
        private System.Windows.Forms.CheckBox ckb_oldman;
        private System.Windows.Forms.CheckBox ckb_canjiren;
        private System.Windows.Forms.CheckBox ckb_changzhu;
        private System.Windows.Forms.CheckBox ckb_liudong;
        private System.Windows.Forms.ComboBox ssyl_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sswg_cb;
        private System.Windows.Forms.ComboBox sssq_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbk_mind;
        private System.Windows.Forms.CheckBox ckb_dope;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckb_kongchao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加人员ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private CheckBox ckb_vip;
        private CheckBox ckb_unjob;
        private CheckBox ckb_clean;
        private CheckBox ckb_educational;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn district;
        private DataGridViewTextBoxColumn grid;
        private DataGridViewTextBoxColumn cardid;
        private DataGridViewTextBoxColumn block;
        private DataGridViewTextBoxColumn ad;
        private DataGridViewTextBoxColumn member;
        private DataGridViewTextBoxColumn resident;
        private DataGridViewTextBoxColumn handicapped;
        private DataGridViewTextBoxColumn old;
        private DataGridViewTextBoxColumn alone;
        private DataGridViewTextBoxColumn jwry;
        private DataGridViewTextBoxColumn syry;
        private DataGridViewTextBoxColumn vip;
        private DataGridViewTextBoxColumn clear;
        private DataGridViewTextBoxColumn correction;
        private DataGridViewTextBoxColumn released;
        private DataGridViewTextBoxColumn poor;
        private DataGridViewTextBoxColumn dope;
        private Button button2;
    }
}