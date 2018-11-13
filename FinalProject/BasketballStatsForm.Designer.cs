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
            this.addTeamTab = new System.Windows.Forms.TabPage();
            this.addPlayerTab = new System.Windows.Forms.TabPage();
            this.searchStatsTab = new System.Windows.Forms.TabPage();
            this.addGameTab = new System.Windows.Forms.TabPage();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.addPlayerTitle = new System.Windows.Forms.Label();
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
            this.StatsTab.Name = "StatsTab";
            this.StatsTab.SelectedIndex = 0;
            this.StatsTab.Size = new System.Drawing.Size(472, 382);
            this.StatsTab.TabIndex = 0;
            // 
            // addTeamTab
            // 
            this.addTeamTab.Location = new System.Drawing.Point(4, 25);
            this.addTeamTab.Name = "addTeamTab";
            this.addTeamTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTeamTab.Size = new System.Drawing.Size(464, 353);
            this.addTeamTab.TabIndex = 0;
            this.addTeamTab.Text = "Add Team";
            this.addTeamTab.UseVisualStyleBackColor = true;
            // 
            // addPlayerTab
            // 
            this.addPlayerTab.Controls.Add(this.addPlayerTitle);
            this.addPlayerTab.Controls.Add(this.firstNameTextBox);
            this.addPlayerTab.Controls.Add(this.firstNameLabel);
            this.addPlayerTab.Location = new System.Drawing.Point(4, 25);
            this.addPlayerTab.Name = "addPlayerTab";
            this.addPlayerTab.Padding = new System.Windows.Forms.Padding(3);
            this.addPlayerTab.Size = new System.Drawing.Size(464, 353);
            this.addPlayerTab.TabIndex = 1;
            this.addPlayerTab.Text = "Add Player";
            this.addPlayerTab.UseVisualStyleBackColor = true;
            // 
            // searchStatsTab
            // 
            this.searchStatsTab.Location = new System.Drawing.Point(4, 25);
            this.searchStatsTab.Name = "searchStatsTab";
            this.searchStatsTab.Size = new System.Drawing.Size(464, 353);
            this.searchStatsTab.TabIndex = 2;
            this.searchStatsTab.Text = "Search Stats";
            this.searchStatsTab.UseVisualStyleBackColor = true;
            // 
            // addGameTab
            // 
            this.addGameTab.Location = new System.Drawing.Point(4, 25);
            this.addGameTab.Name = "addGameTab";
            this.addGameTab.Size = new System.Drawing.Size(464, 353);
            this.addGameTab.TabIndex = 3;
            this.addGameTab.Text = "Add Game";
            this.addGameTab.UseVisualStyleBackColor = true;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(8, 51);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(11, 71);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // addPlayerTitle
            // 
            this.addPlayerTitle.AutoSize = true;
            this.addPlayerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerTitle.Location = new System.Drawing.Point(6, 12);
            this.addPlayerTitle.Name = "addPlayerTitle";
            this.addPlayerTitle.Size = new System.Drawing.Size(285, 25);
            this.addPlayerTitle.TabIndex = 2;
            this.addPlayerTitle.Text = "Insert info below to add a player";
            // 
            // BasketballStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 380);
            this.Controls.Add(this.StatsTab);
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
    }
}