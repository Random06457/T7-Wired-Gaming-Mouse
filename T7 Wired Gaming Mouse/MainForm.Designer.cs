namespace T7_Wired_Gaming_Mouse
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_effect = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.value_breathSpeed = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.value_neonSpeed = new System.Windows.Forms.NumericUpDown();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.value_steadyBrightness = new System.Windows.Forms.TrackBar();
            this.value_effect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.value_transition = new System.Windows.Forms.ComboBox();
            this.tab_transition = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.value_blinkTimes = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.value_blinkFrequency = new System.Windows.Forms.NumericUpDown();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.value_steadyTime = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_dpi = new System.Windows.Forms.GroupBox();
            this.label_dpi5 = new System.Windows.Forms.Label();
            this.value_dpiColor5 = new System.Windows.Forms.PictureBox();
            this.check_dpiEnable5 = new System.Windows.Forms.CheckBox();
            this.value_dpi5 = new System.Windows.Forms.TrackBar();
            this.label_dpi4 = new System.Windows.Forms.Label();
            this.value_dpiColor4 = new System.Windows.Forms.PictureBox();
            this.check_dpiEnable4 = new System.Windows.Forms.CheckBox();
            this.value_dpi4 = new System.Windows.Forms.TrackBar();
            this.label_dpi3 = new System.Windows.Forms.Label();
            this.value_dpiColor3 = new System.Windows.Forms.PictureBox();
            this.check_dpiEnable3 = new System.Windows.Forms.CheckBox();
            this.value_dpi3 = new System.Windows.Forms.TrackBar();
            this.label_dpi2 = new System.Windows.Forms.Label();
            this.value_dpiColor2 = new System.Windows.Forms.PictureBox();
            this.check_dpiEnable2 = new System.Windows.Forms.CheckBox();
            this.value_dpi2 = new System.Windows.Forms.TrackBar();
            this.label_dpi1 = new System.Windows.Forms.Label();
            this.value_dpiColor1 = new System.Windows.Forms.PictureBox();
            this.check_dpiEnable1 = new System.Windows.Forms.CheckBox();
            this.value_dpi1 = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tab_effect.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_breathSpeed)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_neonSpeed)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_steadyBrightness)).BeginInit();
            this.tab_transition.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_blinkTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_blinkFrequency)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_steadyTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_dpi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpiColor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpi5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpiColor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpi4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpiColor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpi3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpiColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpiColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpi1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(127, 389);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 0;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.Btn_apply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brightness :";
            // 
            // tab_effect
            // 
            this.tab_effect.Controls.Add(this.tabPage2);
            this.tab_effect.Controls.Add(this.tabPage3);
            this.tab_effect.Controls.Add(this.tabPage1);
            this.tab_effect.Location = new System.Drawing.Point(3, 26);
            this.tab_effect.Name = "tab_effect";
            this.tab_effect.SelectedIndex = 0;
            this.tab_effect.Size = new System.Drawing.Size(166, 74);
            this.tab_effect.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.value_breathSpeed);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(158, 48);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Speed (sec.)";
            // 
            // value_breathSpeed
            // 
            this.value_breathSpeed.Location = new System.Drawing.Point(60, 23);
            this.value_breathSpeed.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.value_breathSpeed.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.value_breathSpeed.Name = "value_breathSpeed";
            this.value_breathSpeed.Size = new System.Drawing.Size(38, 20);
            this.value_breathSpeed.TabIndex = 3;
            this.value_breathSpeed.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.value_neonSpeed);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(158, 48);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Speed (sec.)";
            // 
            // value_neonSpeed
            // 
            this.value_neonSpeed.DecimalPlaces = 1;
            this.value_neonSpeed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.value_neonSpeed.Location = new System.Drawing.Point(60, 23);
            this.value_neonSpeed.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            this.value_neonSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.value_neonSpeed.Name = "value_neonSpeed";
            this.value_neonSpeed.Size = new System.Drawing.Size(38, 20);
            this.value_neonSpeed.TabIndex = 5;
            this.value_neonSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.value_steadyBrightness);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(158, 48);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // value_steadyBrightness
            // 
            this.value_steadyBrightness.BackColor = System.Drawing.SystemColors.Control;
            this.value_steadyBrightness.Location = new System.Drawing.Point(6, 23);
            this.value_steadyBrightness.Name = "value_steadyBrightness";
            this.value_steadyBrightness.Size = new System.Drawing.Size(147, 45);
            this.value_steadyBrightness.TabIndex = 3;
            // 
            // value_effect
            // 
            this.value_effect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.value_effect.FormattingEnabled = true;
            this.value_effect.Items.AddRange(new object[] {
            "Breath",
            "Neon",
            "Steady"});
            this.value_effect.Location = new System.Drawing.Point(26, 29);
            this.value_effect.Name = "value_effect";
            this.value_effect.Size = new System.Drawing.Size(121, 21);
            this.value_effect.TabIndex = 4;
            this.value_effect.SelectedIndexChanged += new System.EventHandler(this.Value_effect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Effect :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Transition :";
            // 
            // value_transition
            // 
            this.value_transition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.value_transition.FormattingEnabled = true;
            this.value_transition.Items.AddRange(new object[] {
            "None",
            "Blink",
            "Steady"});
            this.value_transition.Location = new System.Drawing.Point(26, 114);
            this.value_transition.Name = "value_transition";
            this.value_transition.Size = new System.Drawing.Size(121, 21);
            this.value_transition.TabIndex = 6;
            this.value_transition.SelectedIndexChanged += new System.EventHandler(this.Value_transition_SelectedIndexChanged);
            // 
            // tab_transition
            // 
            this.tab_transition.Controls.Add(this.tabPage4);
            this.tab_transition.Controls.Add(this.tabPage5);
            this.tab_transition.Controls.Add(this.tabPage6);
            this.tab_transition.Location = new System.Drawing.Point(3, 111);
            this.tab_transition.Name = "tab_transition";
            this.tab_transition.SelectedIndex = 0;
            this.tab_transition.Size = new System.Drawing.Size(166, 74);
            this.tab_transition.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(158, 48);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.value_blinkTimes);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.value_blinkFrequency);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(158, 48);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Times";
            // 
            // value_blinkTimes
            // 
            this.value_blinkTimes.Location = new System.Drawing.Point(110, 23);
            this.value_blinkTimes.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.value_blinkTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.value_blinkTimes.Name = "value_blinkTimes";
            this.value_blinkTimes.Size = new System.Drawing.Size(38, 20);
            this.value_blinkTimes.TabIndex = 5;
            this.value_blinkTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Frequency (Hz)";
            // 
            // value_blinkFrequency
            // 
            this.value_blinkFrequency.Location = new System.Drawing.Point(28, 23);
            this.value_blinkFrequency.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.value_blinkFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.value_blinkFrequency.Name = "value_blinkFrequency";
            this.value_blinkFrequency.Size = new System.Drawing.Size(38, 20);
            this.value_blinkFrequency.TabIndex = 3;
            this.value_blinkFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.value_steadyTime);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(158, 48);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Time (sec.)";
            // 
            // value_steadyTime
            // 
            this.value_steadyTime.DecimalPlaces = 1;
            this.value_steadyTime.Location = new System.Drawing.Point(60, 23);
            this.value_steadyTime.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            this.value_steadyTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.value_steadyTime.Name = "value_steadyTime";
            this.value_steadyTime.Size = new System.Drawing.Size(38, 20);
            this.value_steadyTime.TabIndex = 5;
            this.value_steadyTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.value_transition);
            this.groupBox1.Controls.Add(this.tab_transition);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.value_effect);
            this.groupBox1.Controls.Add(this.tab_effect);
            this.groupBox1.Location = new System.Drawing.Point(78, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 189);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LED";
            // 
            // groupBox_dpi
            // 
            this.groupBox_dpi.Controls.Add(this.label_dpi5);
            this.groupBox_dpi.Controls.Add(this.value_dpiColor5);
            this.groupBox_dpi.Controls.Add(this.check_dpiEnable5);
            this.groupBox_dpi.Controls.Add(this.value_dpi5);
            this.groupBox_dpi.Controls.Add(this.label_dpi4);
            this.groupBox_dpi.Controls.Add(this.value_dpiColor4);
            this.groupBox_dpi.Controls.Add(this.check_dpiEnable4);
            this.groupBox_dpi.Controls.Add(this.value_dpi4);
            this.groupBox_dpi.Controls.Add(this.label_dpi3);
            this.groupBox_dpi.Controls.Add(this.value_dpiColor3);
            this.groupBox_dpi.Controls.Add(this.check_dpiEnable3);
            this.groupBox_dpi.Controls.Add(this.value_dpi3);
            this.groupBox_dpi.Controls.Add(this.label_dpi2);
            this.groupBox_dpi.Controls.Add(this.value_dpiColor2);
            this.groupBox_dpi.Controls.Add(this.check_dpiEnable2);
            this.groupBox_dpi.Controls.Add(this.value_dpi2);
            this.groupBox_dpi.Controls.Add(this.label_dpi1);
            this.groupBox_dpi.Controls.Add(this.value_dpiColor1);
            this.groupBox_dpi.Controls.Add(this.check_dpiEnable1);
            this.groupBox_dpi.Controls.Add(this.value_dpi1);
            this.groupBox_dpi.Location = new System.Drawing.Point(21, 200);
            this.groupBox_dpi.Name = "groupBox_dpi";
            this.groupBox_dpi.Size = new System.Drawing.Size(286, 178);
            this.groupBox_dpi.TabIndex = 10;
            this.groupBox_dpi.TabStop = false;
            this.groupBox_dpi.Text = "DPI";
            // 
            // label_dpi5
            // 
            this.label_dpi5.AutoSize = true;
            this.label_dpi5.Location = new System.Drawing.Point(224, 137);
            this.label_dpi5.Name = "label_dpi5";
            this.label_dpi5.Size = new System.Drawing.Size(34, 13);
            this.label_dpi5.TabIndex = 19;
            this.label_dpi5.Text = "0 DPI";
            // 
            // value_dpiColor5
            // 
            this.value_dpiColor5.BackColor = System.Drawing.Color.Red;
            this.value_dpiColor5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_dpiColor5.Location = new System.Drawing.Point(34, 135);
            this.value_dpiColor5.Name = "value_dpiColor5";
            this.value_dpiColor5.Size = new System.Drawing.Size(18, 20);
            this.value_dpiColor5.TabIndex = 18;
            this.value_dpiColor5.TabStop = false;
            this.value_dpiColor5.Click += new System.EventHandler(this.Value_dpiColor_Click);
            // 
            // check_dpiEnable5
            // 
            this.check_dpiEnable5.AutoSize = true;
            this.check_dpiEnable5.Checked = true;
            this.check_dpiEnable5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_dpiEnable5.Location = new System.Drawing.Point(14, 138);
            this.check_dpiEnable5.Name = "check_dpiEnable5";
            this.check_dpiEnable5.Size = new System.Drawing.Size(15, 14);
            this.check_dpiEnable5.TabIndex = 17;
            this.check_dpiEnable5.UseVisualStyleBackColor = true;
            // 
            // value_dpi5
            // 
            this.value_dpi5.LargeChange = 1;
            this.value_dpi5.Location = new System.Drawing.Point(53, 132);
            this.value_dpi5.Maximum = 16;
            this.value_dpi5.Minimum = 1;
            this.value_dpi5.Name = "value_dpi5";
            this.value_dpi5.Size = new System.Drawing.Size(169, 45);
            this.value_dpi5.TabIndex = 16;
            this.value_dpi5.Value = 1;
            this.value_dpi5.Scroll += new System.EventHandler(this.Value_dpi_Scroll);
            // 
            // label_dpi4
            // 
            this.label_dpi4.AutoSize = true;
            this.label_dpi4.Location = new System.Drawing.Point(224, 108);
            this.label_dpi4.Name = "label_dpi4";
            this.label_dpi4.Size = new System.Drawing.Size(34, 13);
            this.label_dpi4.TabIndex = 15;
            this.label_dpi4.Text = "0 DPI";
            // 
            // value_dpiColor4
            // 
            this.value_dpiColor4.BackColor = System.Drawing.Color.Red;
            this.value_dpiColor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_dpiColor4.Location = new System.Drawing.Point(34, 106);
            this.value_dpiColor4.Name = "value_dpiColor4";
            this.value_dpiColor4.Size = new System.Drawing.Size(18, 20);
            this.value_dpiColor4.TabIndex = 14;
            this.value_dpiColor4.TabStop = false;
            this.value_dpiColor4.Click += new System.EventHandler(this.Value_dpiColor_Click);
            // 
            // check_dpiEnable4
            // 
            this.check_dpiEnable4.AutoSize = true;
            this.check_dpiEnable4.Checked = true;
            this.check_dpiEnable4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_dpiEnable4.Location = new System.Drawing.Point(14, 109);
            this.check_dpiEnable4.Name = "check_dpiEnable4";
            this.check_dpiEnable4.Size = new System.Drawing.Size(15, 14);
            this.check_dpiEnable4.TabIndex = 13;
            this.check_dpiEnable4.UseVisualStyleBackColor = true;
            // 
            // value_dpi4
            // 
            this.value_dpi4.LargeChange = 1;
            this.value_dpi4.Location = new System.Drawing.Point(53, 103);
            this.value_dpi4.Maximum = 16;
            this.value_dpi4.Minimum = 1;
            this.value_dpi4.Name = "value_dpi4";
            this.value_dpi4.Size = new System.Drawing.Size(169, 45);
            this.value_dpi4.TabIndex = 12;
            this.value_dpi4.Value = 1;
            this.value_dpi4.Scroll += new System.EventHandler(this.Value_dpi_Scroll);
            // 
            // label_dpi3
            // 
            this.label_dpi3.AutoSize = true;
            this.label_dpi3.Location = new System.Drawing.Point(224, 79);
            this.label_dpi3.Name = "label_dpi3";
            this.label_dpi3.Size = new System.Drawing.Size(34, 13);
            this.label_dpi3.TabIndex = 11;
            this.label_dpi3.Text = "0 DPI";
            // 
            // value_dpiColor3
            // 
            this.value_dpiColor3.BackColor = System.Drawing.Color.Red;
            this.value_dpiColor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_dpiColor3.Location = new System.Drawing.Point(34, 77);
            this.value_dpiColor3.Name = "value_dpiColor3";
            this.value_dpiColor3.Size = new System.Drawing.Size(18, 20);
            this.value_dpiColor3.TabIndex = 10;
            this.value_dpiColor3.TabStop = false;
            this.value_dpiColor3.Click += new System.EventHandler(this.Value_dpiColor_Click);
            // 
            // check_dpiEnable3
            // 
            this.check_dpiEnable3.AutoSize = true;
            this.check_dpiEnable3.Checked = true;
            this.check_dpiEnable3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_dpiEnable3.Location = new System.Drawing.Point(14, 80);
            this.check_dpiEnable3.Name = "check_dpiEnable3";
            this.check_dpiEnable3.Size = new System.Drawing.Size(15, 14);
            this.check_dpiEnable3.TabIndex = 9;
            this.check_dpiEnable3.UseVisualStyleBackColor = true;
            // 
            // value_dpi3
            // 
            this.value_dpi3.LargeChange = 1;
            this.value_dpi3.Location = new System.Drawing.Point(53, 74);
            this.value_dpi3.Maximum = 16;
            this.value_dpi3.Minimum = 1;
            this.value_dpi3.Name = "value_dpi3";
            this.value_dpi3.Size = new System.Drawing.Size(169, 45);
            this.value_dpi3.TabIndex = 8;
            this.value_dpi3.Value = 1;
            this.value_dpi3.Scroll += new System.EventHandler(this.Value_dpi_Scroll);
            // 
            // label_dpi2
            // 
            this.label_dpi2.AutoSize = true;
            this.label_dpi2.Location = new System.Drawing.Point(224, 50);
            this.label_dpi2.Name = "label_dpi2";
            this.label_dpi2.Size = new System.Drawing.Size(34, 13);
            this.label_dpi2.TabIndex = 7;
            this.label_dpi2.Text = "0 DPI";
            // 
            // value_dpiColor2
            // 
            this.value_dpiColor2.BackColor = System.Drawing.Color.Red;
            this.value_dpiColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_dpiColor2.Location = new System.Drawing.Point(34, 48);
            this.value_dpiColor2.Name = "value_dpiColor2";
            this.value_dpiColor2.Size = new System.Drawing.Size(18, 20);
            this.value_dpiColor2.TabIndex = 6;
            this.value_dpiColor2.TabStop = false;
            this.value_dpiColor2.Click += new System.EventHandler(this.Value_dpiColor_Click);
            // 
            // check_dpiEnable2
            // 
            this.check_dpiEnable2.AutoSize = true;
            this.check_dpiEnable2.Checked = true;
            this.check_dpiEnable2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_dpiEnable2.Location = new System.Drawing.Point(14, 51);
            this.check_dpiEnable2.Name = "check_dpiEnable2";
            this.check_dpiEnable2.Size = new System.Drawing.Size(15, 14);
            this.check_dpiEnable2.TabIndex = 5;
            this.check_dpiEnable2.UseVisualStyleBackColor = true;
            // 
            // value_dpi2
            // 
            this.value_dpi2.LargeChange = 1;
            this.value_dpi2.Location = new System.Drawing.Point(53, 45);
            this.value_dpi2.Maximum = 16;
            this.value_dpi2.Minimum = 1;
            this.value_dpi2.Name = "value_dpi2";
            this.value_dpi2.Size = new System.Drawing.Size(169, 45);
            this.value_dpi2.TabIndex = 4;
            this.value_dpi2.Value = 1;
            this.value_dpi2.Scroll += new System.EventHandler(this.Value_dpi_Scroll);
            // 
            // label_dpi1
            // 
            this.label_dpi1.AutoSize = true;
            this.label_dpi1.Location = new System.Drawing.Point(224, 21);
            this.label_dpi1.Name = "label_dpi1";
            this.label_dpi1.Size = new System.Drawing.Size(34, 13);
            this.label_dpi1.TabIndex = 3;
            this.label_dpi1.Text = "0 DPI";
            // 
            // value_dpiColor1
            // 
            this.value_dpiColor1.BackColor = System.Drawing.Color.Red;
            this.value_dpiColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_dpiColor1.Location = new System.Drawing.Point(34, 19);
            this.value_dpiColor1.Name = "value_dpiColor1";
            this.value_dpiColor1.Size = new System.Drawing.Size(18, 20);
            this.value_dpiColor1.TabIndex = 2;
            this.value_dpiColor1.TabStop = false;
            this.value_dpiColor1.Click += new System.EventHandler(this.Value_dpiColor_Click);
            // 
            // check_dpiEnable1
            // 
            this.check_dpiEnable1.AutoSize = true;
            this.check_dpiEnable1.Checked = true;
            this.check_dpiEnable1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_dpiEnable1.Location = new System.Drawing.Point(14, 22);
            this.check_dpiEnable1.Name = "check_dpiEnable1";
            this.check_dpiEnable1.Size = new System.Drawing.Size(15, 14);
            this.check_dpiEnable1.TabIndex = 1;
            this.check_dpiEnable1.UseVisualStyleBackColor = true;
            // 
            // value_dpi1
            // 
            this.value_dpi1.LargeChange = 1;
            this.value_dpi1.Location = new System.Drawing.Point(53, 16);
            this.value_dpi1.Maximum = 16;
            this.value_dpi1.Minimum = 1;
            this.value_dpi1.Name = "value_dpi1";
            this.value_dpi1.Size = new System.Drawing.Size(169, 45);
            this.value_dpi1.TabIndex = 0;
            this.value_dpi1.Value = 1;
            this.value_dpi1.Scroll += new System.EventHandler(this.Value_dpi_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 422);
            this.Controls.Add(this.groupBox_dpi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T7 Wired Gaming Mouse";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tab_effect.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_breathSpeed)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_neonSpeed)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_steadyBrightness)).EndInit();
            this.tab_transition.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_blinkTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_blinkFrequency)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_steadyTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_dpi.ResumeLayout(false);
            this.groupBox_dpi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpiColor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpi5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpiColor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpi4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpiColor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpi3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpiColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpiColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_dpi1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab_effect;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox value_effect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox value_transition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown value_breathSpeed;
        private System.Windows.Forms.TrackBar value_steadyBrightness;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown value_neonSpeed;
        private System.Windows.Forms.TabControl tab_transition;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown value_blinkFrequency;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown value_steadyTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown value_blinkTimes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_dpi;
        private System.Windows.Forms.TrackBar value_dpi1;
        private System.Windows.Forms.Label label_dpi5;
        private System.Windows.Forms.PictureBox value_dpiColor5;
        private System.Windows.Forms.CheckBox check_dpiEnable5;
        private System.Windows.Forms.TrackBar value_dpi5;
        private System.Windows.Forms.Label label_dpi4;
        private System.Windows.Forms.PictureBox value_dpiColor4;
        private System.Windows.Forms.CheckBox check_dpiEnable4;
        private System.Windows.Forms.TrackBar value_dpi4;
        private System.Windows.Forms.Label label_dpi3;
        private System.Windows.Forms.PictureBox value_dpiColor3;
        private System.Windows.Forms.CheckBox check_dpiEnable3;
        private System.Windows.Forms.TrackBar value_dpi3;
        private System.Windows.Forms.Label label_dpi2;
        private System.Windows.Forms.PictureBox value_dpiColor2;
        private System.Windows.Forms.CheckBox check_dpiEnable2;
        private System.Windows.Forms.TrackBar value_dpi2;
        private System.Windows.Forms.Label label_dpi1;
        private System.Windows.Forms.PictureBox value_dpiColor1;
        private System.Windows.Forms.CheckBox check_dpiEnable1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

