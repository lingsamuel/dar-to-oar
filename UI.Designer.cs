namespace DARtoOAR
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            darModFolderPath = new TextBox();
            darFolderPickerBtn = new Button();
            darModFolderPathLabel = new Label();
            convertBtn = new Button();
            SuspendLayout();
            // 
            // darModFolderPath
            // 
            darModFolderPath.Location = new Point(133, 47);
            darModFolderPath.Margin = new Padding(4, 5, 4, 5);
            darModFolderPath.Name = "darModFolderPath";
            darModFolderPath.Size = new Size(523, 31);
            darModFolderPath.TabIndex = 0;
            // 
            // darFolderPickerBtn
            // 
            darFolderPickerBtn.Location = new Point(17, 45);
            darFolderPickerBtn.Margin = new Padding(4, 5, 4, 5);
            darFolderPickerBtn.Name = "darFolderPickerBtn";
            darFolderPickerBtn.Size = new Size(107, 38);
            darFolderPickerBtn.TabIndex = 1;
            darFolderPickerBtn.Text = "Select Folder";
            darFolderPickerBtn.UseVisualStyleBackColor = true;
            darFolderPickerBtn.Click += darFolderPickerBtn_Click;
            // 
            // darModFolderPathLabel
            // 
            darModFolderPathLabel.AutoSize = true;
            darModFolderPathLabel.Location = new Point(17, 15);
            darModFolderPathLabel.Margin = new Padding(4, 0, 4, 0);
            darModFolderPathLabel.Name = "darModFolderPathLabel";
            darModFolderPathLabel.Size = new Size(146, 25);
            darModFolderPathLabel.TabIndex = 2;
            darModFolderPathLabel.Text = "Mod Organizer 2 Mods Folder";
            // 
            // convertBtn
            // 
            convertBtn.Location = new Point(17, 327);
            convertBtn.Margin = new Padding(4, 5, 4, 5);
            convertBtn.Name = "convertBtn";
            convertBtn.Size = new Size(177, 38);
            convertBtn.TabIndex = 6;
            convertBtn.Text = "Convert";
            convertBtn.UseVisualStyleBackColor = true;
            convertBtn.Click += convertBtn_Click;
            // 
            // UI
            // 
            AcceptButton = convertBtn;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 390);
            Controls.Add(convertBtn);
            Controls.Add(darModFolderPathLabel);
            Controls.Add(darFolderPickerBtn);
            Controls.Add(darModFolderPath);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "UI";
            Text = "DAR to OAR Converter";
            Load += UI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox darModFolderPath;
        private Button darFolderPickerBtn;
        private Label darModFolderPathLabel;
        private Button convertBtn;
    }
}