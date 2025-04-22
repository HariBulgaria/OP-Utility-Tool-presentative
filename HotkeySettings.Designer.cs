namespace OP_Macro
{
    partial class HotkeySettings
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
            startButton = new Button();
            displayBox = new RichTextBox();
            doneButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Location = new Point(12, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(100, 38);
            startButton.TabIndex = 1;
            startButton.Text = "Смени клавиш";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // displayBox
            // 
            displayBox.BorderStyle = BorderStyle.FixedSingle;
            displayBox.Enabled = false;
            displayBox.Location = new Point(147, 12);
            displayBox.Name = "displayBox";
            displayBox.Size = new Size(100, 38);
            displayBox.TabIndex = 3;
            displayBox.Text = "";
            // 
            // doneButton
            // 
            doneButton.FlatStyle = FlatStyle.Flat;
            doneButton.Location = new Point(12, 58);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(100, 39);
            doneButton.TabIndex = 4;
            doneButton.Text = "Готово";
            doneButton.UseVisualStyleBackColor = true;
            doneButton.Click += doneButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Location = new Point(147, 58);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(100, 39);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Отказ";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // HotkeySettings
            // 
            ClientSize = new Size(259, 109);
            Controls.Add(cancelButton);
            Controls.Add(doneButton);
            Controls.Add(displayBox);
            Controls.Add(startButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HotkeySettings";
            Text = "Hotkey Settings";
            FormClosing += HotkeySettings_FormClosing;
            Load += HotkeySettings_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button startButton;
        private RichTextBox displayBox;
        private Button doneButton;
        private Button cancelButton;
    }
}