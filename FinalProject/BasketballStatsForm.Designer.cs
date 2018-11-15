namespace FinalProject
{
    partial class BasketballStatsForm
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
            this.StatsTab = new System.Windows.Forms.TabControl();
            this.addPlayerTab = new System.Windows.Forms.TabPage();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addPlayerTitle = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addGameTab = new System.Windows.Forms.TabPage();
            this.addTeamTab = new System.Windows.Forms.TabPage();
            this.searchStatsTab = new System.Windows.Forms.TabPage();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.StatsTab.SuspendLayout();
            this.addPlayerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatsTab
            // 
            this.StatsTab.Controls.Add(this.addPlayerTab);
            this.StatsTab.Controls.Add(this.addGameTab);
            this.StatsTab.Controls.Add(this.addTeamTab);
            this.StatsTab.Controls.Add(this.searchStatsTab);
            this.StatsTab.Location = new System.Drawing.Point(0, 0);
            this.StatsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatsTab.Name = "StatsTab";
            this.StatsTab.SelectedIndex = 0;
            this.StatsTab.Size = new System.Drawing.Size(354, 310);
            this.StatsTab.TabIndex = 0;
            // 
            // addPlayerTab
            // 
            this.addPlayerTab.Controls.Add(this.addPlayerButton);
            this.addPlayerTab.Controls.Add(this.lastNameLabel);
            this.addPlayerTab.Controls.Add(this.lastNameTextBox);
            this.addPlayerTab.Controls.Add(this.addPlayerTitle);
            this.addPlayerTab.Controls.Add(this.firstNameTextBox);
            this.addPlayerTab.Controls.Add(this.firstNameLabel);
            this.addPlayerTab.Location = new System.Drawing.Point(4, 22);
            this.addPlayerTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPlayerTab.Name = "addPlayerTab";
            this.addPlayerTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPlayerTab.Size = new System.Drawing.Size(346, 284);
            this.addPlayerTab.TabIndex = 1;
            this.addPlayerTab.Text = "Add Player";
            this.addPlayerTab.UseVisualStyleBackColor = true;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(112, 41);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(114, 58);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(76, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // addPlayerTitle
            // 
            this.addPlayerTitle.AutoSize = true;
            this.addPlayerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerTitle.Location = new System.Drawing.Point(4, 10);
            this.addPlayerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addPlayerTitle.Name = "addPlayerTitle";
            this.addPlayerTitle.Size = new System.Drawing.Size(233, 20);
            this.addPlayerTitle.TabIndex = 2;
            this.addPlayerTitle.Text = "Insert info below to add a player";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(8, 58);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(76, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 41);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // addGameTab
            // 
            this.addGameTab.Location = new System.Drawing.Point(4, 22);
            this.addGameTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addGameTab.Name = "addGameTab";
            this.addGameTab.Size = new System.Drawing.Size(346, 284);
            this.addGameTab.TabIndex = 3;
            this.addGameTab.Text = "Add Game";
            this.addGameTab.UseVisualStyleBackColor = true;
            // 
            // addTeamTab
            // 
            this.addTeamTab.Location = new System.Drawing.Point(4, 22);
            this.addTeamTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addTeamTab.Name = "addTeamTab";
            this.addTeamTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addTeamTab.Size = new System.Drawing.Size(346, 284);
            this.addTeamTab.TabIndex = 0;
            this.addTeamTab.Text = "Add Team";
            this.addTeamTab.UseVisualStyleBackColor = true;
            // 
            // searchStatsTab
            // 
            this.searchStatsTab.Location = new System.Drawing.Point(4, 22);
            this.searchStatsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchStatsTab.Name = "searchStatsTab";
            this.searchStatsTab.Size = new System.Drawing.Size(346, 284);
            this.searchStatsTab.TabIndex = 2;
            this.searchStatsTab.Text = "Search Stats";
            this.searchStatsTab.UseVisualStyleBackColor = true;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(9, 189);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.addPlayerButton.TabIndex = 1;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // BasketballStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 309);
            this.Controls.Add(this.StatsTab);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BasketballStatsForm";
            this.Text = "BasketballStatsForm";
            this.StatsTab.ResumeLayout(false);
            this.addPlayerTab.ResumeLayout(false);
            this.addPlayerTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl StatsTab;
        private System.Windows.Forms.TabPage addTeamTab;
        private System.Windows.Forms.TabPage addPlayerTab;
        private System.Windows.Forms.TabPage searchStatsTab;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TabPage addGameTab;
        private System.Windows.Forms.Label addPlayerTitle;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button addPlayerButton;
    }
}