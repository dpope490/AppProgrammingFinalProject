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
            this.resetAddGame = new System.Windows.Forms.Button();
            this.addPlayerConsole = new System.Windows.Forms.RichTextBox();
            this.addGameConsole = new System.Windows.Forms.RichTextBox();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.addTeamTitleLabel = new System.Windows.Forms.Label();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.teamCityLabel = new System.Windows.Forms.Label();
            this.winsLabel = new System.Windows.Forms.Label();
            this.lossesLabel = new System.Windows.Forms.Label();
            this.lossesTextBox = new System.Windows.Forms.TextBox();
            this.winsTextBox = new System.Windows.Forms.TextBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.addTeamReset = new System.Windows.Forms.Button();
            this.addTeamConsole = new System.Windows.Forms.RichTextBox();
            this.StatsTab.SuspendLayout();
            this.addPlayerTab.SuspendLayout();
            this.positionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown)).BeginInit();
            this.addGameTab.SuspendLayout();
            this.addTeamTab.SuspendLayout();
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
            this.StatsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatsTab.Multiline = true;
            this.StatsTab.Name = "StatsTab";
            this.StatsTab.SelectedIndex = 0;
            this.StatsTab.Size = new System.Drawing.Size(354, 466);
            this.StatsTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.StatsTab.TabIndex = 11;
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
            this.addPlayerTab.Location = new System.Drawing.Point(4, 22);
            this.addPlayerTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPlayerTab.Name = "addPlayerTab";
            this.addPlayerTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPlayerTab.Size = new System.Drawing.Size(346, 440);
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
            this.positionBox.Location = new System.Drawing.Point(8, 92);
            this.positionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.positionBox.Name = "positionBox";
            this.positionBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.positionBox.Size = new System.Drawing.Size(117, 136);
            this.positionBox.TabIndex = 18;
            this.positionBox.TabStop = false;
            this.positionBox.Text = "Position";
            // 
            // pointGuardButton
            // 
            this.pointGuardButton.AutoSize = true;
            this.pointGuardButton.Location = new System.Drawing.Point(4, 22);
            this.pointGuardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pointGuardButton.Name = "pointGuardButton";
            this.pointGuardButton.Size = new System.Drawing.Size(81, 17);
            this.pointGuardButton.TabIndex = 12;
            this.pointGuardButton.TabStop = true;
            this.pointGuardButton.Text = "Point Guard";
            this.pointGuardButton.UseVisualStyleBackColor = true;
            // 
            // shootingGuardButton
            // 
            this.shootingGuardButton.AutoSize = true;
            this.shootingGuardButton.Location = new System.Drawing.Point(4, 44);
            this.shootingGuardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shootingGuardButton.Name = "shootingGuardButton";
            this.shootingGuardButton.Size = new System.Drawing.Size(99, 17);
            this.shootingGuardButton.TabIndex = 13;
            this.shootingGuardButton.TabStop = true;
            this.shootingGuardButton.Text = "Shooting Guard";
            this.shootingGuardButton.UseVisualStyleBackColor = true;
            // 
            // centerButton
            // 
            this.centerButton.AutoSize = true;
            this.centerButton.Location = new System.Drawing.Point(4, 115);
            this.centerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(56, 17);
            this.centerButton.TabIndex = 16;
            this.centerButton.TabStop = true;
            this.centerButton.Text = "Center";
            this.centerButton.UseVisualStyleBackColor = true;
            // 
            // smallForwardButton
            // 
            this.smallForwardButton.AutoSize = true;
            this.smallForwardButton.Location = new System.Drawing.Point(4, 67);
            this.smallForwardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.smallForwardButton.Name = "smallForwardButton";
            this.smallForwardButton.Size = new System.Drawing.Size(91, 17);
            this.smallForwardButton.TabIndex = 14;
            this.smallForwardButton.TabStop = true;
            this.smallForwardButton.Text = "Small Forward";
            this.smallForwardButton.UseVisualStyleBackColor = true;
            // 
            // powerForwardButton
            // 
            this.powerForwardButton.AutoSize = true;
            this.powerForwardButton.Location = new System.Drawing.Point(4, 89);
            this.powerForwardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.powerForwardButton.Name = "powerForwardButton";
            this.powerForwardButton.Size = new System.Drawing.Size(96, 17);
            this.powerForwardButton.TabIndex = 15;
            this.powerForwardButton.TabStop = true;
            this.powerForwardButton.Text = "Power Forward";
            this.powerForwardButton.UseVisualStyleBackColor = true;
            // 
            // addPlayerReset
            // 
            this.addPlayerReset.Location = new System.Drawing.Point(88, 245);
            this.addPlayerReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPlayerReset.Name = "addPlayerReset";
            this.addPlayerReset.Size = new System.Drawing.Size(75, 23);
            this.addPlayerReset.TabIndex = 17;
            this.addPlayerReset.Text = "Reset";
            this.addPlayerReset.UseVisualStyleBackColor = true;
            this.addPlayerReset.Click += new System.EventHandler(this.addPlayerReset_Click);
            // 
            // refreshTeamsButton
            // 
            this.refreshTeamsButton.Location = new System.Drawing.Point(150, 174);
            this.refreshTeamsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refreshTeamsButton.Name = "refreshTeamsButton";
            this.refreshTeamsButton.Size = new System.Drawing.Size(75, 19);
            this.refreshTeamsButton.TabIndex = 9;
            this.refreshTeamsButton.Text = "Load Teams";
            this.refreshTeamsButton.UseVisualStyleBackColor = true;
            this.refreshTeamsButton.Click += new System.EventHandler(this.refreshTeamsButton_Click);
            // 
            // addPlayerTeamLabel
            // 
            this.addPlayerTeamLabel.AutoSize = true;
            this.addPlayerTeamLabel.Location = new System.Drawing.Point(148, 92);
            this.addPlayerTeamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addPlayerTeamLabel.Name = "addPlayerTeamLabel";
            this.addPlayerTeamLabel.Size = new System.Drawing.Size(34, 13);
            this.addPlayerTeamLabel.TabIndex = 8;
            this.addPlayerTeamLabel.Text = "Team";
            // 
            // teamListBox
            // 
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.Location = new System.Drawing.Point(150, 108);
            this.teamListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(110, 56);
            this.teamListBox.TabIndex = 7;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(148, 42);
            this.numberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(44, 13);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.Text = "Number";
            // 
            // numberUpDown
            // 
            this.numberUpDown.Location = new System.Drawing.Point(150, 58);
            this.numberUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numberUpDown.Name = "numberUpDown";
            this.numberUpDown.Size = new System.Drawing.Size(41, 20);
            this.numberUpDown.TabIndex = 4;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(8, 245);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.addPlayerButton.TabIndex = 1;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // addPlayerNameLabel
            // 
            this.addPlayerNameLabel.AutoSize = true;
            this.addPlayerNameLabel.Location = new System.Drawing.Point(6, 41);
            this.addPlayerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addPlayerNameLabel.Name = "addPlayerNameLabel";
            this.addPlayerNameLabel.Size = new System.Drawing.Size(35, 13);
            this.addPlayerNameLabel.TabIndex = 3;
            this.addPlayerNameLabel.Text = "Name";
            // 
            // addPlayerTitle
            // 
            this.addPlayerTitle.AutoSize = true;
            this.addPlayerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerTitle.Location = new System.Drawing.Point(4, 9);
            this.addPlayerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addPlayerTitle.Name = "addPlayerTitle";
            this.addPlayerTitle.Size = new System.Drawing.Size(233, 20);
            this.addPlayerTitle.TabIndex = 2;
            this.addPlayerTitle.Text = "Insert info below to add a player";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(8, 58);
            this.playerNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(102, 20);
            this.playerNameTextBox.TabIndex = 1;
            // 
            // addGameTab
            // 
            this.addGameTab.Controls.Add(this.addGameConsole);
            this.addGameTab.Controls.Add(this.resetAddGame);
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
            this.addGameTab.Location = new System.Drawing.Point(4, 22);
            this.addGameTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addGameTab.Name = "addGameTab";
            this.addGameTab.Size = new System.Drawing.Size(346, 440);
            this.addGameTab.TabIndex = 3;
            this.addGameTab.Text = "Add Game";
            this.addGameTab.UseVisualStyleBackColor = true;
            // 
            // submitScoreButton
            // 
            this.submitScoreButton.Location = new System.Drawing.Point(8, 202);
            this.submitScoreButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitScoreButton.Name = "submitScoreButton";
            this.submitScoreButton.Size = new System.Drawing.Size(88, 21);
            this.submitScoreButton.TabIndex = 10;
            this.submitScoreButton.Text = "Add Game";
            this.submitScoreButton.UseVisualStyleBackColor = true;
            this.submitScoreButton.Click += new System.EventHandler(this.submitScoreButton_Click);
            // 
            // teamTwoPointsLabel
            // 
            this.teamTwoPointsLabel.AutoSize = true;
            this.teamTwoPointsLabel.Location = new System.Drawing.Point(100, 146);
            this.teamTwoPointsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamTwoPointsLabel.Name = "teamTwoPointsLabel";
            this.teamTwoPointsLabel.Size = new System.Drawing.Size(75, 13);
            this.teamTwoPointsLabel.TabIndex = 9;
            this.teamTwoPointsLabel.Text = "Team 2 Points";
            // 
            // teamOnePointsLabel
            // 
            this.teamOnePointsLabel.AutoSize = true;
            this.teamOnePointsLabel.Location = new System.Drawing.Point(6, 146);
            this.teamOnePointsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamOnePointsLabel.Name = "teamOnePointsLabel";
            this.teamOnePointsLabel.Size = new System.Drawing.Size(75, 13);
            this.teamOnePointsLabel.TabIndex = 8;
            this.teamOnePointsLabel.Text = "Team 1 Points";
            // 
            // teamTwoPointsTextBox
            // 
            this.teamTwoPointsTextBox.Location = new System.Drawing.Point(103, 162);
            this.teamTwoPointsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teamTwoPointsTextBox.Name = "teamTwoPointsTextBox";
            this.teamTwoPointsTextBox.Size = new System.Drawing.Size(76, 20);
            this.teamTwoPointsTextBox.TabIndex = 7;
            // 
            // teamOnePointsTextBox
            // 
            this.teamOnePointsTextBox.Location = new System.Drawing.Point(8, 162);
            this.teamOnePointsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teamOnePointsTextBox.Name = "teamOnePointsTextBox";
            this.teamOnePointsTextBox.Size = new System.Drawing.Size(76, 20);
            this.teamOnePointsTextBox.TabIndex = 6;
            // 
            // teamTwoLabel
            // 
            this.teamTwoLabel.AutoSize = true;
            this.teamTwoLabel.Location = new System.Drawing.Point(100, 41);
            this.teamTwoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamTwoLabel.Name = "teamTwoLabel";
            this.teamTwoLabel.Size = new System.Drawing.Size(43, 13);
            this.teamTwoLabel.TabIndex = 5;
            this.teamTwoLabel.Text = "Team 2";
            // 
            // teamOneLabel
            // 
            this.teamOneLabel.AutoSize = true;
            this.teamOneLabel.Location = new System.Drawing.Point(6, 41);
            this.teamOneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamOneLabel.Name = "teamOneLabel";
            this.teamOneLabel.Size = new System.Drawing.Size(43, 13);
            this.teamOneLabel.TabIndex = 4;
            this.teamOneLabel.Text = "Team 1";
            // 
            // addGameLoadTeams
            // 
            this.addGameLoadTeams.Location = new System.Drawing.Point(198, 108);
            this.addGameLoadTeams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addGameLoadTeams.Name = "addGameLoadTeams";
            this.addGameLoadTeams.Size = new System.Drawing.Size(88, 19);
            this.addGameLoadTeams.TabIndex = 3;
            this.addGameLoadTeams.Text = "Load Teams";
            this.addGameLoadTeams.UseVisualStyleBackColor = true;
            this.addGameLoadTeams.Click += new System.EventHandler(this.addGameLoadTeams_Click);
            // 
            // teamTwoListBox
            // 
            this.teamTwoListBox.FormattingEnabled = true;
            this.teamTwoListBox.Location = new System.Drawing.Point(103, 58);
            this.teamTwoListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teamTwoListBox.Name = "teamTwoListBox";
            this.teamTwoListBox.Size = new System.Drawing.Size(91, 69);
            this.teamTwoListBox.TabIndex = 2;
            // 
            // teamOneListBox
            // 
            this.teamOneListBox.FormattingEnabled = true;
            this.teamOneListBox.Location = new System.Drawing.Point(8, 58);
            this.teamOneListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teamOneListBox.Name = "teamOneListBox";
            this.teamOneListBox.Size = new System.Drawing.Size(91, 69);
            this.teamOneListBox.TabIndex = 1;
            // 
            // addGameTitle
            // 
            this.addGameTitle.AutoSize = true;
            this.addGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGameTitle.Location = new System.Drawing.Point(4, 9);
            this.addGameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addGameTitle.Name = "addGameTitle";
            this.addGameTitle.Size = new System.Drawing.Size(217, 20);
            this.addGameTitle.TabIndex = 0;
            this.addGameTitle.Text = "Select teams and enter score";
            // 
            // addTeamTab
            // 
            this.addTeamTab.Controls.Add(this.addTeamConsole);
            this.addTeamTab.Controls.Add(this.addTeamReset);
            this.addTeamTab.Controls.Add(this.addTeamButton);
            this.addTeamTab.Controls.Add(this.winsTextBox);
            this.addTeamTab.Controls.Add(this.lossesTextBox);
            this.addTeamTab.Controls.Add(this.lossesLabel);
            this.addTeamTab.Controls.Add(this.winsLabel);
            this.addTeamTab.Controls.Add(this.teamCityLabel);
            this.addTeamTab.Controls.Add(this.cityTextBox);
            this.addTeamTab.Controls.Add(this.teamNameLabel);
            this.addTeamTab.Controls.Add(this.teamNameTextBox);
            this.addTeamTab.Controls.Add(this.addTeamTitleLabel);
            this.addTeamTab.Controls.Add(this.label1);
            this.addTeamTab.Location = new System.Drawing.Point(4, 22);
            this.addTeamTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addTeamTab.Name = "addTeamTab";
            this.addTeamTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addTeamTab.Size = new System.Drawing.Size(346, 440);
            this.addTeamTab.TabIndex = 0;
            this.addTeamTab.Text = "Add Team";
            this.addTeamTab.UseVisualStyleBackColor = true;
            // 
            // searchStatsTab
            // 
            this.searchStatsTab.Location = new System.Drawing.Point(4, 22);
            this.searchStatsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchStatsTab.Name = "searchStatsTab";
            this.searchStatsTab.Size = new System.Drawing.Size(346, 440);
            this.searchStatsTab.TabIndex = 2;
            this.searchStatsTab.Text = "Search Stats";
            this.searchStatsTab.UseVisualStyleBackColor = true;
            // 
            // resetAddGame
            // 
            this.resetAddGame.Location = new System.Drawing.Point(103, 202);
            this.resetAddGame.Name = "resetAddGame";
            this.resetAddGame.Size = new System.Drawing.Size(87, 21);
            this.resetAddGame.TabIndex = 12;
            this.resetAddGame.Text = "Reset";
            this.resetAddGame.UseVisualStyleBackColor = true;
            this.resetAddGame.Click += new System.EventHandler(this.resetAddGame_Click);
            // 
            // addPlayerConsole
            // 
            this.addPlayerConsole.Location = new System.Drawing.Point(9, 274);
            this.addPlayerConsole.Margin = new System.Windows.Forms.Padding(2);
            this.addPlayerConsole.Name = "addPlayerConsole";
            this.addPlayerConsole.ShowSelectionMargin = true;
            this.addPlayerConsole.Size = new System.Drawing.Size(323, 149);
            this.addPlayerConsole.TabIndex = 1;
            this.addPlayerConsole.Text = "";
            // 
            // addGameConsole
            // 
            this.addGameConsole.Location = new System.Drawing.Point(8, 229);
            this.addGameConsole.Name = "addGameConsole";
            this.addGameConsole.Size = new System.Drawing.Size(323, 193);
            this.addGameConsole.TabIndex = 13;
            this.addGameConsole.Text = "";
            this.addGameConsole.WordWrap = false;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(FinalProject.Player);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // addTeamTitleLabel
            // 
            this.addTeamTitleLabel.AutoSize = true;
            this.addTeamTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamTitleLabel.Location = new System.Drawing.Point(4, 13);
            this.addTeamTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addTeamTitleLabel.Name = "addTeamTitleLabel";
            this.addTeamTitleLabel.Size = new System.Drawing.Size(227, 20);
            this.addTeamTitleLabel.TabIndex = 2;
            this.addTeamTitleLabel.Text = "Insert info below to add a team\r\n";
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Location = new System.Drawing.Point(8, 74);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.teamNameTextBox.TabIndex = 3;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(5, 58);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(35, 13);
            this.teamNameLabel.TabIndex = 4;
            this.teamNameLabel.Text = "Name";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(131, 74);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 5;
            // 
            // teamCityLabel
            // 
            this.teamCityLabel.AutoSize = true;
            this.teamCityLabel.Location = new System.Drawing.Point(128, 58);
            this.teamCityLabel.Name = "teamCityLabel";
            this.teamCityLabel.Size = new System.Drawing.Size(24, 13);
            this.teamCityLabel.TabIndex = 6;
            this.teamCityLabel.Text = "City";
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Location = new System.Drawing.Point(5, 110);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(31, 13);
            this.winsLabel.TabIndex = 7;
            this.winsLabel.Text = "Wins";
            // 
            // lossesLabel
            // 
            this.lossesLabel.AutoSize = true;
            this.lossesLabel.Location = new System.Drawing.Point(128, 110);
            this.lossesLabel.Name = "lossesLabel";
            this.lossesLabel.Size = new System.Drawing.Size(40, 13);
            this.lossesLabel.TabIndex = 8;
            this.lossesLabel.Text = "Losses";
            // 
            // lossesTextBox
            // 
            this.lossesTextBox.Location = new System.Drawing.Point(131, 126);
            this.lossesTextBox.Name = "lossesTextBox";
            this.lossesTextBox.Size = new System.Drawing.Size(100, 20);
            this.lossesTextBox.TabIndex = 9;
            // 
            // winsTextBox
            // 
            this.winsTextBox.Location = new System.Drawing.Point(8, 126);
            this.winsTextBox.Name = "winsTextBox";
            this.winsTextBox.Size = new System.Drawing.Size(100, 20);
            this.winsTextBox.TabIndex = 10;
            // 
            // addTeamButton
            // 
            this.addTeamButton.Location = new System.Drawing.Point(8, 179);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(100, 23);
            this.addTeamButton.TabIndex = 11;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // addTeamReset
            // 
            this.addTeamReset.Location = new System.Drawing.Point(131, 179);
            this.addTeamReset.Name = "addTeamReset";
            this.addTeamReset.Size = new System.Drawing.Size(100, 23);
            this.addTeamReset.TabIndex = 12;
            this.addTeamReset.Text = "Reset";
            this.addTeamReset.UseVisualStyleBackColor = true;
            this.addTeamReset.Click += new System.EventHandler(this.addTeamReset_Click);
            // 
            // addTeamConsole
            // 
            this.addTeamConsole.Location = new System.Drawing.Point(8, 208);
            this.addTeamConsole.Name = "addTeamConsole";
            this.addTeamConsole.Size = new System.Drawing.Size(323, 96);
            this.addTeamConsole.TabIndex = 13;
            this.addTeamConsole.Text = "";
            // 
            // BasketballStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 456);
            this.Controls.Add(this.StatsTab);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.addTeamTab.ResumeLayout(false);
            this.addTeamTab.PerformLayout();
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
        private System.Windows.Forms.Button resetAddGame;
        private System.Windows.Forms.RichTextBox addPlayerConsole;
        private System.Windows.Forms.RichTextBox addGameConsole;
        private System.Windows.Forms.Button addTeamReset;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.TextBox winsTextBox;
        private System.Windows.Forms.TextBox lossesTextBox;
        private System.Windows.Forms.Label lossesLabel;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Label teamCityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.Label addTeamTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox addTeamConsole;
    }
}