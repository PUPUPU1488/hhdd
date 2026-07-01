namespace The_Kingdom
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
            this.panelEvents = new System.Windows.Forms.Panel();
            this.labelLastEvent = new System.Windows.Forms.Label();
            this.labelLNewEvent = new System.Windows.Forms.Label();
            this.labelAboutEvents = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTreasuryStatus = new System.Windows.Forms.Label();
            this.labelAboutTreasury = new System.Windows.Forms.Label();
            this.progressbarTreasury = new System.Windows.Forms.ProgressBar();
            this.labelAboutLevelTaxes = new System.Windows.Forms.Label();
            this.trackBarLevelTaxes = new System.Windows.Forms.TrackBar();
            this.labelMoodPeopleStatus = new System.Windows.Forms.Label();
            this.labelAboutMoodPeople = new System.Windows.Forms.Label();
            this.progressbarMoodPeople = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAwarding = new System.Windows.Forms.Button();
            this.buttonWar = new System.Windows.Forms.Button();
            this.buttonGetTaxes = new System.Windows.Forms.Button();
            this.buttonDecree = new System.Windows.Forms.Button();
            this.panelEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLevelTaxes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEvents
            // 
            this.panelEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelEvents.Controls.Add(this.labelLastEvent);
            this.panelEvents.Controls.Add(this.labelLNewEvent);
            this.panelEvents.Controls.Add(this.labelAboutEvents);
            this.panelEvents.Location = new System.Drawing.Point(58, 413);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(629, 139);
            this.panelEvents.TabIndex = 0;
            // 
            // labelLastEvent
            // 
            this.labelLastEvent.AutoSize = true;
            this.labelLastEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastEvent.Location = new System.Drawing.Point(287, 41);
            this.labelLastEvent.Name = "labelLastEvent";
            this.labelLastEvent.Size = new System.Drawing.Size(46, 18);
            this.labelLastEvent.TabIndex = 4;
            this.labelLastEvent.Text = "label1";
            // 
            // labelLNewEvent
            // 
            this.labelLNewEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLNewEvent.AutoSize = true;
            this.labelLNewEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLNewEvent.Location = new System.Drawing.Point(274, 87);
            this.labelLNewEvent.Name = "labelLNewEvent";
            this.labelLNewEvent.Size = new System.Drawing.Size(85, 29);
            this.labelLNewEvent.TabIndex = 3;
            this.labelLNewEvent.Text = "label1";
            // 
            // labelAboutEvents
            // 
            this.labelAboutEvents.AutoSize = true;
            this.labelAboutEvents.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAboutEvents.Location = new System.Drawing.Point(287, 0);
            this.labelAboutEvents.Name = "labelAboutEvents";
            this.labelAboutEvents.Size = new System.Drawing.Size(52, 15);
            this.labelAboutEvents.TabIndex = 1;
            this.labelAboutEvents.Text = "События";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.labelTreasuryStatus);
            this.panel1.Controls.Add(this.labelAboutTreasury);
            this.panel1.Controls.Add(this.progressbarTreasury);
            this.panel1.Controls.Add(this.labelAboutLevelTaxes);
            this.panel1.Controls.Add(this.trackBarLevelTaxes);
            this.panel1.Controls.Add(this.labelMoodPeopleStatus);
            this.panel1.Controls.Add(this.labelAboutMoodPeople);
            this.panel1.Controls.Add(this.progressbarMoodPeople);
            this.panel1.Location = new System.Drawing.Point(92, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 178);
            this.panel1.TabIndex = 2;
            // 
            // labelTreasuryStatus
            // 
            this.labelTreasuryStatus.AutoSize = true;
            this.labelTreasuryStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTreasuryStatus.ForeColor = System.Drawing.Color.Red;
            this.labelTreasuryStatus.Location = new System.Drawing.Point(386, 135);
            this.labelTreasuryStatus.Name = "labelTreasuryStatus";
            this.labelTreasuryStatus.Size = new System.Drawing.Size(117, 19);
            this.labelTreasuryStatus.TabIndex = 10;
            this.labelTreasuryStatus.Text = "Казна пустеет!";
            // 
            // labelAboutTreasury
            // 
            this.labelAboutTreasury.AutoSize = true;
            this.labelAboutTreasury.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAboutTreasury.Location = new System.Drawing.Point(65, 135);
            this.labelAboutTreasury.Name = "labelAboutTreasury";
            this.labelAboutTreasury.Size = new System.Drawing.Size(49, 19);
            this.labelAboutTreasury.TabIndex = 9;
            this.labelAboutTreasury.Text = "Казна";
            // 
            // progressbarTreasury
            // 
            this.progressbarTreasury.BackColor = System.Drawing.Color.DimGray;
            this.progressbarTreasury.Location = new System.Drawing.Point(167, 135);
            this.progressbarTreasury.Name = "progressbarTreasury";
            this.progressbarTreasury.Size = new System.Drawing.Size(201, 23);
            this.progressbarTreasury.TabIndex = 8;
            // 
            // labelAboutLevelTaxes
            // 
            this.labelAboutLevelTaxes.AutoSize = true;
            this.labelAboutLevelTaxes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAboutLevelTaxes.Location = new System.Drawing.Point(21, 75);
            this.labelAboutLevelTaxes.Name = "labelAboutLevelTaxes";
            this.labelAboutLevelTaxes.Size = new System.Drawing.Size(124, 19);
            this.labelAboutLevelTaxes.TabIndex = 7;
            this.labelAboutLevelTaxes.Text = "Уровень налогов";
            // 
            // trackBarLevelTaxes
            // 
            this.trackBarLevelTaxes.BackColor = System.Drawing.Color.Silver;
            this.trackBarLevelTaxes.LargeChange = 1;
            this.trackBarLevelTaxes.Location = new System.Drawing.Point(167, 65);
            this.trackBarLevelTaxes.Maximum = 3;
            this.trackBarLevelTaxes.Minimum = 1;
            this.trackBarLevelTaxes.Name = "trackBarLevelTaxes";
            this.trackBarLevelTaxes.Size = new System.Drawing.Size(201, 45);
            this.trackBarLevelTaxes.TabIndex = 3;
            this.trackBarLevelTaxes.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarLevelTaxes.Value = 1;
            this.trackBarLevelTaxes.Scroll += new System.EventHandler(this.trackBarLevelTaxes_Scroll_1);
            // 
            // labelMoodPeopleStatus
            // 
            this.labelMoodPeopleStatus.AutoSize = true;
            this.labelMoodPeopleStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoodPeopleStatus.Location = new System.Drawing.Point(386, 20);
            this.labelMoodPeopleStatus.Name = "labelMoodPeopleStatus";
            this.labelMoodPeopleStatus.Size = new System.Drawing.Size(140, 19);
            this.labelMoodPeopleStatus.TabIndex = 5;
            this.labelMoodPeopleStatus.Text = "Настроение народа";
            // 
            // labelAboutMoodPeople
            // 
            this.labelAboutMoodPeople.AutoSize = true;
            this.labelAboutMoodPeople.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAboutMoodPeople.Location = new System.Drawing.Point(21, 20);
            this.labelAboutMoodPeople.Name = "labelAboutMoodPeople";
            this.labelAboutMoodPeople.Size = new System.Drawing.Size(140, 19);
            this.labelAboutMoodPeople.TabIndex = 4;
            this.labelAboutMoodPeople.Text = "Настроение народа";
            // 
            // progressbarMoodPeople
            // 
            this.progressbarMoodPeople.BackColor = System.Drawing.Color.DimGray;
            this.progressbarMoodPeople.Location = new System.Drawing.Point(167, 20);
            this.progressbarMoodPeople.Name = "progressbarMoodPeople";
            this.progressbarMoodPeople.Size = new System.Drawing.Size(201, 23);
            this.progressbarMoodPeople.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.buttonAwarding);
            this.panel2.Controls.Add(this.buttonWar);
            this.panel2.Controls.Add(this.buttonGetTaxes);
            this.panel2.Controls.Add(this.buttonDecree);
            this.panel2.Location = new System.Drawing.Point(71, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 111);
            this.panel2.TabIndex = 3;
            // 
            // buttonAwarding
            // 
            this.buttonAwarding.Location = new System.Drawing.Point(453, 46);
            this.buttonAwarding.Name = "buttonAwarding";
            this.buttonAwarding.Size = new System.Drawing.Size(133, 23);
            this.buttonAwarding.TabIndex = 7;
            this.buttonAwarding.Text = "Наградить верных";
            this.buttonAwarding.UseVisualStyleBackColor = true;
            this.buttonAwarding.Click += new System.EventHandler(this.buttonAwarding_Click);
            // 
            // buttonWar
            // 
            this.buttonWar.Location = new System.Drawing.Point(266, 46);
            this.buttonWar.Name = "buttonWar";
            this.buttonWar.Size = new System.Drawing.Size(181, 23);
            this.buttonWar.TabIndex = 6;
            this.buttonWar.Text = "Объявить войну соседям";
            this.buttonWar.UseVisualStyleBackColor = true;
            this.buttonWar.Click += new System.EventHandler(this.buttonWar_Click);
            // 
            // buttonGetTaxes
            // 
            this.buttonGetTaxes.Location = new System.Drawing.Point(141, 46);
            this.buttonGetTaxes.Name = "buttonGetTaxes";
            this.buttonGetTaxes.Size = new System.Drawing.Size(119, 23);
            this.buttonGetTaxes.TabIndex = 5;
            this.buttonGetTaxes.Text = "Собрать налоги";
            this.buttonGetTaxes.UseVisualStyleBackColor = true;
            this.buttonGetTaxes.Click += new System.EventHandler(this.buttonGetTaxes_Click);
            // 
            // buttonDecree
            // 
            this.buttonDecree.Location = new System.Drawing.Point(21, 46);
            this.buttonDecree.Name = "buttonDecree";
            this.buttonDecree.Size = new System.Drawing.Size(114, 23);
            this.buttonDecree.TabIndex = 4;
            this.buttonDecree.Text = "Издать указ";
            this.buttonDecree.UseVisualStyleBackColor = true;
            this.buttonDecree.Click += new System.EventHandler(this.buttonDecree_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelEvents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelEvents.ResumeLayout(false);
            this.panelEvents.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLevelTaxes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEvents;
        private System.Windows.Forms.Label labelAboutEvents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressbarMoodPeople;
        private System.Windows.Forms.Label labelAboutMoodPeople;
        private System.Windows.Forms.Label labelAboutLevelTaxes;
        private System.Windows.Forms.TrackBar trackBarLevelTaxes;
        private System.Windows.Forms.Label labelMoodPeopleStatus;
        private System.Windows.Forms.Label labelTreasuryStatus;
        private System.Windows.Forms.Label labelAboutTreasury;
        private System.Windows.Forms.ProgressBar progressbarTreasury;
        private System.Windows.Forms.Label labelLastEvent;
        private System.Windows.Forms.Label labelLNewEvent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDecree;
        private System.Windows.Forms.Button buttonAwarding;
        private System.Windows.Forms.Button buttonWar;
        private System.Windows.Forms.Button buttonGetTaxes;
    }
}

