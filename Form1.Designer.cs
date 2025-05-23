using System.Windows.Forms;
using System.Xml.Linq;

namespace OP_Macro
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            clickGroupBox = new GroupBox();
            clickToggleButton = new Button();
            clickHSButton = new Button();
            labelRepTimes = new Label();
            repetitionsNumBox = new NumericUpDown();
            panel2 = new Panel();
            RepetitionCB = new CheckBox();
            CTypeCB = new ComboBox();
            labelClickType = new Label();
            MButtonCB = new ComboBox();
            labelMouseButton = new Label();
            labelMilliseconds = new Label();
            TBMilliseconds = new TextBox();
            labelSeconds = new Label();
            labelMinutes = new Label();
            labelHours = new Label();
            TBSeconds = new TextBox();
            TBMinutes = new TextBox();
            TBHours = new TextBox();
            panel1 = new Panel();
            textGroupBox = new GroupBox();
            richText3 = new Button();
            richText2 = new Button();
            richText1 = new Button();
            panel6 = new Panel();
            labelTextRep = new Label();
            textCheckBox = new CheckBox();
            textNumBox = new NumericUpDown();
            textASButton = new Button();
            panel3 = new Panel();
            textHSButton = new Button();
            textTB = new TextBox();
            RARGroupBox = new GroupBox();
            recordClicksLabel = new Label();
            recordStatsCheckBox = new CheckBox();
            replayLoopLabel = new Label();
            replayStatsCheckBox = new CheckBox();
            saveCaptureButton = new Button();
            replayActionLabel = new Label();
            replayHSButton = new Button();
            recordActionLabel = new Label();
            panel4 = new Panel();
            recordHSButton = new Button();
            teleportGroupBox = new GroupBox();
            teleport2HSButton = new Button();
            Y2Label = new Label();
            X2Label = new Label();
            Y1Label = new Label();
            X1Label = new Label();
            teleportLoopsLabel = new Label();
            teleportPositionLabel = new Label();
            teleportCheckBox = new CheckBox();
            teleportY2 = new Label();
            teleportHSButton = new Button();
            teleportX2 = new Label();
            teleportY1 = new Label();
            teleportX1 = new Label();
            miscGroupBox = new GroupBox();
            panel5 = new Panel();
            creditsLabel = new Label();
            helpButton = new Button();
            autoclicker = new System.Windows.Forms.Timer(components);
            autoclickerRepetition = new System.Windows.Forms.Timer(components);
            clickGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)repetitionsNumBox).BeginInit();
            textGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textNumBox).BeginInit();
            RARGroupBox.SuspendLayout();
            teleportGroupBox.SuspendLayout();
            miscGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // clickGroupBox
            // 
            clickGroupBox.Controls.Add(clickToggleButton);
            clickGroupBox.Controls.Add(clickHSButton);
            clickGroupBox.Controls.Add(labelRepTimes);
            clickGroupBox.Controls.Add(repetitionsNumBox);
            clickGroupBox.Controls.Add(panel2);
            clickGroupBox.Controls.Add(RepetitionCB);
            clickGroupBox.Controls.Add(CTypeCB);
            clickGroupBox.Controls.Add(labelClickType);
            clickGroupBox.Controls.Add(MButtonCB);
            clickGroupBox.Controls.Add(labelMouseButton);
            clickGroupBox.Controls.Add(labelMilliseconds);
            clickGroupBox.Controls.Add(TBMilliseconds);
            clickGroupBox.Controls.Add(labelSeconds);
            clickGroupBox.Controls.Add(labelMinutes);
            clickGroupBox.Controls.Add(labelHours);
            clickGroupBox.Controls.Add(TBSeconds);
            clickGroupBox.Controls.Add(TBMinutes);
            clickGroupBox.Controls.Add(TBHours);
            clickGroupBox.Controls.Add(panel1);
            clickGroupBox.Location = new Point(11, 12);
            clickGroupBox.Name = "clickGroupBox";
            clickGroupBox.Size = new Size(962, 152);
            clickGroupBox.TabIndex = 0;
            clickGroupBox.TabStop = false;
            clickGroupBox.Text = "Click";
            // 
            // clickToggleButton
            // 
            clickToggleButton.FlatStyle = FlatStyle.Flat;
            clickToggleButton.Font = new Font("Segoe UI", 9F);
            clickToggleButton.Location = new Point(747, 85);
            clickToggleButton.Name = "clickToggleButton";
            clickToggleButton.Size = new Size(209, 60);
            clickToggleButton.TabIndex = 18;
            clickToggleButton.Text = "Включи";
            clickToggleButton.UseVisualStyleBackColor = true;
            clickToggleButton.Click += clickToggleButton_Click;
            // 
            // clickHSButton
            // 
            clickHSButton.BackColor = SystemColors.Control;
            clickHSButton.FlatStyle = FlatStyle.Flat;
            clickHSButton.Font = new Font("Segoe UI", 9F);
            clickHSButton.Location = new Point(747, 19);
            clickHSButton.Name = "clickHSButton";
            clickHSButton.Size = new Size(209, 60);
            clickHSButton.TabIndex = 16;
            clickHSButton.Text = "Настройки за бърз клавиш";
            clickHSButton.UseVisualStyleBackColor = false;
            clickHSButton.Click += clickHSButton_Click;
            // 
            // labelRepTimes
            // 
            labelRepTimes.AutoSize = true;
            labelRepTimes.Location = new Point(589, 103);
            labelRepTimes.Name = "labelRepTimes";
            labelRepTimes.Size = new Size(58, 25);
            labelRepTimes.TabIndex = 1;
            labelRepTimes.Text = "Брой:";
            // 
            // repetitionsNumBox
            // 
            repetitionsNumBox.Enabled = false;
            repetitionsNumBox.Location = new Point(647, 101);
            repetitionsNumBox.Name = "repetitionsNumBox";
            repetitionsNumBox.Size = new Size(88, 31);
            repetitionsNumBox.TabIndex = 15;
            repetitionsNumBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(741, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 125);
            panel2.TabIndex = 2;
            panel2.TabStop = true;
            // 
            // RepetitionCB
            // 
            RepetitionCB.AutoSize = true;
            RepetitionCB.Location = new Point(587, 29);
            RepetitionCB.Name = "RepetitionCB";
            RepetitionCB.Size = new Size(139, 29);
            RepetitionCB.TabIndex = 14;
            RepetitionCB.Text = "Повторение";
            RepetitionCB.UseVisualStyleBackColor = true;
            RepetitionCB.CheckedChanged += RepetitionCB_CheckedChanged;
            // 
            // CTypeCB
            // 
            CTypeCB.DisplayMember = "Single";
            CTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CTypeCB.FormattingEnabled = true;
            CTypeCB.Items.AddRange(new object[] { "Single", "Double" });
            CTypeCB.Location = new Point(424, 103);
            CTypeCB.Name = "CTypeCB";
            CTypeCB.Size = new Size(151, 33);
            CTypeCB.TabIndex = 13;
            CTypeCB.SelectedIndexChanged += CTypeCB_SelectedIndexChanged;
            // 
            // labelClickType
            // 
            labelClickType.AutoSize = true;
            labelClickType.Location = new Point(330, 103);
            labelClickType.Name = "labelClickType";
            labelClickType.Size = new Size(88, 25);
            labelClickType.TabIndex = 12;
            labelClickType.Text = "Вид клик:";
            // 
            // MButtonCB
            // 
            MButtonCB.DisplayMember = "Left";
            MButtonCB.DropDownStyle = ComboBoxStyle.DropDownList;
            MButtonCB.FormattingEnabled = true;
            MButtonCB.Items.AddRange(new object[] { "Left", "Right", "Middle" });
            MButtonCB.Location = new Point(159, 103);
            MButtonCB.Name = "MButtonCB";
            MButtonCB.Size = new Size(126, 33);
            MButtonCB.TabIndex = 11;
            MButtonCB.SelectedIndexChanged += MButtonCB_SelectedIndexChanged;
            // 
            // labelMouseButton
            // 
            labelMouseButton.AutoSize = true;
            labelMouseButton.Location = new Point(6, 103);
            labelMouseButton.Name = "labelMouseButton";
            labelMouseButton.Size = new Size(147, 25);
            labelMouseButton.TabIndex = 10;
            labelMouseButton.Text = "Бутон на мишка:";
            // 
            // labelMilliseconds
            // 
            labelMilliseconds.AutoSize = true;
            labelMilliseconds.BackColor = Color.Transparent;
            labelMilliseconds.Location = new Point(460, 30);
            labelMilliseconds.Name = "labelMilliseconds";
            labelMilliseconds.Size = new Size(119, 25);
            labelMilliseconds.TabIndex = 9;
            labelMilliseconds.Text = "милисекунди";
            // 
            // TBMilliseconds
            // 
            TBMilliseconds.Location = new Point(397, 27);
            TBMilliseconds.Name = "TBMilliseconds";
            TBMilliseconds.Size = new Size(60, 31);
            TBMilliseconds.TabIndex = 8;
            TBMilliseconds.Text = "1000";
            TBMilliseconds.TextAlign = HorizontalAlignment.Right;
            TBMilliseconds.KeyDown += TBMilliseconds_KeyDown;
            TBMilliseconds.KeyPress += TBMilliseconds_KeyPress;
            TBMilliseconds.Leave += TBMilliseconds_Leave;
            // 
            // labelSeconds
            // 
            labelSeconds.AutoSize = true;
            labelSeconds.BackColor = Color.Transparent;
            labelSeconds.Location = new Point(314, 30);
            labelSeconds.Name = "labelSeconds";
            labelSeconds.Size = new Size(77, 25);
            labelSeconds.TabIndex = 7;
            labelSeconds.Text = "секунди";
            // 
            // labelMinutes
            // 
            labelMinutes.AutoSize = true;
            labelMinutes.BackColor = Color.Transparent;
            labelMinutes.Location = new Point(180, 30);
            labelMinutes.Name = "labelMinutes";
            labelMinutes.Size = new Size(71, 25);
            labelMinutes.TabIndex = 6;
            labelMinutes.Text = "минути";
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.BackColor = Color.Transparent;
            labelHours.Location = new Point(71, 30);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(48, 25);
            labelHours.TabIndex = 5;
            labelHours.Text = "часа";
            // 
            // TBSeconds
            // 
            TBSeconds.Location = new Point(252, 27);
            TBSeconds.Name = "TBSeconds";
            TBSeconds.Size = new Size(60, 31);
            TBSeconds.TabIndex = 4;
            TBSeconds.Text = "0";
            TBSeconds.TextAlign = HorizontalAlignment.Right;
            TBSeconds.KeyDown += TBSeconds_KeyDown;
            TBSeconds.KeyPress += TBSeconds_KeyPress;
            TBSeconds.Leave += TBSeconds_Leave;
            // 
            // TBMinutes
            // 
            TBMinutes.Location = new Point(118, 27);
            TBMinutes.Name = "TBMinutes";
            TBMinutes.Size = new Size(60, 31);
            TBMinutes.TabIndex = 3;
            TBMinutes.Text = "0";
            TBMinutes.TextAlign = HorizontalAlignment.Right;
            TBMinutes.KeyDown += TBMinutes_KeyDown;
            TBMinutes.KeyPress += TBMinutes_KeyPress;
            TBMinutes.Leave += TBMinutes_Leave;
            // 
            // TBHours
            // 
            TBHours.Location = new Point(5, 27);
            TBHours.Name = "TBHours";
            TBHours.Size = new Size(60, 31);
            TBHours.TabIndex = 2;
            TBHours.Text = "0";
            TBHours.TextAlign = HorizontalAlignment.Right;
            TBHours.KeyDown += TBHours_KeyDown;
            TBHours.KeyPress += TBHours_KeyPress;
            TBHours.Leave += TBHours_Leave;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(581, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 125);
            panel1.TabIndex = 1;
            panel1.TabStop = true;
            // 
            // textGroupBox
            // 
            textGroupBox.Controls.Add(richText3);
            textGroupBox.Controls.Add(richText2);
            textGroupBox.Controls.Add(richText1);
            textGroupBox.Controls.Add(panel6);
            textGroupBox.Controls.Add(labelTextRep);
            textGroupBox.Controls.Add(textCheckBox);
            textGroupBox.Controls.Add(textNumBox);
            textGroupBox.Controls.Add(textASButton);
            textGroupBox.Controls.Add(panel3);
            textGroupBox.Controls.Add(textHSButton);
            textGroupBox.Controls.Add(textTB);
            textGroupBox.Location = new Point(12, 170);
            textGroupBox.Name = "textGroupBox";
            textGroupBox.Size = new Size(962, 152);
            textGroupBox.TabIndex = 1;
            textGroupBox.TabStop = false;
            textGroupBox.Text = "Text";
            textGroupBox.Enter += textGroupBox_Enter;
            // 
            // richText3
            // 
            richText3.FlatStyle = FlatStyle.Flat;
            richText3.Font = new Font("Segoe UI", 8F);
            richText3.Location = new Point(360, 72);
            richText3.Name = "richText3";
            richText3.Size = new Size(170, 60);
            richText3.TabIndex = 23;
            richText3.Text = "Разширен текст 3";
            richText3.UseVisualStyleBackColor = true;
            richText3.Click += richText3_Click;
            // 
            // richText2
            // 
            richText2.FlatStyle = FlatStyle.Flat;
            richText2.Font = new Font("Segoe UI", 8F);
            richText2.Location = new Point(184, 72);
            richText2.Name = "richText2";
            richText2.Size = new Size(170, 60);
            richText2.TabIndex = 22;
            richText2.Text = "Разширен текст 2";
            richText2.UseVisualStyleBackColor = true;
            richText2.Click += richText2_Click;
            // 
            // richText1
            // 
            richText1.FlatStyle = FlatStyle.Flat;
            richText1.Font = new Font("Segoe UI", 8F);
            richText1.Location = new Point(7, 72);
            richText1.Name = "richText1";
            richText1.Size = new Size(170, 60);
            richText1.TabIndex = 21;
            richText1.Text = "Разширен текст 1";
            richText1.UseVisualStyleBackColor = true;
            richText1.Click += richText1_Click;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(581, 19);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 125);
            panel6.TabIndex = 2;
            panel6.TabStop = true;
            // 
            // labelTextRep
            // 
            labelTextRep.AutoSize = true;
            labelTextRep.Location = new Point(588, 89);
            labelTextRep.Name = "labelTextRep";
            labelTextRep.Size = new Size(58, 25);
            labelTextRep.TabIndex = 19;
            labelTextRep.Text = "Брой:";
            // 
            // textCheckBox
            // 
            textCheckBox.AutoSize = true;
            textCheckBox.Location = new Point(587, 31);
            textCheckBox.Name = "textCheckBox";
            textCheckBox.Size = new Size(139, 29);
            textCheckBox.TabIndex = 19;
            textCheckBox.Text = "Повторение";
            textCheckBox.UseVisualStyleBackColor = true;
            textCheckBox.CheckedChanged += textCheckBox_CheckedChanged;
            // 
            // textNumBox
            // 
            textNumBox.Enabled = false;
            textNumBox.Location = new Point(646, 87);
            textNumBox.Name = "textNumBox";
            textNumBox.Size = new Size(88, 31);
            textNumBox.TabIndex = 20;
            textNumBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textASButton
            // 
            textASButton.FlatStyle = FlatStyle.Flat;
            textASButton.Font = new Font("Segoe UI", 8F);
            textASButton.Location = new Point(748, 87);
            textASButton.Name = "textASButton";
            textASButton.Size = new Size(209, 60);
            textASButton.TabIndex = 20;
            textASButton.Text = "Разширени настройки";
            textASButton.UseVisualStyleBackColor = true;
            textASButton.Click += textASButton_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(741, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 125);
            panel3.TabIndex = 3;
            panel3.TabStop = true;
            // 
            // textHSButton
            // 
            textHSButton.BackColor = SystemColors.Control;
            textHSButton.FlatStyle = FlatStyle.Flat;
            textHSButton.Font = new Font("Segoe UI", 9F);
            textHSButton.Location = new Point(748, 21);
            textHSButton.Name = "textHSButton";
            textHSButton.Size = new Size(209, 60);
            textHSButton.TabIndex = 19;
            textHSButton.Text = "Настройки за бърз клавиш";
            textHSButton.UseVisualStyleBackColor = false;
            textHSButton.Click += textHSButton_Click;
            // 
            // textTB
            // 
            textTB.Location = new Point(6, 27);
            textTB.Name = "textTB";
            textTB.Size = new Size(570, 31);
            textTB.TabIndex = 0;
            // 
            // RARGroupBox
            // 
            RARGroupBox.Controls.Add(recordClicksLabel);
            RARGroupBox.Controls.Add(recordStatsCheckBox);
            RARGroupBox.Controls.Add(replayLoopLabel);
            RARGroupBox.Controls.Add(replayStatsCheckBox);
            RARGroupBox.Controls.Add(saveCaptureButton);
            RARGroupBox.Controls.Add(replayActionLabel);
            RARGroupBox.Controls.Add(replayHSButton);
            RARGroupBox.Controls.Add(recordActionLabel);
            RARGroupBox.Controls.Add(panel4);
            RARGroupBox.Controls.Add(recordHSButton);
            RARGroupBox.Location = new Point(11, 329);
            RARGroupBox.Margin = new Padding(3, 4, 3, 4);
            RARGroupBox.Name = "RARGroupBox";
            RARGroupBox.Padding = new Padding(3, 4, 3, 4);
            RARGroupBox.Size = new Size(962, 152);
            RARGroupBox.TabIndex = 2;
            RARGroupBox.TabStop = false;
            RARGroupBox.Text = "Record and Replay";
            // 
            // recordClicksLabel
            // 
            recordClicksLabel.AutoSize = true;
            recordClicksLabel.Location = new Point(8, 50);
            recordClicksLabel.Name = "recordClicksLabel";
            recordClicksLabel.Size = new Size(89, 25);
            recordClicksLabel.TabIndex = 36;
            recordClicksLabel.Text = "Кликове: ";
            recordClicksLabel.Visible = false;
            // 
            // recordStatsCheckBox
            // 
            recordStatsCheckBox.AutoSize = true;
            recordStatsCheckBox.Location = new Point(161, 21);
            recordStatsCheckBox.Margin = new Padding(3, 4, 3, 4);
            recordStatsCheckBox.Name = "recordStatsCheckBox";
            recordStatsCheckBox.Size = new Size(126, 29);
            recordStatsCheckBox.TabIndex = 35;
            recordStatsCheckBox.Text = "Статистики";
            recordStatsCheckBox.UseVisualStyleBackColor = true;
            recordStatsCheckBox.CheckedChanged += recordStatsCheckBox_CheckedChanged;
            // 
            // replayLoopLabel
            // 
            replayLoopLabel.AutoSize = true;
            replayLoopLabel.BackColor = Color.Transparent;
            replayLoopLabel.Location = new Point(477, 50);
            replayLoopLabel.Name = "replayLoopLabel";
            replayLoopLabel.Size = new Size(117, 25);
            replayLoopLabel.TabIndex = 34;
            replayLoopLabel.Text = "Повторения:";
            replayLoopLabel.Visible = false;
            // 
            // replayStatsCheckBox
            // 
            replayStatsCheckBox.AutoSize = true;
            replayStatsCheckBox.Location = new Point(656, 21);
            replayStatsCheckBox.Margin = new Padding(3, 4, 3, 4);
            replayStatsCheckBox.Name = "replayStatsCheckBox";
            replayStatsCheckBox.Size = new Size(126, 29);
            replayStatsCheckBox.TabIndex = 31;
            replayStatsCheckBox.Text = "Статистики";
            replayStatsCheckBox.UseVisualStyleBackColor = true;
            replayStatsCheckBox.CheckedChanged += replayStatsCheckBox_CheckedChanged;
            // 
            // saveCaptureButton
            // 
            saveCaptureButton.FlatStyle = FlatStyle.Flat;
            saveCaptureButton.Font = new Font("Segoe UI", 9F);
            saveCaptureButton.Location = new Point(788, 88);
            saveCaptureButton.Margin = new Padding(0);
            saveCaptureButton.Name = "saveCaptureButton";
            saveCaptureButton.Size = new Size(170, 60);
            saveCaptureButton.TabIndex = 30;
            saveCaptureButton.Text = "Запази запис";
            saveCaptureButton.UseVisualStyleBackColor = true;
            saveCaptureButton.Click += saveCaptureButton_Click;
            // 
            // replayActionLabel
            // 
            replayActionLabel.AutoSize = true;
            replayActionLabel.BackColor = Color.Transparent;
            replayActionLabel.Location = new Point(477, 25);
            replayActionLabel.Name = "replayActionLabel";
            replayActionLabel.Size = new Size(100, 25);
            replayActionLabel.TabIndex = 29;
            replayActionLabel.Text = "Неактивно";
            replayActionLabel.Visible = false;
            // 
            // replayHSButton
            // 
            replayHSButton.BackColor = SystemColors.Control;
            replayHSButton.FlatStyle = FlatStyle.Flat;
            replayHSButton.Font = new Font("Segoe UI", 9F);
            replayHSButton.Location = new Point(788, 17);
            replayHSButton.Name = "replayHSButton";
            replayHSButton.Size = new Size(170, 60);
            replayHSButton.TabIndex = 27;
            replayHSButton.Text = "Настройки за бърз клавиш";
            replayHSButton.UseVisualStyleBackColor = false;
            replayHSButton.Click += replayHSButton_Click;
            // 
            // recordActionLabel
            // 
            recordActionLabel.AutoSize = true;
            recordActionLabel.Location = new Point(7, 25);
            recordActionLabel.Name = "recordActionLabel";
            recordActionLabel.Size = new Size(100, 25);
            recordActionLabel.TabIndex = 23;
            recordActionLabel.Text = "Неактивно";
            recordActionLabel.Visible = false;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(469, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 125);
            panel4.TabIndex = 4;
            panel4.TabStop = true;
            // 
            // recordHSButton
            // 
            recordHSButton.BackColor = SystemColors.Control;
            recordHSButton.FlatStyle = FlatStyle.Flat;
            recordHSButton.Font = new Font("Segoe UI", 9F);
            recordHSButton.Location = new Point(293, 23);
            recordHSButton.Name = "recordHSButton";
            recordHSButton.Size = new Size(170, 60);
            recordHSButton.TabIndex = 21;
            recordHSButton.Text = "Настройки за бърз клавиш";
            recordHSButton.UseVisualStyleBackColor = false;
            recordHSButton.Click += recordHSButton_Click;
            // 
            // teleportGroupBox
            // 
            teleportGroupBox.Controls.Add(teleport2HSButton);
            teleportGroupBox.Controls.Add(Y2Label);
            teleportGroupBox.Controls.Add(X2Label);
            teleportGroupBox.Controls.Add(Y1Label);
            teleportGroupBox.Controls.Add(X1Label);
            teleportGroupBox.Controls.Add(teleportLoopsLabel);
            teleportGroupBox.Controls.Add(teleportPositionLabel);
            teleportGroupBox.Controls.Add(teleportCheckBox);
            teleportGroupBox.Controls.Add(teleportY2);
            teleportGroupBox.Controls.Add(teleportHSButton);
            teleportGroupBox.Controls.Add(teleportX2);
            teleportGroupBox.Controls.Add(teleportY1);
            teleportGroupBox.Controls.Add(teleportX1);
            teleportGroupBox.Location = new Point(11, 489);
            teleportGroupBox.Margin = new Padding(3, 4, 3, 4);
            teleportGroupBox.Name = "teleportGroupBox";
            teleportGroupBox.Padding = new Padding(3, 4, 3, 4);
            teleportGroupBox.Size = new Size(498, 152);
            teleportGroupBox.TabIndex = 3;
            teleportGroupBox.TabStop = false;
            teleportGroupBox.Text = "Teleport";
            // 
            // teleport2HSButton
            // 
            teleport2HSButton.BackColor = SystemColors.Control;
            teleport2HSButton.FlatStyle = FlatStyle.Flat;
            teleport2HSButton.Font = new Font("Segoe UI", 9F);
            teleport2HSButton.Location = new Point(312, 85);
            teleport2HSButton.Name = "teleport2HSButton";
            teleport2HSButton.Size = new Size(180, 60);
            teleport2HSButton.TabIndex = 105;
            teleport2HSButton.Text = "Настройки за телепортация";
            teleport2HSButton.UseVisualStyleBackColor = false;
            teleport2HSButton.Click += teleport2HSButton_Click;
            // 
            // Y2Label
            // 
            Y2Label.AutoSize = true;
            Y2Label.BackColor = Color.Transparent;
            Y2Label.Location = new Point(8, 112);
            Y2Label.Name = "Y2Label";
            Y2Label.Size = new Size(36, 25);
            Y2Label.TabIndex = 104;
            Y2Label.Text = "Y2:";
            // 
            // X2Label
            // 
            X2Label.AutoSize = true;
            X2Label.BackColor = Color.Transparent;
            X2Label.Location = new Point(7, 87);
            X2Label.Name = "X2Label";
            X2Label.Size = new Size(37, 25);
            X2Label.TabIndex = 103;
            X2Label.Text = "X2:";
            // 
            // Y1Label
            // 
            Y1Label.AutoSize = true;
            Y1Label.BackColor = Color.Transparent;
            Y1Label.Location = new Point(8, 50);
            Y1Label.Name = "Y1Label";
            Y1Label.Size = new Size(36, 25);
            Y1Label.TabIndex = 102;
            Y1Label.Text = "Y1:";
            // 
            // X1Label
            // 
            X1Label.AutoSize = true;
            X1Label.BackColor = Color.Transparent;
            X1Label.Location = new Point(8, 25);
            X1Label.Name = "X1Label";
            X1Label.Size = new Size(37, 25);
            X1Label.TabIndex = 101;
            X1Label.Text = "X1:";
            // 
            // teleportLoopsLabel
            // 
            teleportLoopsLabel.AutoSize = true;
            teleportLoopsLabel.Location = new Point(157, 79);
            teleportLoopsLabel.Name = "teleportLoopsLabel";
            teleportLoopsLabel.Size = new Size(117, 25);
            teleportLoopsLabel.TabIndex = 37;
            teleportLoopsLabel.Text = "Повторения:";
            teleportLoopsLabel.Visible = false;
            // 
            // teleportPositionLabel
            // 
            teleportPositionLabel.AutoSize = true;
            teleportPositionLabel.Location = new Point(157, 54);
            teleportPositionLabel.Name = "teleportPositionLabel";
            teleportPositionLabel.Size = new Size(80, 25);
            teleportPositionLabel.TabIndex = 36;
            teleportPositionLabel.Text = "Индекс: ";
            teleportPositionLabel.Visible = false;
            // 
            // teleportCheckBox
            // 
            teleportCheckBox.AutoSize = true;
            teleportCheckBox.BackColor = Color.Transparent;
            teleportCheckBox.Location = new Point(180, 21);
            teleportCheckBox.Margin = new Padding(3, 4, 3, 4);
            teleportCheckBox.Name = "teleportCheckBox";
            teleportCheckBox.Size = new Size(126, 29);
            teleportCheckBox.TabIndex = 35;
            teleportCheckBox.Text = "Статистики";
            teleportCheckBox.UseVisualStyleBackColor = false;
            teleportCheckBox.CheckedChanged += teleportCheckBox_CheckedChanged;
            // 
            // teleportY2
            // 
            teleportY2.AutoSize = true;
            teleportY2.BackColor = Color.Transparent;
            teleportY2.Location = new Point(47, 112);
            teleportY2.Name = "teleportY2";
            teleportY2.Size = new Size(100, 25);
            teleportY2.TabIndex = 9;
            teleportY2.Text = "координат";
            // 
            // teleportHSButton
            // 
            teleportHSButton.BackColor = SystemColors.Control;
            teleportHSButton.FlatStyle = FlatStyle.Flat;
            teleportHSButton.Font = new Font("Segoe UI", 9F);
            teleportHSButton.Location = new Point(312, 20);
            teleportHSButton.Name = "teleportHSButton";
            teleportHSButton.Size = new Size(180, 60);
            teleportHSButton.TabIndex = 100;
            teleportHSButton.Text = "Настройки за координати";
            teleportHSButton.UseVisualStyleBackColor = false;
            teleportHSButton.Click += teleportHSButton_Click;
            // 
            // teleportX2
            // 
            teleportX2.AutoSize = true;
            teleportX2.BackColor = Color.Transparent;
            teleportX2.Location = new Point(47, 87);
            teleportX2.Name = "teleportX2";
            teleportX2.Size = new Size(100, 25);
            teleportX2.TabIndex = 8;
            teleportX2.Text = "координат";
            // 
            // teleportY1
            // 
            teleportY1.AutoSize = true;
            teleportY1.BackColor = Color.Transparent;
            teleportY1.Location = new Point(47, 50);
            teleportY1.Name = "teleportY1";
            teleportY1.Size = new Size(100, 25);
            teleportY1.TabIndex = 7;
            teleportY1.Text = "координат";
            // 
            // teleportX1
            // 
            teleportX1.AutoSize = true;
            teleportX1.BackColor = Color.Transparent;
            teleportX1.Location = new Point(47, 25);
            teleportX1.Name = "teleportX1";
            teleportX1.Size = new Size(100, 25);
            teleportX1.TabIndex = 6;
            teleportX1.Text = "координат";
            teleportX1.Click += teleportX1_Click;
            // 
            // miscGroupBox
            // 
            miscGroupBox.Controls.Add(panel5);
            miscGroupBox.Controls.Add(creditsLabel);
            miscGroupBox.Controls.Add(helpButton);
            miscGroupBox.Location = new Point(515, 489);
            miscGroupBox.Margin = new Padding(3, 4, 3, 4);
            miscGroupBox.Name = "miscGroupBox";
            miscGroupBox.Padding = new Padding(3, 4, 3, 4);
            miscGroupBox.Size = new Size(459, 152);
            miscGroupBox.TabIndex = 4;
            miscGroupBox.TabStop = false;
            miscGroupBox.Text = "Miscellaneous";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(274, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 125);
            panel5.TabIndex = 4;
            panel5.TabStop = true;
            panel5.Paint += panel5_Paint;
            // 
            // creditsLabel
            // 
            creditsLabel.AutoSize = true;
            creditsLabel.Location = new Point(281, 17);
            creditsLabel.Name = "creditsLabel";
            creditsLabel.Size = new Size(176, 50);
            creditsLabel.TabIndex = 36;
            creditsLabel.Text = "OP Utility Tool v1.1.1\r\nОт H. Bohosyan\r\n";
            // 
            // helpButton
            // 
            helpButton.BackColor = Color.Silver;
            helpButton.FlatStyle = FlatStyle.Flat;
            helpButton.Font = new Font("Segoe UI", 9F);
            helpButton.Location = new Point(281, 77);
            helpButton.Margin = new Padding(0);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(169, 60);
            helpButton.TabIndex = 35;
            helpButton.Text = "Помощ?";
            helpButton.UseVisualStyleBackColor = false;
            helpButton.Click += helpButton_Click;
            // 
            // autoclicker
            // 
            autoclicker.Interval = int.MaxValue;
            autoclicker.Tick += autoclicker_Tick;
            // 
            // autoclickerRepetition
            // 
            autoclickerRepetition.Interval = int.MaxValue;
            autoclickerRepetition.Tick += autoclickerRepetition_Tick;
            // 
            // Form1
            // 
            ClientSize = new Size(985, 656);
            Controls.Add(miscGroupBox);
            Controls.Add(teleportGroupBox);
            Controls.Add(RARGroupBox);
            Controls.Add(textGroupBox);
            Controls.Add(clickGroupBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "OP Utility Tool";
            clickGroupBox.ResumeLayout(false);
            clickGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)repetitionsNumBox).EndInit();
            textGroupBox.ResumeLayout(false);
            textGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textNumBox).EndInit();
            RARGroupBox.ResumeLayout(false);
            RARGroupBox.PerformLayout();
            teleportGroupBox.ResumeLayout(false);
            teleportGroupBox.PerformLayout();
            miscGroupBox.ResumeLayout(false);
            miscGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox clickGroupBox;
        private Panel panel1;
        private TextBox TBSeconds;
        private TextBox TBMinutes;
        private TextBox TBHours;
        private Label labelSeconds;
        private Label labelMinutes;
        private Label labelHours;
        private Label labelMouseButton;
        private Label labelMilliseconds;
        private TextBox TBMilliseconds;
        private ComboBox MButtonCB;
        private ComboBox CTypeCB;
        private Label labelClickType;
        private CheckBox RepetitionCB;
        private Button clickToggleButton;
        private Button clickHotkeySettings;
        private Label labelRepTimes;
        private NumericUpDown repetitionsNumBox;
        private Panel panel2;
        private GroupBox textGroupBox;
        private Button textAdvancedSettings;
        private Panel panel3;
        private Button textHotkeySettings;
        private TextBox textTB;
        private Label labelTextRep;
        private CheckBox textCheckBox;
        private NumericUpDown textNumBox;
        private GroupBox RARGroupBox;
        private Label recordActionLabel;
        private Button recordToggle;
        private Panel panel4;
        private Button recordHSButton;
        private Button replayHSButton;
        private CheckBox replayStatsCheckBox;
        private Button saveCaptureButton;
        private Label replayActionLabel;
        private Label replayLoopLabel;
        private GroupBox teleportGroupBox;
        private Label teleportY2;
        private Label teleportX2;
        private Label teleportY1;
        private Label teleportX1;
        private Button teleportHSButton;
        private Label teleportPositionLabel;
        private CheckBox teleportCheckBox;
        private Label teleportLoopsLabel;
        private GroupBox miscGroupBox;
        private Button helpButton;
        private Panel panel5;
        private Label creditsLabel;
        private Button clickHSButton;
        private Button textASButton;
        private Button textHSButton;
        private Panel panel6;
        private System.Windows.Forms.Timer autoclicker;
        private Label Y2Label;
        private Label X2Label;
        private Label Y1Label;
        private Label X1Label;
        private System.Windows.Forms.Timer autoclickerRepetition;
        private Button teleport2HSButton;
        private Button richText3;
        private Button richText2;
        private Button richText1;
        private CheckBox recordStatsCheckBox;
        private Label recordClicksLabel;
    }
}