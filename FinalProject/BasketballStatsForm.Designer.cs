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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addPlayerTitle = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addGameTab = new System.Windows.Forms.TabPage();
            this.addTeamTab = new System.Windows.Forms.TabPage();
            this.searchStatsTab = new System.Windows.Forms.TabPage();
            this.StatsTab.SuspendLayout();
            this.addPlayerTab.SuspendLayout();
            this.positionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown)).BeginInit();
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
            this.StatsTab.Size = new System.Drawing.Size(472, 492);
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
            this.addPlayerTab.Controls.Add(this.lastNameLabel);
            this.addPlayerTab.Controls.Add(this.lastNameTextBox);
            this.addPlayerTab.Controls.Add(this.addPlayerTitle);
            this.addPlayerTab.Controls.Add(this.firstNameTextBox);
            this.addPlayerTab.Controls.Add(this.firstNameLabel);
            this.addPlayerTab.Location = new System.Drawing.Point(4, 25);
            this.addPlayerTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPlayerTab.Name = "addPlayerTab";
            this.addPlayerTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPlayerTab.Size = new System.Drawing.Size(464, 463);
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
            this.addPlayerConsole.Size = new System.Drawing.Size(436, 92);
            this.addPlayerConsole.TabIndex = 6;
            this.addPlayerConsole.Text = "";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(287, 50);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(58, 17);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.Text = "Number";
            // 
            // numberUpDown
            // 
            this.numberUpDown.Location = new System.Drawing.Point(290, 71);
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
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(149, 50);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(152, 71);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // addPlayerTitle
            // 
            this.addPlayerTitle.AutoSize = true;
            this.addPlayerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerTitle.Location = new System.Drawing.Point(5, 12);
            this.addPlayerTitle.Name = "addPlayerTitle";
            this.addPlayerTitle.Size = new System.Drawing.Size(285, 25);
            this.addPlayerTitle.TabIndex = 2;
            this.addPlayerTitle.Text = "Insert info below to add a player";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(11, 71);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(8, 50);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // addGameTab
            // 
            this.addGameTab.Location = new System.Drawing.Point(4, 25);
            this.addGameTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addGameTab.Name = "addGameTab";
            this.addGameTab.Size = new System.Drawing.Size(464, 463);
            this.addGameTab.TabIndex = 3;
            this.addGameTab.Text = "Add Game";
            this.addGameTab.UseVisualStyleBackColor = true;
            // 
            // addTeamTab
            // 
            this.addTeamTab.Location = new System.Drawing.Point(4, 25);
            this.addTeamTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTeamTab.Name = "addTeamTab";
            this.addTeamTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTeamTab.Size = new System.Drawing.Size(464, 463);
            this.addTeamTab.TabIndex = 0;
            this.addTeamTab.Text = "Add Team";
            this.addTeamTab.UseVisualStyleBackColor = true;
            // 
            // searchStatsTab
            // 
            this.searchStatsTab.Location = new System.Drawing.Point(4, 25);
            this.searchStatsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchStatsTab.Name = "searchStatsTab";
            this.searchStatsTab.Size = new System.Drawing.Size(464, 463);
            this.searchStatsTab.TabIndex = 2;
            this.searchStatsTab.Text = "Search Stats";
            this.searchStatsTab.UseVisualStyleBackColor = true;
            // 
            // BasketballStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 466);
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
    }
}