
namespace NBA
{
    partial class Form2
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
            this.lbUser = new System.Windows.Forms.Label();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.cbFavorites = new System.Windows.Forms.ComboBox();
            this.lbFavorites = new System.Windows.Forms.ListBox();
            this.btnDeleteFav = new System.Windows.Forms.Button();
            this.btnAddTeamFav = new System.Windows.Forms.Button();
            this.cbHome = new System.Windows.Forms.ComboBox();
            this.cbAway = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddStats = new System.Windows.Forms.Button();
            this.cbPlayers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddPlayerFav = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbStatsPlayer = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbStatsGame = new System.Windows.Forms.ComboBox();
            this.nUDPoints = new System.Windows.Forms.NumericUpDown();
            this.nUDRebounds = new System.Windows.Forms.NumericUpDown();
            this.nUDAssists = new System.Windows.Forms.NumericUpDown();
            this.nUDBlocks = new System.Windows.Forms.NumericUpDown();
            this.nUDSteals = new System.Windows.Forms.NumericUpDown();
            this.btnAddChTeam = new System.Windows.Forms.Button();
            this.nUDYear = new System.Windows.Forms.NumericUpDown();
            this.btnAddChPlayer = new System.Windows.Forms.Button();
            this.dtGame = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRebounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAssists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBlocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSteals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYear)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbUser.Location = new System.Drawing.Point(555, 13);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(51, 20);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "label1";
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(13, 41);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(166, 21);
            this.cbTeams.TabIndex = 2;
            this.cbTeams.SelectedIndexChanged += new System.EventHandler(this.cbTeams_SelectedIndexChanged);
            // 
            // cbFavorites
            // 
            this.cbFavorites.FormattingEnabled = true;
            this.cbFavorites.Items.AddRange(new object[] {
            "Favorite teams",
            "Favorite players"});
            this.cbFavorites.Location = new System.Drawing.Point(437, 41);
            this.cbFavorites.Name = "cbFavorites";
            this.cbFavorites.Size = new System.Drawing.Size(166, 21);
            this.cbFavorites.TabIndex = 3;
            this.cbFavorites.SelectedIndexChanged += new System.EventHandler(this.cbFavorites_SelectedIndexChanged);
            // 
            // lbFavorites
            // 
            this.lbFavorites.FormattingEnabled = true;
            this.lbFavorites.Location = new System.Drawing.Point(438, 64);
            this.lbFavorites.Name = "lbFavorites";
            this.lbFavorites.Size = new System.Drawing.Size(165, 277);
            this.lbFavorites.TabIndex = 5;
            this.lbFavorites.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFavorites_MouseDoubleClick);
            // 
            // btnDeleteFav
            // 
            this.btnDeleteFav.Location = new System.Drawing.Point(439, 359);
            this.btnDeleteFav.Name = "btnDeleteFav";
            this.btnDeleteFav.Size = new System.Drawing.Size(165, 21);
            this.btnDeleteFav.TabIndex = 15;
            this.btnDeleteFav.Text = "Delete from favorites";
            this.btnDeleteFav.UseVisualStyleBackColor = true;
            this.btnDeleteFav.Click += new System.EventHandler(this.btnDeleteFav_Click);
            // 
            // btnAddTeamFav
            // 
            this.btnAddTeamFav.Location = new System.Drawing.Point(13, 68);
            this.btnAddTeamFav.Name = "btnAddTeamFav";
            this.btnAddTeamFav.Size = new System.Drawing.Size(166, 21);
            this.btnAddTeamFav.TabIndex = 14;
            this.btnAddTeamFav.Text = "Add to favorites";
            this.btnAddTeamFav.UseVisualStyleBackColor = true;
            this.btnAddTeamFav.Click += new System.EventHandler(this.btnAddTeamFav_Click);
            // 
            // cbHome
            // 
            this.cbHome.FormattingEnabled = true;
            this.cbHome.Location = new System.Drawing.Point(13, 266);
            this.cbHome.Name = "cbHome";
            this.cbHome.Size = new System.Drawing.Size(166, 21);
            this.cbHome.TabIndex = 18;
            // 
            // cbAway
            // 
            this.cbAway.FormattingEnabled = true;
            this.cbAway.Location = new System.Drawing.Point(13, 306);
            this.cbAway.Name = "cbAway";
            this.cbAway.Size = new System.Drawing.Size(166, 21);
            this.cbAway.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 21);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(78, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "vs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Rebounds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Assists";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Blocks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Steals";
            // 
            // btnAddStats
            // 
            this.btnAddStats.Location = new System.Drawing.Point(212, 202);
            this.btnAddStats.Name = "btnAddStats";
            this.btnAddStats.Size = new System.Drawing.Size(192, 21);
            this.btnAddStats.TabIndex = 36;
            this.btnAddStats.Text = "Add stats";
            this.btnAddStats.UseVisualStyleBackColor = true;
            this.btnAddStats.Click += new System.EventHandler(this.btnAddStats_Click);
            // 
            // cbPlayers
            // 
            this.cbPlayers.FormattingEnabled = true;
            this.cbPlayers.Location = new System.Drawing.Point(13, 108);
            this.cbPlayers.Name = "cbPlayers";
            this.cbPlayers.Size = new System.Drawing.Size(166, 21);
            this.cbPlayers.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Teams";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Players";
            // 
            // btnAddPlayerFav
            // 
            this.btnAddPlayerFav.Location = new System.Drawing.Point(13, 135);
            this.btnAddPlayerFav.Name = "btnAddPlayerFav";
            this.btnAddPlayerFav.Size = new System.Drawing.Size(166, 21);
            this.btnAddPlayerFav.TabIndex = 41;
            this.btnAddPlayerFav.Text = "Add to favorites";
            this.btnAddPlayerFav.UseVisualStyleBackColor = true;
            this.btnAddPlayerFav.Click += new System.EventHandler(this.btnAddPlayerFav_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Player";
            // 
            // cbStatsPlayer
            // 
            this.cbStatsPlayer.FormattingEnabled = true;
            this.cbStatsPlayer.Location = new System.Drawing.Point(212, 41);
            this.cbStatsPlayer.Name = "cbStatsPlayer";
            this.cbStatsPlayer.Size = new System.Drawing.Size(192, 21);
            this.cbStatsPlayer.TabIndex = 50;
            this.cbStatsPlayer.SelectedIndexChanged += new System.EventHandler(this.cbStatsPlayer_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(209, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Game";
            // 
            // cbStatsGame
            // 
            this.cbStatsGame.FormattingEnabled = true;
            this.cbStatsGame.Location = new System.Drawing.Point(212, 88);
            this.cbStatsGame.Name = "cbStatsGame";
            this.cbStatsGame.Size = new System.Drawing.Size(192, 21);
            this.cbStatsGame.TabIndex = 48;
            // 
            // nUDPoints
            // 
            this.nUDPoints.Location = new System.Drawing.Point(212, 137);
            this.nUDPoints.Name = "nUDPoints";
            this.nUDPoints.Size = new System.Drawing.Size(53, 20);
            this.nUDPoints.TabIndex = 52;
            // 
            // nUDRebounds
            // 
            this.nUDRebounds.Location = new System.Drawing.Point(212, 176);
            this.nUDRebounds.Name = "nUDRebounds";
            this.nUDRebounds.Size = new System.Drawing.Size(53, 20);
            this.nUDRebounds.TabIndex = 53;
            // 
            // nUDAssists
            // 
            this.nUDAssists.Location = new System.Drawing.Point(285, 137);
            this.nUDAssists.Name = "nUDAssists";
            this.nUDAssists.Size = new System.Drawing.Size(53, 20);
            this.nUDAssists.TabIndex = 54;
            // 
            // nUDBlocks
            // 
            this.nUDBlocks.Location = new System.Drawing.Point(285, 176);
            this.nUDBlocks.Name = "nUDBlocks";
            this.nUDBlocks.Size = new System.Drawing.Size(53, 20);
            this.nUDBlocks.TabIndex = 55;
            // 
            // nUDSteals
            // 
            this.nUDSteals.Location = new System.Drawing.Point(351, 137);
            this.nUDSteals.Name = "nUDSteals";
            this.nUDSteals.Size = new System.Drawing.Size(53, 20);
            this.nUDSteals.TabIndex = 56;
            // 
            // btnAddChTeam
            // 
            this.btnAddChTeam.Location = new System.Drawing.Point(12, 198);
            this.btnAddChTeam.Name = "btnAddChTeam";
            this.btnAddChTeam.Size = new System.Drawing.Size(166, 21);
            this.btnAddChTeam.TabIndex = 57;
            this.btnAddChTeam.Text = "Add championship to team";
            this.btnAddChTeam.UseVisualStyleBackColor = true;
            this.btnAddChTeam.Click += new System.EventHandler(this.btnAddChTeam_Click);
            // 
            // nUDYear
            // 
            this.nUDYear.Location = new System.Drawing.Point(13, 172);
            this.nUDYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nUDYear.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.nUDYear.Name = "nUDYear";
            this.nUDYear.Size = new System.Drawing.Size(166, 20);
            this.nUDYear.TabIndex = 58;
            this.nUDYear.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // btnAddChPlayer
            // 
            this.btnAddChPlayer.Location = new System.Drawing.Point(13, 225);
            this.btnAddChPlayer.Name = "btnAddChPlayer";
            this.btnAddChPlayer.Size = new System.Drawing.Size(166, 21);
            this.btnAddChPlayer.TabIndex = 59;
            this.btnAddChPlayer.Text = "Add championship to player";
            this.btnAddChPlayer.UseVisualStyleBackColor = true;
            this.btnAddChPlayer.Click += new System.EventHandler(this.btnAddChPlayer_Click);
            // 
            // dtGame
            // 
            this.dtGame.Location = new System.Drawing.Point(12, 333);
            this.dtGame.Name = "dtGame";
            this.dtGame.Size = new System.Drawing.Size(166, 20);
            this.dtGame.TabIndex = 60;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 397);
            this.Controls.Add(this.dtGame);
            this.Controls.Add(this.btnAddChPlayer);
            this.Controls.Add(this.nUDYear);
            this.Controls.Add(this.btnAddChTeam);
            this.Controls.Add(this.nUDSteals);
            this.Controls.Add(this.nUDBlocks);
            this.Controls.Add(this.nUDAssists);
            this.Controls.Add(this.nUDRebounds);
            this.Controls.Add(this.nUDPoints);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbStatsPlayer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbStatsGame);
            this.Controls.Add(this.btnAddPlayerFav);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPlayers);
            this.Controls.Add(this.btnAddStats);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbAway);
            this.Controls.Add(this.cbHome);
            this.Controls.Add(this.btnDeleteFav);
            this.Controls.Add(this.btnAddTeamFav);
            this.Controls.Add(this.lbFavorites);
            this.Controls.Add(this.cbFavorites);
            this.Controls.Add(this.cbTeams);
            this.Controls.Add(this.lbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRebounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAssists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBlocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSteals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.ComboBox cbFavorites;
        private System.Windows.Forms.ListBox lbFavorites;
        private System.Windows.Forms.Button btnDeleteFav;
        private System.Windows.Forms.Button btnAddTeamFav;
        private System.Windows.Forms.ComboBox cbHome;
        private System.Windows.Forms.ComboBox cbAway;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddStats;
        private System.Windows.Forms.ComboBox cbPlayers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddPlayerFav;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbStatsPlayer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbStatsGame;
        private System.Windows.Forms.NumericUpDown nUDPoints;
        private System.Windows.Forms.NumericUpDown nUDRebounds;
        private System.Windows.Forms.NumericUpDown nUDAssists;
        private System.Windows.Forms.NumericUpDown nUDBlocks;
        private System.Windows.Forms.NumericUpDown nUDSteals;
        private System.Windows.Forms.Button btnAddChTeam;
        private System.Windows.Forms.NumericUpDown nUDYear;
        private System.Windows.Forms.Button btnAddChPlayer;
        private System.Windows.Forms.DateTimePicker dtGame;
    }
}

