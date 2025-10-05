namespace MessageWallHomework
{
    partial class MessageWall
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.addMessage = new System.Windows.Forms.Button();
            this.messageDisplay = new System.Windows.Forms.ListBox();
            this.messagesDisplayBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(25, 61);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(193, 40);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(216, 53);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(226, 48);
            this.firstNameText.TabIndex = 1;
            this.firstNameText.TextChanged += new System.EventHandler(this.firstNameText_TextChanged);
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(651, 60);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(204, 48);
            this.lastNameText.TabIndex = 2;
            this.lastNameText.TextChanged += new System.EventHandler(this.lastNameText_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(489, 63);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(191, 40);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // addMessage
            // 
            this.addMessage.Location = new System.Drawing.Point(893, 60);
            this.addMessage.Name = "addMessage";
            this.addMessage.Size = new System.Drawing.Size(131, 47);
            this.addMessage.TabIndex = 4;
            this.addMessage.Text = "Add";
            this.addMessage.UseVisualStyleBackColor = true;
            this.addMessage.Click += new System.EventHandler(this.addMessage_Click);
            // 
            // messageDisplay
            // 
            this.messageDisplay.FormattingEnabled = true;
            this.messageDisplay.ItemHeight = 40;
            this.messageDisplay.Location = new System.Drawing.Point(31, 148);
            this.messageDisplay.Name = "messageDisplay";
            this.messageDisplay.Size = new System.Drawing.Size(824, 364);
            this.messageDisplay.TabIndex = 5;
            this.messageDisplay.SelectedIndexChanged += new System.EventHandler(this.messageDisplay_SelectedIndexChanged);
            // 
            // messagesDisplayBox
            // 
            this.messagesDisplayBox.AutoSize = true;
            this.messagesDisplayBox.Location = new System.Drawing.Point(25, 109);
            this.messagesDisplayBox.Name = "messagesDisplayBox";
            this.messagesDisplayBox.Size = new System.Drawing.Size(181, 40);
            this.messagesDisplayBox.TabIndex = 6;
            this.messagesDisplayBox.Text = "Messages";
            this.messagesDisplayBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // MessageWall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.messagesDisplayBox);
            this.Controls.Add(this.messageDisplay);
            this.Controls.Add(this.addMessage);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MessageWall";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MessageWall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button addMessage;
        private System.Windows.Forms.ListBox messageDisplay;
        private System.Windows.Forms.Label messagesDisplayBox;
    }
}

