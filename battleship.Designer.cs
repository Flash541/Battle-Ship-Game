namespace battleship_sv
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playerScore = new System.Windows.Forms.Label();
            this.roundsText = new System.Windows.Forms.Label();
            this.enemyScore = new System.Windows.Forms.Label();
            this.enemyMoves = new System.Windows.Forms.Label();
            this.helpText = new System.Windows.Forms.Label();
            this.enemyLocationList = new System.Windows.Forms.ComboBox();
            this.w1 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.enemyPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyPositionPicker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.Color.Transparent;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerScore.ForeColor = System.Drawing.Color.White;
            this.playerScore.Location = new System.Drawing.Point(347, 105);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(48, 32);
            this.playerScore.TabIndex = 0;
            this.playerScore.Text = "00";
            // 
            // roundsText
            // 
            this.roundsText.AutoSize = true;
            this.roundsText.BackColor = System.Drawing.Color.Transparent;
            this.roundsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundsText.ForeColor = System.Drawing.Color.White;
            this.roundsText.Location = new System.Drawing.Point(482, 189);
            this.roundsText.Name = "roundsText";
            this.roundsText.Size = new System.Drawing.Size(96, 22);
            this.roundsText.TabIndex = 0;
            this.roundsText.Text = "Round:10";
            this.roundsText.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // enemyScore
            // 
            this.enemyScore.AutoSize = true;
            this.enemyScore.BackColor = System.Drawing.Color.Transparent;
            this.enemyScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemyScore.ForeColor = System.Drawing.Color.White;
            this.enemyScore.Location = new System.Drawing.Point(889, 105);
            this.enemyScore.Name = "enemyScore";
            this.enemyScore.Size = new System.Drawing.Size(48, 32);
            this.enemyScore.TabIndex = 0;
            this.enemyScore.Text = "00";
            // 
            // enemyMoves
            // 
            this.enemyMoves.AutoSize = true;
            this.enemyMoves.BackColor = System.Drawing.Color.Transparent;
            this.enemyMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemyMoves.ForeColor = System.Drawing.Color.White;
            this.enemyMoves.Location = new System.Drawing.Point(875, 40);
            this.enemyMoves.Name = "enemyMoves";
            this.enemyMoves.Size = new System.Drawing.Size(34, 22);
            this.enemyMoves.TabIndex = 0;
            this.enemyMoves.Text = "A1";
            this.enemyMoves.Click += new System.EventHandler(this.label2_Click);
            // 
            // helpText
            // 
            this.helpText.AutoSize = true;
            this.helpText.BackColor = System.Drawing.Color.Transparent;
            this.helpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpText.ForeColor = System.Drawing.Color.DeepPink;
            this.helpText.Location = new System.Drawing.Point(65, 532);
            this.helpText.Name = "helpText";
            this.helpText.Size = new System.Drawing.Size(459, 22);
            this.helpText.TabIndex = 0;
            this.helpText.Text = "1) click on 3 different locations from above to start";
            this.helpText.Click += new System.EventHandler(this.txtRounds_Click);
            // 
            // enemyLocationList
            // 
            this.enemyLocationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyLocationList.DropDownWidth = 95;
            this.enemyLocationList.FormattingEnabled = true;
            this.enemyLocationList.Location = new System.Drawing.Point(175, 29);
            this.enemyLocationList.Name = "enemyLocationList";
            this.enemyLocationList.Size = new System.Drawing.Size(107, 24);
            this.enemyLocationList.TabIndex = 3;
            // 
            // w1
            // 
            this.w1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.w1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.w1.Location = new System.Drawing.Point(101, 226);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(81, 60);
            this.w1.TabIndex = 4;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = false;
            this.w1.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // w2
            // 
            this.w2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.w2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.w2.Location = new System.Drawing.Point(195, 226);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(81, 60);
            this.w2.TabIndex = 4;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = false;
            this.w2.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // w3
            // 
            this.w3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.w3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.w3.Location = new System.Drawing.Point(287, 226);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(81, 60);
            this.w3.TabIndex = 4;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = false;
            this.w3.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // x1
            // 
            this.x1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.x1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1.Location = new System.Drawing.Point(100, 303);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(81, 60);
            this.x1.TabIndex = 4;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = false;
            this.x1.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // y2
            // 
            this.y2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y2.Location = new System.Drawing.Point(193, 378);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(81, 60);
            this.y2.TabIndex = 4;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = false;
            this.y2.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // y1
            // 
            this.y1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y1.Location = new System.Drawing.Point(102, 377);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(81, 60);
            this.y1.TabIndex = 4;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = false;
            this.y1.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // z1
            // 
            this.z1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.z1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z1.Location = new System.Drawing.Point(102, 453);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(81, 60);
            this.z1.TabIndex = 4;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = false;
            this.z1.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // z2
            // 
            this.z2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.z2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z2.Location = new System.Drawing.Point(194, 454);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(81, 60);
            this.z2.TabIndex = 4;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = false;
            this.z2.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // x2
            // 
            this.x2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.x2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x2.Location = new System.Drawing.Point(193, 301);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(81, 60);
            this.x2.TabIndex = 4;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = false;
            this.x2.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // x3
            // 
            this.x3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.x3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x3.Location = new System.Drawing.Point(286, 300);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(81, 60);
            this.x3.TabIndex = 4;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = false;
            this.x3.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // y4
            // 
            this.y4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y4.Location = new System.Drawing.Point(377, 377);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(81, 60);
            this.y4.TabIndex = 4;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = false;
            this.y4.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // w4
            // 
            this.w4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.w4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.w4.Location = new System.Drawing.Point(377, 226);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(81, 60);
            this.w4.TabIndex = 4;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = false;
            this.w4.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // y3
            // 
            this.y3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y3.Location = new System.Drawing.Point(288, 376);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(81, 60);
            this.y3.TabIndex = 4;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = false;
            this.y3.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // x4
            // 
            this.x4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.x4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x4.Location = new System.Drawing.Point(379, 300);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(81, 60);
            this.x4.TabIndex = 4;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = false;
            this.x4.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // z4
            // 
            this.z4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.z4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z4.Location = new System.Drawing.Point(380, 454);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(81, 60);
            this.z4.TabIndex = 4;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = false;
            this.z4.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // z3
            // 
            this.z3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.z3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z3.Location = new System.Drawing.Point(287, 454);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(81, 60);
            this.z3.TabIndex = 4;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = false;
            this.z3.Click += new System.EventHandler(this.PlayerPicksPosition);
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.a1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1.Location = new System.Drawing.Point(599, 226);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(81, 60);
            this.a1.TabIndex = 4;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = false;
            this.a1.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2.Location = new System.Drawing.Point(693, 226);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(81, 60);
            this.a2.TabIndex = 4;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = false;
            this.a2.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1.Location = new System.Drawing.Point(600, 377);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(81, 60);
            this.c1.TabIndex = 4;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = false;
            this.c1.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a3.Location = new System.Drawing.Point(785, 226);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(81, 60);
            this.a3.TabIndex = 4;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = false;
            this.a3.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b1.Location = new System.Drawing.Point(598, 303);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(81, 60);
            this.b1.TabIndex = 4;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // c2
            // 
            this.c2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c2.Location = new System.Drawing.Point(691, 378);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(81, 60);
            this.c2.TabIndex = 4;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = false;
            this.c2.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b2.Location = new System.Drawing.Point(691, 301);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(81, 60);
            this.b2.TabIndex = 4;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // c4
            // 
            this.c4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c4.Location = new System.Drawing.Point(875, 377);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(81, 60);
            this.c4.TabIndex = 4;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = false;
            this.c4.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // c3
            // 
            this.c3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c3.Location = new System.Drawing.Point(786, 376);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(81, 60);
            this.c3.TabIndex = 4;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = false;
            this.c3.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // d4
            // 
            this.d4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.d4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d4.Location = new System.Drawing.Point(878, 454);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(81, 60);
            this.d4.TabIndex = 4;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = false;
            this.d4.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // d3
            // 
            this.d3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d3.Location = new System.Drawing.Point(785, 454);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(81, 60);
            this.d3.TabIndex = 4;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = false;
            this.d3.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b3.Location = new System.Drawing.Point(784, 300);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(81, 60);
            this.b3.TabIndex = 4;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // a4
            // 
            this.a4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a4.Location = new System.Drawing.Point(875, 226);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(81, 60);
            this.a4.TabIndex = 4;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = false;
            this.a4.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b4.Location = new System.Drawing.Point(877, 300);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(81, 60);
            this.b4.TabIndex = 4;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // d1
            // 
            this.d1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d1.Location = new System.Drawing.Point(600, 453);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(81, 60);
            this.d1.TabIndex = 4;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = false;
            this.d1.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // d2
            // 
            this.d2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d2.Location = new System.Drawing.Point(692, 454);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(81, 60);
            this.d2.TabIndex = 4;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = false;
            this.d2.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attackButton.Location = new System.Drawing.Point(302, 21);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(81, 41);
            this.attackButton.TabIndex = 4;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.AttackEnemyPosition);
            // 
            // enemyPlayTimer
            // 
            this.enemyPlayTimer.Enabled = true;
            this.enemyPlayTimer.Interval = 1000;
            this.enemyPlayTimer.Tick += new System.EventHandler(this.enemyAttackPlayer);
            // 
            // enemyPositionPicker
            // 
            this.enemyPositionPicker.Enabled = true;
            this.enemyPositionPicker.Interval = 500;
            this.enemyPositionPicker.Tick += new System.EventHandler(this.enemyPicksPostions);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::battleship_sv.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 578);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.enemyLocationList);
            this.Controls.Add(this.helpText);
            this.Controls.Add(this.roundsText);
            this.Controls.Add(this.enemyMoves);
            this.Controls.Add(this.enemyScore);
            this.Controls.Add(this.playerScore);
            this.Name = "Form1";
            this.Text = "battleship game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label roundsText;
        private System.Windows.Forms.Label enemyScore;
        private System.Windows.Forms.Label enemyMoves;
        private System.Windows.Forms.Label helpText;
        private System.Windows.Forms.ComboBox enemyLocationList;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Timer enemyPlayTimer;
        private System.Windows.Forms.Timer enemyPositionPicker;
    }
}

