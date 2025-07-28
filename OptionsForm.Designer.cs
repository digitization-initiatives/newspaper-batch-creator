using NewspaperBatchCreation.src;
using System.Drawing.Interop;

namespace NewspaperBatchCreation
{
    partial class OptionsForm
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
            selectOutputFolderLabel = new Label();
            browseOutputFolderButton = new Button();
            outputFolderTextBox = new TextBox();
            browseOutputFolder_folderBrowserDialog = new FolderBrowserDialog();
            saveAndCloseButton = new Button();
            resetToDefaultButton = new Button();
            editionOrderLabel = new Label();
            editionOrderComboBox = new ComboBox();
            SuspendLayout();
            // 
            // selectOutputFolderLabel
            // 
            selectOutputFolderLabel.AutoSize = true;
            selectOutputFolderLabel.Location = new Point(12, 9);
            selectOutputFolderLabel.Name = "selectOutputFolderLabel";
            selectOutputFolderLabel.Size = new Size(104, 20);
            selectOutputFolderLabel.TabIndex = 32;
            selectOutputFolderLabel.Text = "Output Folder:";
            // 
            // browseOutputFolderButton
            // 
            browseOutputFolderButton.Location = new Point(944, 32);
            browseOutputFolderButton.Name = "browseOutputFolderButton";
            browseOutputFolderButton.Size = new Size(306, 29);
            browseOutputFolderButton.TabIndex = 31;
            browseOutputFolderButton.Text = "... Select Output Folder ...";
            browseOutputFolderButton.UseVisualStyleBackColor = true;
            browseOutputFolderButton.Click += browseOutputFolderButton_Click;
            // 
            // outputFolderTextBox
            // 
            outputFolderTextBox.Location = new Point(12, 32);
            outputFolderTextBox.Name = "outputFolderTextBox";
            outputFolderTextBox.ReadOnly = true;
            outputFolderTextBox.Size = new Size(926, 27);
            outputFolderTextBox.TabIndex = 30;
            // 
            // saveAndCloseButton
            // 
            saveAndCloseButton.Location = new Point(1030, 632);
            saveAndCloseButton.Name = "saveAndCloseButton";
            saveAndCloseButton.Size = new Size(220, 29);
            saveAndCloseButton.TabIndex = 33;
            saveAndCloseButton.Text = "Save and Close";
            saveAndCloseButton.UseVisualStyleBackColor = true;
            saveAndCloseButton.Click += saveAndCloseButton_Click;
            // 
            // resetToDefaultButton
            // 
            resetToDefaultButton.Location = new Point(804, 632);
            resetToDefaultButton.Name = "resetToDefaultButton";
            resetToDefaultButton.Size = new Size(220, 29);
            resetToDefaultButton.TabIndex = 34;
            resetToDefaultButton.Text = "Reset to Default";
            resetToDefaultButton.UseVisualStyleBackColor = true;
            resetToDefaultButton.Click += resetToDefaultButton_Click;
            // 
            // editionOrderLabel
            // 
            editionOrderLabel.AutoSize = true;
            editionOrderLabel.Location = new Point(12, 85);
            editionOrderLabel.Name = "editionOrderLabel";
            editionOrderLabel.Size = new Size(208, 20);
            editionOrderLabel.TabIndex = 35;
            editionOrderLabel.Text = "Edition Order (default is \"01\"):";
            // 
            // editionOrderComboBox
            // 
            editionOrderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            editionOrderComboBox.FormattingEnabled = true;
            editionOrderComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05" });
            editionOrderComboBox.Location = new Point(226, 85);
            editionOrderComboBox.Name = "editionOrderComboBox";
            editionOrderComboBox.Size = new Size(100, 28);
            editionOrderComboBox.TabIndex = 36;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(editionOrderComboBox);
            Controls.Add(editionOrderLabel);
            Controls.Add(resetToDefaultButton);
            Controls.Add(saveAndCloseButton);
            Controls.Add(selectOutputFolderLabel);
            Controls.Add(browseOutputFolderButton);
            Controls.Add(outputFolderTextBox);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "OptionsForm";
            Text = "Options";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Custom Initializations

        private MainForm mainForm;
        public LogForm logForm;
        public ComboBox editionOrderComboBox;
        public TextBox outputFolderTextBox;
        public FolderBrowserDialog browseOutputFolder_folderBrowserDialog;

        private void CustomInitialization()
        {
            //Custom form start location:
            this.StartPosition = FormStartPosition.Manual;

            outputFolderTextBox.Text = Properties.Settings.Default.OutputFolder;
        }


        #endregion


        private Label selectOutputFolderLabel;
        private Button browseOutputFolderButton;

        private Button saveAndCloseButton;
        private Button resetToDefaultButton;
        private Label editionOrderLabel;
    }
}