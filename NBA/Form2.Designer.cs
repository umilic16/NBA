
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
            this.btnAddResult = new System.Windows.Forms.Button();
            this.nUDAway = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddStats = new System.Windows.Forms.Button();
            this.cbPlayers = new System.Windows.Forms.ComboBox();
            this.cbGames = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddPlayerFav = new System.Windows.Forms.Button();
            this.nUDHome = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbStatsPlayer = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbStatsGame = new System.Windows.Forms.ComboBox();
            this.nUDPoints = new System.Windows.Forms.NumericUpDown();
            this.nUDRebounds = new System.Windows.Forms.NumericUpDown();
            this.nUDAssists = new System.Windows.Forms.NumericUpDown();
            this.nUDBlocks = new System.Windows.Forms.NumericUpDown();
            this.nUDSteals = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRebounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAssists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBlocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSteals)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbUser.Location = new System.Drawing.Point(507, 13);
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
            // 
            // cbFavorites
            // 
            this.cbFavorites.FormattingEnabled = true;
            this.cbFavorites.Items.AddRange(new object[] {
            "Favorite teams",
            "Favorite players"});
            this.cbFavorites.Location = new System.Drawing.Point(391, 41);
            this.cbFavorites.Name = "cbFavorites";
            this.cbFavorites.Size = new System.Drawing.Size(166, 21);
            this.cbFavorites.TabIndex = 3;
            // 
            // lbFavorites
            // 
            this.lbFavorites.FormattingEnabled = true;
            this.lbFavorites.Location = new System.Drawing.Point(392, 64);
            this.lbFavorites.Name = "lbFavorites";
            this.lbFavorites.Size = new System.Drawing.Size(165, 277);
            this.lbFavorites.TabIndex = 5;
            // 
            // btnDeleteFav
            // 
            this.btnDeleteFav.Location = new System.Drawing.Point(392, 349);
            this.btnDeleteFav.Name = "btnDeleteFav";
            this.btnDeleteFav.Size = new System.Drawing.Size(165, 21);
            this.btnDeleteFav.TabIndex = 15;
            this.btnDeleteFav.Text = "Delete from favorites";
            this.btnDeleteFav.UseVisualStyleBackColor = true;
            // 
            // btnAddTeamFav
            // 
            this.btnAddTeamFav.Location = new System.Drawing.Point(13, 68);
            this.btnAddTeamFav.Name = "btnAddTeamFav";
            this.btnAddTeamFav.Size = new System.Drawing.Size(166, 21);
            this.btnAddTeamFav.TabIndex = 14;
            this.btnAddTeamFav.Text = "Add to favorites";
            this.btnAddTeamFav.UseVisualStyleBackColor = true;
            // 
            // cbHome
            // 
            this.cbHome.FormattingEnabled = true;
            this.cbHome.Location = new System.Drawing.Point(13, 177);
            this.cbHome.Name = "cbHome";
            this.cbHome.Size = new System.Drawing.Size(166, 21);
            this.cbHome.TabIndex = 18;
            // 
            // cbAway
            // 
            this.cbAway.FormattingEnabled = true;
            this.cbAway.Location = new System.Drawing.Point(13, 217);
            this.cbAway.Name = "cbAway";
            this.cbAway.Size = new System.Drawing.Size(166, 21);
            this.cbAway.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 21);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add game";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(78, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "vs";
            // 
            // btnAddResult
            // 
            this.btnAddResult.Location = new System.Drawing.Point(14, 349);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(166, 21);
            this.btnAddResult.TabIndex = 22;
            this.btnAddResult.Text = "Add result";
            this.btnAddResult.UseVisualStyleBackColor = true;
            // 
            // nUDAway
            // 
            this.nUDAway.Location = new System.Drawing.Point(120, 323);
            this.nUDAway.Name = "nUDAway";
            this.nUDAway.Size = new System.Drawing.Size(59, 20);
            this.nUDAway.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(90, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = ":";
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
            this.label5.Location = new System.Drawing.Point(209, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Assists";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Blocks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Steals";
            // 
            // btnAddStats
            // 
            this.btnAddStats.Location = new System.Drawing.Point(212, 349);
            this.btnAddStats.Name = "btnAddStats";
            this.btnAddStats.Size = new System.Drawing.Size(143, 21);
            this.btnAddStats.TabIndex = 36;
            this.btnAddStats.Text = "Add stats";
            this.btnAddStats.UseVisualStyleBackColor = true;
            // 
            // cbPlayers
            // 
            this.cbPlayers.FormattingEnabled = true;
            this.cbPlayers.Location = new System.Drawing.Point(13, 108);
            this.cbPlayers.Name = "cbPlayers";
            this.cbPlayers.Size = new System.Drawing.Size(166, 21);
            this.cbPlayers.TabIndex = 37;
            // 
            // cbGames
            // 
            this.cbGames.FormattingEnabled = true;
            this.cbGames.Location = new System.Drawing.Point(13, 296);
            this.cbGames.Name = "cbGames";
            this.cbGames.Size = new System.Drawing.Size(166, 21);
            this.cbGames.TabIndex = 38;
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
            // 
            // nUDHome
            // 
            this.nUDHome.Location = new System.Drawing.Point(13, 323);
            this.nUDHome.Name = "nUDHome";
            this.nUDHome.Size = new System.Drawing.Size(59, 20);
            this.nUDHome.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Games";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Player";
            // 
            // cbStatsPlayer
            // 
            this.cbStatsPlayer.FormattingEnabled = true;
            this.cbStatsPlayer.Location = new System.Drawing.Point(212, 81);
            this.cbStatsPlayer.Name = "cbStatsPlayer";
            this.cbStatsPlayer.Size = new System.Drawing.Size(143, 21);
            this.cbStatsPlayer.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(209, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Game";
            // 
            // cbStatsGame
            // 
            this.cbStatsGame.FormattingEnabled = true;
            this.cbStatsGame.Location = new System.Drawing.Point(212, 41);
            this.cbStatsGame.Name = "cbStatsGame";
            this.cbStatsGame.Size = new System.Drawing.Size(143, 21);
            this.cbStatsGame.TabIndex = 48;
            // 
            // nUDPoints
            // 
            this.nUDPoints.Location = new System.Drawing.Point(212, 137);
            this.nUDPoints.Name = "nUDPoints";
            this.nUDPoints.Size = new System.Drawing.Size(143, 20);
            this.nUDPoints.TabIndex = 52;
            // 
            // nUDRebounds
            // 
            this.nUDRebounds.Location = new System.Drawing.Point(212, 176);
            this.nUDRebounds.Name = "nUDRebounds";
            this.nUDRebounds.Size = new System.Drawing.Size(143, 20);
            this.nUDRebounds.TabIndex = 53;
            // 
            // nUDAssists
            // 
            this.nUDAssists.Location = new System.Drawing.Point(212, 215);
            this.nUDAssists.Name = "nUDAssists";
            this.nUDAssists.Size = new System.Drawing.Size(143, 20);
            this.nUDAssists.TabIndex = 54;
            // 
            // nUDBlocks
            // 
            this.nUDBlocks.Location = new System.Drawing.Point(212, 254);
            this.nUDBlocks.Name = "nUDBlocks";
            this.nUDBlocks.Size = new System.Drawing.Size(143, 20);
            this.nUDBlocks.TabIndex = 55;
            // 
            // nUDSteals
            // 
            this.nUDSteals.Location = new System.Drawing.Point(212, 293);
            this.nUDSteals.Name = "nUDSteals";
            this.nUDSteals.Size = new System.Drawing.Size(143, 20);
            this.nUDSteals.TabIndex = 56;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 398);
            this.Controls.Add(this.nUDSteals);
            this.Controls.Add(this.nUDBlocks);
            this.Controls.Add(this.nUDAssists);
            this.Controls.Add(this.nUDRebounds);
            this.Controls.Add(this.nUDPoints);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbStatsPlayer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbStatsGame);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nUDHome);
            this.Controls.Add(this.btnAddPlayerFav);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbGames);
            this.Controls.Add(this.cbPlayers);
            this.Controls.Add(this.btnAddStats);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nUDAway);
            this.Controls.Add(this.btnAddResult);
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
            ((System.ComponentModel.ISupportInitialize)(this.nUDAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRebounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAssists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBlocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSteals)).EndInit();
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
        private System.Windows.Forms.Button btnAddResult;
        private System.Windows.Forms.NumericUpDown nUDAway;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddStats;
        private System.Windows.Forms.ComboBox cbPlayers;
        private System.Windows.Forms.ComboBox cbGames;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddPlayerFav;
        private System.Windows.Forms.NumericUpDown nUDHome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbStatsPlayer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbStatsGame;
        private System.Windows.Forms.NumericUpDown nUDPoints;
        private System.Windows.Forms.NumericUpDown nUDRebounds;
        private System.Windows.Forms.NumericUpDown nUDAssists;
        private System.Windows.Forms.NumericUpDown nUDBlocks;
        private System.Windows.Forms.NumericUpDown nUDSteals;
    }
}

