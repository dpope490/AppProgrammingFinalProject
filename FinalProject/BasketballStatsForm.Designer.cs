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
			this.components = new System.ComponentModel.Container();
			this.StatsTab = new System.Windows.Forms.TabControl();
			this.addPlayerTab = new System.Windows.Forms.TabPage();
			this.positionBox = new System.Windows.Forms.GroupBox();
			this.pointGuardButton = new System.Windows.Forms.RadioButton();
			this.shootingGuardButton = new System.Windows.Forms.RadioButton();
			this.centerButton = new System.Windows.Forms.RadioButton();
			this.smallForwardButton = new System.Windows.Forms.RadioButton();
			this.powerForwardButton = new System.Windows.Forms.RadioButton();
			this.addPlayerReset = new System.Windows.Forms.Button();
			this.refreshTeamsButton = new System.Windows.Forms.Button();
			this.addPlayerTeamLabel = new System.Windows.Forms.Label();
			this.teamListBox = new System.Windows.Forms.ListBox();
			this.addPlayerConsole = new System.Windows.Forms.RichTextBox();
			this.numberLabel = new System.Windows.Forms.Label();
			this.numberUpDown = new System.Windows.Forms.NumericUpDown();
			this.addPlayerButton = new System.Windows.Forms.Button();
			this.addPlayerNameLabel = new System.Windows.Forms.Label();
			this.addPlayerTitle = new System.Windows.Forms.Label();
			this.playerNameTextBox = new System.Windows.Forms.TextBox();
			this.addGameTab = new System.Windows.Forms.TabPage();
			this.submitScoreButton = new System.Windows.Forms.Button();
			this.teamTwoPointsLabel = new System.Windows.Forms.Label();
			this.teamOnePointsLabel = new System.Windows.Forms.Label();
			this.teamTwoPointsTextBox = new System.Windows.Forms.TextBox();
			this.teamOnePointsTextBox = new System.Windows.Forms.TextBox();
			this.teamTwoLabel = new System.Windows.Forms.Label();
			this.teamOneLabel = new System.Windows.Forms.Label();
			this.addGameLoadTeams = new System.Windows.Forms.Button();
			this.teamTwoListBox = new System.Windows.Forms.ListBox();
			this.teamOneListBox = new System.Windows.Forms.ListBox();
			this.addGameTitle = new System.Windows.Forms.Label();
			this.addTeamTab = new System.Windows.Forms.TabPage();
			this.searchStatsTab = new System.Windows.Forms.TabPage();
			this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.StatsTab.SuspendLayout();
			this.addPlayerTab.SuspendLayout();
			this.positionBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberUpDown)).BeginInit();
			this.addGameTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// StatsTab
			// 
			this.StatsTab.Controls.Add(this.addPlayerTab);
			this.StatsTab.Controls.Add(this.addGameTab);
			this.StatsTab.Controls.Add(this.addTeamTab);
			this.StatsTab.Controls.Add(this.searchStatsTab);
			this.StatsTab.Location = new System.Drawing.Point(0, 0);
			this.StatsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.StatsTab.Name = "StatsTab";
			this.StatsTab.SelectedIndex = 0;
			this.StatsTab.Size = new System.Drawing.Size(472, 574);
			this.StatsTab.TabIndex = 0;
			// 
			// addPlayerTab
			// 
			this.addPlayerTab.Controls.Add(this.positionBox);
			this.addPlayerTab.Controls.Add(this.addPlayerReset);
			this.addPlayerTab.Controls.Add(this.refreshTeamsButton);
			this.addPlayerTab.Controls.Add(this.addPlayerTeamLabel);
			this.addPlayerTab.Controls.Add(this.teamListBox);
			this.addPlayerTab.Controls.Add(this.addPlayerConsole);
			this.addPlayerTab.Controls.Add(this.numberLabel);
			this.addPlayerTab.Controls.Add(this.numberUpDown);
			this.addPlayerTab.Controls.Add(this.addPlayerButton);
			this.addPlayerTab.Controls.Add(this.addPlayerNameLabel);
			this.addPlayerTab.Controls.Add(this.addPlayerTitle);
			this.addPlayerTab.Controls.Add(this.playerNameTextBox);
			this.addPlayerTab.Location = new System.Drawing.Point(4, 25);
			this.addPlayerTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.addPlayerTab.Name = "addPlayerTab";
			this.addPlayerTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.addPlayerTab.Size = new System.Drawing.Size(464, 545);
			this.addPlayerTab.TabIndex = 1;
			this.addPlayerTab.Text = "Add Player";
			this.addPlayerTab.UseVisualStyleBackColor = true;
			// 
			// positionBox
			// 
			this.positionBox.Controls.Add(this.pointGuardButton);
			this.positionBox.Controls.Add(this.shootingGuardButton);
			this.positionBox.Controls.Add(this.centerButton);
			this.positionBox.Controls.Add(this.smallForwardButton);
			this.positionBox.Controls.Add(this.powerForwardButton);
			this.positionBox.Location = new System.Drawing.Point(11, 113);
			this.positionBox.Name = "positionBox";
			this.positionBox.Size = new System.Drawing.Size(156, 167);
			this.positionBox.TabIndex = 18;
			this.positionBox.TabStop = false;
			this.positionBox.Text = "Position";
			// 
			// pointGuardButton
			// 
			this.pointGuardButton.AutoSize = true;
			this.pointGuardButton.Location = new System.Drawing.Point(6, 27);
			this.pointGuardButton.Name = "pointGuardButton";
			this.pointGuardButton.Size = new System.Drawing.Size(105, 21);
			this.pointGuardButton.TabIndex = 12;
			this.pointGuardButton.TabStop = true;
			this.pointGuardButton.Text = "Point Guard";
			this.pointGuardButton.UseVisualStyleBackColor = true;
			// 
			// shootingGuardButton
			// 
			this.shootingGuardButton.AutoSize = true;
			this.shootingGuardButton.Location = new System.Drawing.Point(6, 54);
			this.shootingGuardButton.Name = "shootingGuardButton";
			this.shootingGuardButton.Size = new System.Drawing.Size(129, 21);
			this.shootingGuardButton.TabIndex = 13;
			this.shootingGuardButton.TabStop = true;
			this.shootingGuardButton.Text = "Shooting Guard";
			this.shootingGuardButton.UseVisualStyleBackColor = true;
			// 
			// centerButton
			// 
			this.centerButton.AutoSize = true;
			this.centerButton.Location = new System.Drawing.Point(6, 142);
			this.centerButton.Name = "centerButton";
			this.centerButton.Size = new System.Drawing.Size(71, 21);
			this.centerButton.TabIndex = 16;
			this.centerButton.TabStop = true;
			this.centerButton.Text = "Center";
			this.centerButton.UseVisualStyleBackColor = true;
			// 
			// smallForwardButton
			// 
			this.smallForwardButton.AutoSize = true;
			this.smallForwardButton.Location = new System.Drawing.Point(6, 83);
			this.smallForwardButton.Name = "smallForwardButton";
			this.smallForwardButton.Size = new System.Drawing.Size(118, 21);
			this.smallForwardButton.TabIndex = 14;
			this.smallForwardButton.TabStop = true;
			this.smallForwardButton.Text = "Small Forward";
			this.smallForwardButton.UseVisualStyleBackColor = true;
			// 
			// powerForwardButton
			// 
			this.powerForwardButton.AutoSize = true;
			this.powerForwardButton.Location = new System.Drawing.Point(6, 110);
			this.powerForwardButton.Name = "powerForwardButton";
			this.powerForwardButton.Size = new System.Drawing.Size(123, 21);
			this.powerForwardButton.TabIndex = 15;
			this.powerForwardButton.TabStop = true;
			this.powerForwardButton.Text = "Power Forward";
			this.powerForwardButton.UseVisualStyleBackColor = true;
			// 
			// addPlayerReset
			// 
			this.addPlayerReset.Location = new System.Drawing.Point(118, 302);
			this.addPlayerReset.Name = "addPlayerReset";
			this.addPlayerReset.Size = new System.Drawing.Size(100, 28);
			this.addPlayerReset.TabIndex = 17;
			this.addPlayerReset.Text = "Reset";
			this.addPlayerReset.UseVisualStyleBackColor = true;
			this.addPlayerReset.Click += new System.EventHandler(this.addPlayerReset_Click);
			// 
			// refreshTeamsButton
			// 
			this.refreshTeamsButton.Location = new System.Drawing.Point(200, 214);
			this.refreshTeamsButton.Name = "refreshTeamsButton";
			this.refreshTeamsButton.Size = new System.Drawing.Size(100, 23);
			this.refreshTeamsButton.TabIndex = 9;
			this.refreshTeamsButton.Text = "Load Teams";
			this.refreshTeamsButton.UseVisualStyleBackColor = true;
			this.refreshTeamsButton.Click += new System.EventHandler(this.refreshTeamsButton_Click);
			// 
			// addPlayerTeamLabel
			// 
			this.addPlayerTeamLabel.AutoSize = true;
			this.addPlayerTeamLabel.Location = new System.Drawing.Point(197, 113);
			this.addPlayerTeamLabel.Name = "addPlayerTeamLabel";
			this.addPlayerTeamLabel.Size = new System.Drawing.Size(44, 17);
			this.addPlayerTeamLabel.TabIndex = 8;
			this.addPlayerTeamLabel.Text = "Team";
			// 
			// teamListBox
			// 
			this.teamListBox.FormattingEnabled = true;
			this.teamListBox.ItemHeight = 16;
			this.teamListBox.Location = new System.Drawing.Point(200, 133);
			this.teamListBox.Name = "teamListBox";
			this.teamListBox.Size = new System.Drawing.Size(145, 68);
			this.teamListBox.TabIndex = 7;
			// 
			// addPlayerConsole
			// 
			this.addPlayerConsole.Location = new System.Drawing.Point(11, 337);
			this.addPlayerConsole.Name = "addPlayerConsole";
			this.addPlayerConsole.Size = new System.Drawing.Size(436, 187);
			this.addPlayerConsole.TabIndex = 6;
			this.addPlayerConsole.Text = "";
			// 
			// numberLabel
			// 
			this.numberLabel.AutoSize = true;
			this.numberLabel.Location = new System.Drawing.Point(197, 52);
			this.numberLabel.Name = "numberLabel";
			this.numberLabel.Size = new System.Drawing.Size(58, 17);
			this.numberLabel.TabIndex = 5;
			this.numberLabel.Text = "Number";
			// 
			// numberUpDown
			// 
			this.numberUpDown.Location = new System.Drawing.Point(200, 72);
			this.numberUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.numberUpDown.Name = "numberUpDown";
			this.numberUpDown.Size = new System.Drawing.Size(55, 22);
			this.numberUpDown.TabIndex = 4;
			// 
			// addPlayerButton
			// 
			this.addPlayerButton.Location = new System.Drawing.Point(11, 302);
			this.addPlayerButton.Margin = new System.Windows.Forms.Padding(4);
			this.addPlayerButton.Name = "addPlayerButton";
			this.addPlayerButton.Size = new System.Drawing.Size(100, 28);
			this.addPlayerButton.TabIndex = 1;
			this.addPlayerButton.Text = "Add Player";
			this.addPlayerButton.UseVisualStyleBackColor = true;
			this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
			// 
			// addPlayerNameLabel
			// 
			this.addPlayerNameLabel.AutoSize = true;
			this.addPlayerNameLabel.Location = new System.Drawing.Point(8, 50);
			this.addPlayerNameLabel.Name = "addPlayerNameLabel";
			this.addPlayerNameLabel.Size = new System.Drawing.Size(45, 17);
			this.addPlayerNameLabel.TabIndex = 3;
			this.addPlayerNameLabel.Text = "Name";
			// 
			// addPlayerTitle
			// 
			this.addPlayerTitle.AutoSize = true;
			this.addPlayerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addPlayerTitle.Location = new System.Drawing.Point(6, 11);
			this.addPlayerTitle.Name = "addPlayerTitle";
			this.addPlayerTitle.Size = new System.Drawing.Size(285, 25);
			this.addPlayerTitle.TabIndex = 2;
			this.addPlayerTitle.Text = "Insert info below to add a player";
			// 
			// playerNameTextBox
			// 
			this.playerNameTextBox.Location = new System.Drawing.Point(11, 71);
			this.playerNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.playerNameTextBox.Name = "playerNameTextBox";
			this.playerNameTextBox.Size = new System.Drawing.Size(135, 22);
			this.playerNameTextBox.TabIndex = 1;
			// 
			// addGameTab
			// 
			this.addGameTab.Controls.Add(this.submitScoreButton);
			this.addGameTab.Controls.Add(this.teamTwoPointsLabel);
			this.addGameTab.Controls.Add(this.teamOnePointsLabel);
			this.addGameTab.Controls.Add(this.teamTwoPointsTextBox);
			this.addGameTab.Controls.Add(this.teamOnePointsTextBox);
			this.addGameTab.Controls.Add(this.teamTwoLabel);
			this.addGameTab.Controls.Add(this.teamOneLabel);
			this.addGameTab.Controls.Add(this.addGameLoadTeams);
			this.addGameTab.Controls.Add(this.teamTwoListBox);
			this.addGameTab.Controls.Add(this.teamOneListBox);
			this.addGameTab.Controls.Add(this.addGameTitle);
			this.addGameTab.Location = new System.Drawing.Point(4, 25);
			this.addGameTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.addGameTab.Name = "addGameTab";
			this.addGameTab.Size = new System.Drawing.Size(464, 545);
			this.addGameTab.TabIndex = 3;
			this.addGameTab.Text = "Add Game";
			this.addGameTab.UseVisualStyleBackColor = true;
			// 
			// submitScoreButton
			// 
			this.submitScoreButton.Location = new System.Drawing.Point(263, 200);
			this.submitScoreButton.Name = "submitScoreButton";
			this.submitScoreButton.Size = new System.Drawing.Size(118, 23);
			this.submitScoreButton.TabIndex = 10;
			this.submitScoreButton.Text = "Submit Score";
			this.submitScoreButton.UseVisualStyleBackColor = true;
			this.submitScoreButton.Click += new System.EventHandler(this.submitScoreButton_Click);
			// 
			// teamTwoPointsLabel
			// 
			this.teamTwoPointsLabel.AutoSize = true;
			this.teamTwoPointsLabel.Location = new System.Drawing.Point(134, 180);
			this.teamTwoPointsLabel.Name = "teamTwoPointsLabel";
			this.teamTwoPointsLabel.Size = new System.Drawing.Size(99, 17);
			this.teamTwoPointsLabel.TabIndex = 9;
			this.teamTwoPointsLabel.Text = "Team 2 Points";
			// 
			// teamOnePointsLabel
			// 
			this.teamOnePointsLabel.AutoSize = true;
			this.teamOnePointsLabel.Location = new System.Drawing.Point(8, 180);
			this.teamOnePointsLabel.Name = "teamOnePointsLabel";
			this.teamOnePointsLabel.Size = new System.Drawing.Size(99, 17);
			this.teamOnePointsLabel.TabIndex = 8;
			this.teamOnePointsLabel.Text = "Team 1 Points";
			// 
			// teamTwoPointsTextBox
			// 
			this.teamTwoPointsTextBox.Location = new System.Drawing.Point(137, 200);
			this.teamTwoPointsTextBox.Name = "teamTwoPointsTextBox";
			this.teamTwoPointsTextBox.Size = new System.Drawing.Size(100, 22);
			this.teamTwoPointsTextBox.TabIndex = 7;
			// 
			// teamOnePointsTextBox
			// 
			this.teamOnePointsTextBox.Location = new System.Drawing.Point(11, 200);
			this.teamOnePointsTextBox.Name = "teamOnePointsTextBox";
			this.teamOnePointsTextBox.Size = new System.Drawing.Size(100, 22);
			this.teamOnePointsTextBox.TabIndex = 6;
			// 
			// teamTwoLabel
			// 
			this.teamTwoLabel.AutoSize = true;
			this.teamTwoLabel.Location = new System.Drawing.Point(134, 51);
			this.teamTwoLabel.Name = "teamTwoLabel";
			this.teamTwoLabel.Size = new System.Drawing.Size(56, 17);
			this.teamTwoLabel.TabIndex = 5;
			this.teamTwoLabel.Text = "Team 2";
			// 
			// teamOneLabel
			// 
			this.teamOneLabel.AutoSize = true;
			this.teamOneLabel.Location = new System.Drawing.Point(8, 51);
			this.teamOneLabel.Name = "teamOneLabel";
			this.teamOneLabel.Size = new System.Drawing.Size(56, 17);
			this.teamOneLabel.TabIndex = 4;
			this.teamOneLabel.Text = "Team 1";
			// 
			// addGameLoadTeams
			// 
			this.addGameLoadTeams.Location = new System.Drawing.Point(263, 132);
			this.addGameLoadTeams.Name = "addGameLoadTeams";
			this.addGameLoadTeams.Size = new System.Drawing.Size(118, 23);
			this.addGameLoadTeams.TabIndex = 3;
			this.addGameLoadTeams.Text = "Load Teams";
			this.addGameLoadTeams.UseVisualStyleBackColor = true;
			this.addGameLoadTeams.Click += new System.EventHandler(this.addGameLoadTeams_Click);
			// 
			// teamTwoListBox
			// 
			this.teamTwoListBox.FormattingEnabled = true;
			this.teamTwoListBox.ItemHeight = 16;
			this.teamTwoListBox.Location = new System.Drawing.Point(137, 71);
			this.teamTwoListBox.Name = "teamTwoListBox";
			this.teamTwoListBox.Size = new System.Drawing.Size(120, 84);
			this.teamTwoListBox.TabIndex = 2;
			// 
			// teamOneListBox
			// 
			this.teamOneListBox.FormattingEnabled = true;
			this.teamOneListBox.ItemHeight = 16;
			this.teamOneListBox.Location = new System.Drawing.Point(11, 71);
			this.teamOneListBox.Name = "teamOneListBox";
			this.teamOneListBox.Size = new System.Drawing.Size(120, 84);
			this.teamOneListBox.TabIndex = 1;
			// 
			// addGameTitle
			// 
			this.addGameTitle.AutoSize = true;
			this.addGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addGameTitle.Location = new System.Drawing.Point(6, 11);
			this.addGameTitle.Name = "addGameTitle";
			this.addGameTitle.Size = new System.Drawing.Size(340, 25);
			this.addGameTitle.TabIndex = 0;
			this.addGameTitle.Text = "Step 1: Select teams and enter score\"";
			// 
			// addTeamTab
			// 
			this.addTeamTab.Location = new System.Drawing.Point(4, 25);
			this.addTeamTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.addTeamTab.Name = "addTeamTab";
			this.addTeamTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.addTeamTab.Size = new System.Drawing.Size(464, 545);
			this.addTeamTab.TabIndex = 0;
			this.addTeamTab.Text = "Add Team";
			this.addTeamTab.UseVisualStyleBackColor = true;
			// 
			// searchStatsTab
			// 
			this.searchStatsTab.Location = new System.Drawing.Point(4, 25);
			this.searchStatsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.searchStatsTab.Name = "searchStatsTab";
			this.searchStatsTab.Size = new System.Drawing.Size(464, 545);
			this.searchStatsTab.TabIndex = 2;
			this.searchStatsTab.Text = "Search Stats";
			this.searchStatsTab.UseVisualStyleBackColor = true;
			// 
			// playerBindingSource
			// 
			this.playerBindingSource.DataSource = typeof(FinalProject.Player);
			// 
			// BasketballStatsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 561);
			this.Controls.Add(this.StatsTab);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "BasketballStatsForm";
			this.Text = "BasketballStatsForm";
			this.StatsTab.ResumeLayout(false);
			this.addPlayerTab.ResumeLayout(false);
			this.addPlayerTab.PerformLayout();
			this.positionBox.ResumeLayout(false);
			this.positionBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberUpDown)).EndInit();
			this.addGameTab.ResumeLayout(false);
			this.addGameTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl StatsTab;
        private System.Windows.Forms.TabPage addTeamTab;
        private System.Windows.Forms.TabPage addPlayerTab;
        private System.Windows.Forms.TabPage searchStatsTab;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.TabPage addGameTab;
        private System.Windows.Forms.Label addPlayerTitle;
        private System.Windows.Forms.Label addPlayerNameLabel;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.NumericUpDown numberUpDown;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.RichTextBox addPlayerConsole;
        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.Button refreshTeamsButton;
        private System.Windows.Forms.Label addPlayerTeamLabel;
        private System.Windows.Forms.RadioButton centerButton;
        private System.Windows.Forms.RadioButton powerForwardButton;
        private System.Windows.Forms.RadioButton smallForwardButton;
        private System.Windows.Forms.RadioButton shootingGuardButton;
        private System.Windows.Forms.RadioButton pointGuardButton;
        private System.Windows.Forms.Button addPlayerReset;
        private System.Windows.Forms.GroupBox positionBox;
		private System.Windows.Forms.Label addGameTitle;
		private System.Windows.Forms.Label teamTwoLabel;
		private System.Windows.Forms.Label teamOneLabel;
		private System.Windows.Forms.Button addGameLoadTeams;
		private System.Windows.Forms.ListBox teamTwoListBox;
		private System.Windows.Forms.ListBox teamOneListBox;
		private System.Windows.Forms.Label teamTwoPointsLabel;
		private System.Windows.Forms.Label teamOnePointsLabel;
		private System.Windows.Forms.TextBox teamTwoPointsTextBox;
		private System.Windows.Forms.TextBox teamOnePointsTextBox;
		private System.Windows.Forms.Button submitScoreButton;
		private System.Windows.Forms.BindingSource playerBindingSource;
	}
}