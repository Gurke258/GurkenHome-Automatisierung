namespace Raspberry
{
    partial class frmHaupt
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmdExit = new System.Windows.Forms.Button();
            this.lblGurkenHome = new System.Windows.Forms.Label();
            this.lblUhrzeit = new System.Windows.Forms.Label();
            this.timerUhrzeit = new System.Windows.Forms.Timer(this.components);
            this.lblTemp = new System.Windows.Forms.Label();
            this.timerDHT = new System.Windows.Forms.Timer(this.components);
            this.tabGurkenhome = new System.Windows.Forms.TabControl();
            this.tpWaesche = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUnterwäsche = new System.Windows.Forms.Label();
            this.cbSonstige = new System.Windows.Forms.ComboBox();
            this.cmdUnterwäsche = new System.Windows.Forms.Button();
            this.lblTimerSonstige = new System.Windows.Forms.Label();
            this.lblTimerWindeln = new System.Windows.Forms.Label();
            this.cmdSonstige = new System.Windows.Forms.Button();
            this.lblTimerUnter = new System.Windows.Forms.Label();
            this.lblSonstige = new System.Windows.Forms.Label();
            this.lblSchwarze = new System.Windows.Forms.Label();
            this.lblTimerWeiß = new System.Windows.Forms.Label();
            this.cmdWindeln = new System.Windows.Forms.Button();
            this.lblTimerSchwarz = new System.Windows.Forms.Label();
            this.lblTimerBunt = new System.Windows.Forms.Label();
            this.lblBunte = new System.Windows.Forms.Label();
            this.cmdWeiße = new System.Windows.Forms.Button();
            this.cmdSchwarze = new System.Windows.Forms.Button();
            this.cmdBunte = new System.Windows.Forms.Button();
            this.lblWeiße = new System.Windows.Forms.Label();
            this.lblWindeln = new System.Windows.Forms.Label();
            this.tpPflanzen = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTimerRadieschen = new System.Windows.Forms.Label();
            this.lblTimerTomate = new System.Windows.Forms.Label();
            this.lblRadies = new System.Windows.Forms.Label();
            this.lblTomaten = new System.Windows.Forms.Label();
            this.lblErdbeere = new System.Windows.Forms.Label();
            this.lblTimerErdbeeren = new System.Windows.Forms.Label();
            this.tpMüll = new System.Windows.Forms.TabPage();
            this.cmdErdbeeren = new System.Windows.Forms.Button();
            this.cmdTomaten = new System.Windows.Forms.Button();
            this.cmdRadieschen = new System.Windows.Forms.Button();
            this.tpEinstellung = new System.Windows.Forms.TabPage();
            this.tabGurkenhome.SuspendLayout();
            this.tpWaesche.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpPflanzen.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(298, 416);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 0;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // lblGurkenHome
            // 
            this.lblGurkenHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGurkenHome.AutoSize = true;
            this.lblGurkenHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGurkenHome.Location = new System.Drawing.Point(176, 8);
            this.lblGurkenHome.Name = "lblGurkenHome";
            this.lblGurkenHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGurkenHome.Size = new System.Drawing.Size(325, 25);
            this.lblGurkenHome.TabIndex = 1;
            this.lblGurkenHome.Text = "GurkenHome Automatisierung";
            // 
            // lblUhrzeit
            // 
            this.lblUhrzeit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUhrzeit.AutoSize = true;
            this.lblUhrzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUhrzeit.Location = new System.Drawing.Point(503, 17);
            this.lblUhrzeit.Name = "lblUhrzeit";
            this.lblUhrzeit.Size = new System.Drawing.Size(180, 16);
            this.lblUhrzeit.TabIndex = 4;
            this.lblUhrzeit.Text = "Donnerstag, 27.06.2020 15:36";
            // 
            // timerUhrzeit
            // 
            this.timerUhrzeit.Interval = 500;
            this.timerUhrzeit.Tick += new System.EventHandler(this.timerUhrzeit_Tick);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(172, 62);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(332, 20);
            this.lblTemp.TabIndex = 5;
            this.lblTemp.Text = "Temperatur = 19.0*C Luftfeuchtigkeit = 63.0%\r\n";
            // 
            // timerDHT
            // 
            this.timerDHT.Interval = 20000;
            this.timerDHT.Tick += new System.EventHandler(this.timerDHT_Tick);
            // 
            // tabGurkenhome
            // 
            this.tabGurkenhome.Controls.Add(this.tpWaesche);
            this.tabGurkenhome.Controls.Add(this.tpPflanzen);
            this.tabGurkenhome.Controls.Add(this.tpMüll);
            this.tabGurkenhome.Controls.Add(this.tpEinstellung);
            this.tabGurkenhome.Location = new System.Drawing.Point(2, 85);
            this.tabGurkenhome.Name = "tabGurkenhome";
            this.tabGurkenhome.Padding = new System.Drawing.Point(9, 9);
            this.tabGurkenhome.SelectedIndex = 0;
            this.tabGurkenhome.Size = new System.Drawing.Size(681, 325);
            this.tabGurkenhome.TabIndex = 6;
            // 
            // tpWaesche
            // 
            this.tpWaesche.BackColor = System.Drawing.SystemColors.Control;
            this.tpWaesche.Controls.Add(this.tableLayoutPanel1);
            this.tpWaesche.Location = new System.Drawing.Point(4, 34);
            this.tpWaesche.Name = "tpWaesche";
            this.tpWaesche.Padding = new System.Windows.Forms.Padding(3);
            this.tpWaesche.Size = new System.Drawing.Size(673, 287);
            this.tpWaesche.TabIndex = 0;
            this.tpWaesche.Text = "Wäsche";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.94231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.05769F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Controls.Add(this.lblUnterwäsche, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbSonstige, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmdUnterwäsche, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTimerSonstige, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTimerWindeln, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmdSonstige, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTimerUnter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSonstige, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSchwarze, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTimerWeiß, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmdWindeln, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTimerSchwarz, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTimerBunt, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBunte, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdWeiße, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmdSchwarze, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmdBunte, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblWeiße, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblWindeln, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 281);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // lblUnterwäsche
            // 
            this.lblUnterwäsche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnterwäsche.AutoSize = true;
            this.lblUnterwäsche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnterwäsche.Location = new System.Drawing.Point(3, 0);
            this.lblUnterwäsche.Name = "lblUnterwäsche";
            this.lblUnterwäsche.Size = new System.Drawing.Size(154, 24);
            this.lblUnterwäsche.TabIndex = 0;
            this.lblUnterwäsche.Text = "Unterwäsche";
            this.lblUnterwäsche.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbSonstige
            // 
            this.cbSonstige.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSonstige.Items.AddRange(new object[] {
            "15 Minuten",
            "30 Minuten",
            "35 Minuten",
            "45 Minuten",
            "1 Stunde",
            "1,5 Stunden",
            "2 Stunden"});
            this.cbSonstige.Location = new System.Drawing.Point(576, 173);
            this.cbSonstige.Name = "cbSonstige";
            this.cbSonstige.Size = new System.Drawing.Size(88, 21);
            this.cbSonstige.TabIndex = 19;
            this.cbSonstige.Tag = "";
            this.cbSonstige.Text = "15 Minuten";
            // 
            // cmdUnterwäsche
            // 
            this.cmdUnterwäsche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdUnterwäsche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUnterwäsche.Location = new System.Drawing.Point(3, 37);
            this.cmdUnterwäsche.Name = "cmdUnterwäsche";
            this.cmdUnterwäsche.Size = new System.Drawing.Size(154, 23);
            this.cmdUnterwäsche.TabIndex = 6;
            this.cmdUnterwäsche.Text = "Start";
            this.cmdUnterwäsche.UseVisualStyleBackColor = true;
            this.cmdUnterwäsche.Click += new System.EventHandler(this.cmdUnterwäsche_Click);
            // 
            // lblTimerSonstige
            // 
            this.lblTimerSonstige.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerSonstige.AutoSize = true;
            this.lblTimerSonstige.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerSonstige.Location = new System.Drawing.Point(413, 201);
            this.lblTimerSonstige.Name = "lblTimerSonstige";
            this.lblTimerSonstige.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimerSonstige.Size = new System.Drawing.Size(157, 24);
            this.lblTimerSonstige.TabIndex = 16;
            this.lblTimerSonstige.Text = "--:--:--";
            this.lblTimerSonstige.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimerWindeln
            // 
            this.lblTimerWindeln.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerWindeln.AutoSize = true;
            this.lblTimerWindeln.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerWindeln.Location = new System.Drawing.Point(163, 201);
            this.lblTimerWindeln.Name = "lblTimerWindeln";
            this.lblTimerWindeln.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimerWindeln.Size = new System.Drawing.Size(244, 24);
            this.lblTimerWindeln.TabIndex = 17;
            this.lblTimerWindeln.Text = "03:00:00";
            this.lblTimerWindeln.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdSonstige
            // 
            this.cmdSonstige.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSonstige.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSonstige.Location = new System.Drawing.Point(413, 172);
            this.cmdSonstige.Name = "cmdSonstige";
            this.cmdSonstige.Size = new System.Drawing.Size(157, 23);
            this.cmdSonstige.TabIndex = 11;
            this.cmdSonstige.Text = "Start";
            this.cmdSonstige.UseVisualStyleBackColor = true;
            this.cmdSonstige.Click += new System.EventHandler(this.cmdSonstige_Click);
            // 
            // lblTimerUnter
            // 
            this.lblTimerUnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerUnter.AutoSize = true;
            this.lblTimerUnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerUnter.Location = new System.Drawing.Point(3, 73);
            this.lblTimerUnter.Name = "lblTimerUnter";
            this.lblTimerUnter.Size = new System.Drawing.Size(154, 24);
            this.lblTimerUnter.TabIndex = 12;
            this.lblTimerUnter.Text = "03:00:00";
            this.lblTimerUnter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSonstige
            // 
            this.lblSonstige.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSonstige.AutoSize = true;
            this.lblSonstige.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonstige.Location = new System.Drawing.Point(413, 139);
            this.lblSonstige.Name = "lblSonstige";
            this.lblSonstige.Size = new System.Drawing.Size(157, 24);
            this.lblSonstige.TabIndex = 5;
            this.lblSonstige.Text = "Sonstige";
            this.lblSonstige.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSchwarze
            // 
            this.lblSchwarze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSchwarze.AutoSize = true;
            this.lblSchwarze.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchwarze.Location = new System.Drawing.Point(163, 0);
            this.lblSchwarze.Name = "lblSchwarze";
            this.lblSchwarze.Size = new System.Drawing.Size(244, 24);
            this.lblSchwarze.TabIndex = 1;
            this.lblSchwarze.Text = "Schwarze Wäsche";
            this.lblSchwarze.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimerWeiß
            // 
            this.lblTimerWeiß.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerWeiß.AutoSize = true;
            this.lblTimerWeiß.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerWeiß.Location = new System.Drawing.Point(3, 201);
            this.lblTimerWeiß.Name = "lblTimerWeiß";
            this.lblTimerWeiß.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimerWeiß.Size = new System.Drawing.Size(154, 24);
            this.lblTimerWeiß.TabIndex = 15;
            this.lblTimerWeiß.Text = "02:00:00";
            this.lblTimerWeiß.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdWindeln
            // 
            this.cmdWindeln.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdWindeln.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWindeln.Location = new System.Drawing.Point(163, 172);
            this.cmdWindeln.Name = "cmdWindeln";
            this.cmdWindeln.Size = new System.Drawing.Size(244, 23);
            this.cmdWindeln.TabIndex = 10;
            this.cmdWindeln.Text = "Start";
            this.cmdWindeln.UseVisualStyleBackColor = true;
            this.cmdWindeln.Click += new System.EventHandler(this.cmdWindeln_Click);
            // 
            // lblTimerSchwarz
            // 
            this.lblTimerSchwarz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerSchwarz.AutoSize = true;
            this.lblTimerSchwarz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerSchwarz.Location = new System.Drawing.Point(163, 73);
            this.lblTimerSchwarz.Name = "lblTimerSchwarz";
            this.lblTimerSchwarz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimerSchwarz.Size = new System.Drawing.Size(244, 24);
            this.lblTimerSchwarz.TabIndex = 13;
            this.lblTimerSchwarz.Text = "02:00:00";
            this.lblTimerSchwarz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimerBunt
            // 
            this.lblTimerBunt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerBunt.AutoSize = true;
            this.lblTimerBunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerBunt.Location = new System.Drawing.Point(413, 73);
            this.lblTimerBunt.Name = "lblTimerBunt";
            this.lblTimerBunt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimerBunt.Size = new System.Drawing.Size(157, 24);
            this.lblTimerBunt.TabIndex = 14;
            this.lblTimerBunt.Text = "02:00:00";
            this.lblTimerBunt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBunte
            // 
            this.lblBunte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBunte.AutoSize = true;
            this.lblBunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBunte.Location = new System.Drawing.Point(413, 0);
            this.lblBunte.Name = "lblBunte";
            this.lblBunte.Size = new System.Drawing.Size(157, 24);
            this.lblBunte.TabIndex = 2;
            this.lblBunte.Text = "Bunte Wäsche";
            this.lblBunte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdWeiße
            // 
            this.cmdWeiße.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdWeiße.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWeiße.Location = new System.Drawing.Point(3, 172);
            this.cmdWeiße.Name = "cmdWeiße";
            this.cmdWeiße.Size = new System.Drawing.Size(154, 23);
            this.cmdWeiße.TabIndex = 9;
            this.cmdWeiße.Text = "Start";
            this.cmdWeiße.UseVisualStyleBackColor = true;
            this.cmdWeiße.Click += new System.EventHandler(this.cmdWeiße_Click);
            // 
            // cmdSchwarze
            // 
            this.cmdSchwarze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSchwarze.BackColor = System.Drawing.Color.Transparent;
            this.cmdSchwarze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSchwarze.Location = new System.Drawing.Point(163, 37);
            this.cmdSchwarze.Name = "cmdSchwarze";
            this.cmdSchwarze.Size = new System.Drawing.Size(244, 23);
            this.cmdSchwarze.TabIndex = 7;
            this.cmdSchwarze.Text = "Start";
            this.cmdSchwarze.UseVisualStyleBackColor = false;
            this.cmdSchwarze.Click += new System.EventHandler(this.cmdSchwarze_Click);
            // 
            // cmdBunte
            // 
            this.cmdBunte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBunte.Location = new System.Drawing.Point(413, 37);
            this.cmdBunte.Name = "cmdBunte";
            this.cmdBunte.Size = new System.Drawing.Size(157, 23);
            this.cmdBunte.TabIndex = 8;
            this.cmdBunte.Text = "Start";
            this.cmdBunte.UseVisualStyleBackColor = true;
            this.cmdBunte.Click += new System.EventHandler(this.cmdBunte_Click);
            // 
            // lblWeiße
            // 
            this.lblWeiße.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeiße.AutoSize = true;
            this.lblWeiße.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeiße.Location = new System.Drawing.Point(3, 139);
            this.lblWeiße.Name = "lblWeiße";
            this.lblWeiße.Size = new System.Drawing.Size(154, 24);
            this.lblWeiße.TabIndex = 3;
            this.lblWeiße.Text = "Weiße Wäsche";
            this.lblWeiße.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWindeln
            // 
            this.lblWindeln.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWindeln.AutoSize = true;
            this.lblWindeln.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindeln.Location = new System.Drawing.Point(163, 139);
            this.lblWindeln.Name = "lblWindeln";
            this.lblWindeln.Size = new System.Drawing.Size(244, 24);
            this.lblWindeln.TabIndex = 4;
            this.lblWindeln.Text = "Windeln";
            this.lblWindeln.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpPflanzen
            // 
            this.tpPflanzen.BackColor = System.Drawing.SystemColors.Control;
            this.tpPflanzen.Controls.Add(this.tableLayoutPanel2);
            this.tpPflanzen.Location = new System.Drawing.Point(4, 34);
            this.tpPflanzen.Name = "tpPflanzen";
            this.tpPflanzen.Padding = new System.Windows.Forms.Padding(3);
            this.tpPflanzen.Size = new System.Drawing.Size(673, 287);
            this.tpPflanzen.TabIndex = 1;
            this.tpPflanzen.Text = "Pflanzen";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.85981F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.14019F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel2.Controls.Add(this.cmdRadieschen, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmdTomaten, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTimerRadieschen, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTimerTomate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRadies, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTomaten, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblErdbeere, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmdErdbeeren, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTimerErdbeeren, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(667, 281);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblTimerRadieschen
            // 
            this.lblTimerRadieschen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerRadieschen.AutoSize = true;
            this.lblTimerRadieschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerRadieschen.Location = new System.Drawing.Point(463, 39);
            this.lblTimerRadieschen.Name = "lblTimerRadieschen";
            this.lblTimerRadieschen.Size = new System.Drawing.Size(201, 24);
            this.lblTimerRadieschen.TabIndex = 5;
            this.lblTimerRadieschen.Text = "24:00:00";
            this.lblTimerRadieschen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimerTomate
            // 
            this.lblTimerTomate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerTomate.AutoSize = true;
            this.lblTimerTomate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerTomate.Location = new System.Drawing.Point(209, 39);
            this.lblTimerTomate.Name = "lblTimerTomate";
            this.lblTimerTomate.Size = new System.Drawing.Size(248, 24);
            this.lblTimerTomate.TabIndex = 4;
            this.lblTimerTomate.Text = "24:00:00";
            this.lblTimerTomate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRadies
            // 
            this.lblRadies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRadies.AutoSize = true;
            this.lblRadies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadies.Location = new System.Drawing.Point(463, 0);
            this.lblRadies.Name = "lblRadies";
            this.lblRadies.Size = new System.Drawing.Size(201, 24);
            this.lblRadies.TabIndex = 2;
            this.lblRadies.Text = "Radieschen";
            this.lblRadies.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTomaten
            // 
            this.lblTomaten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTomaten.AutoSize = true;
            this.lblTomaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTomaten.Location = new System.Drawing.Point(209, 0);
            this.lblTomaten.Name = "lblTomaten";
            this.lblTomaten.Size = new System.Drawing.Size(248, 24);
            this.lblTomaten.TabIndex = 1;
            this.lblTomaten.Text = "Tomaten";
            this.lblTomaten.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblErdbeere
            // 
            this.lblErdbeere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErdbeere.AutoSize = true;
            this.lblErdbeere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErdbeere.Location = new System.Drawing.Point(3, 0);
            this.lblErdbeere.Name = "lblErdbeere";
            this.lblErdbeere.Size = new System.Drawing.Size(200, 24);
            this.lblErdbeere.TabIndex = 0;
            this.lblErdbeere.Text = "Erdbeeren";
            this.lblErdbeere.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimerErdbeeren
            // 
            this.lblTimerErdbeeren.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerErdbeeren.AutoSize = true;
            this.lblTimerErdbeeren.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerErdbeeren.Location = new System.Drawing.Point(3, 39);
            this.lblTimerErdbeeren.Name = "lblTimerErdbeeren";
            this.lblTimerErdbeeren.Size = new System.Drawing.Size(200, 24);
            this.lblTimerErdbeeren.TabIndex = 3;
            this.lblTimerErdbeeren.Text = "24:00:00";
            this.lblTimerErdbeeren.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpMüll
            // 
            this.tpMüll.Location = new System.Drawing.Point(4, 34);
            this.tpMüll.Name = "tpMüll";
            this.tpMüll.Padding = new System.Windows.Forms.Padding(3);
            this.tpMüll.Size = new System.Drawing.Size(673, 287);
            this.tpMüll.TabIndex = 2;
            this.tpMüll.Text = "Müll";
            this.tpMüll.UseVisualStyleBackColor = true;
            // 
            // cmdErdbeeren
            // 
            this.cmdErdbeeren.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdErdbeeren.Location = new System.Drawing.Point(3, 87);
            this.cmdErdbeeren.Name = "cmdErdbeeren";
            this.cmdErdbeeren.Size = new System.Drawing.Size(200, 23);
            this.cmdErdbeeren.TabIndex = 6;
            this.cmdErdbeeren.Text = "Gegossen!";
            this.cmdErdbeeren.UseVisualStyleBackColor = true;
            this.cmdErdbeeren.Click += new System.EventHandler(this.cmdErdbeeren_Click);
            // 
            // cmdTomaten
            // 
            this.cmdTomaten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTomaten.Location = new System.Drawing.Point(209, 87);
            this.cmdTomaten.Name = "cmdTomaten";
            this.cmdTomaten.Size = new System.Drawing.Size(248, 23);
            this.cmdTomaten.TabIndex = 7;
            this.cmdTomaten.Text = "Gegossen!";
            this.cmdTomaten.UseVisualStyleBackColor = true;
            this.cmdTomaten.Click += new System.EventHandler(this.cmdTomaten_Click);
            // 
            // cmdRadieschen
            // 
            this.cmdRadieschen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRadieschen.Location = new System.Drawing.Point(463, 87);
            this.cmdRadieschen.Name = "cmdRadieschen";
            this.cmdRadieschen.Size = new System.Drawing.Size(201, 23);
            this.cmdRadieschen.TabIndex = 8;
            this.cmdRadieschen.Text = "Gegossen!";
            this.cmdRadieschen.UseVisualStyleBackColor = true;
            this.cmdRadieschen.Click += new System.EventHandler(this.cmdRadieschen_Click);
            // 
            // tpEinstellung
            // 
            this.tpEinstellung.Location = new System.Drawing.Point(4, 34);
            this.tpEinstellung.Name = "tpEinstellung";
            this.tpEinstellung.Padding = new System.Windows.Forms.Padding(3);
            this.tpEinstellung.Size = new System.Drawing.Size(673, 287);
            this.tpEinstellung.TabIndex = 3;
            this.tpEinstellung.Text = "Einstellung";
            this.tpEinstellung.UseVisualStyleBackColor = true;
            // 
            // frmHaupt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(685, 442);
            this.Controls.Add(this.tabGurkenhome);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblUhrzeit);
            this.Controls.Add(this.lblGurkenHome);
            this.Controls.Add(this.cmdExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(685, 442);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(685, 442);
            this.Name = "frmHaupt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GurkenHome - Automatisierung";
            this.TopMost = true;
            this.tabGurkenhome.ResumeLayout(false);
            this.tpWaesche.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpPflanzen.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label lblGurkenHome;
        private System.Windows.Forms.Label lblUhrzeit;
        private System.Windows.Forms.Timer timerUhrzeit;
        private System.Windows.Forms.Timer timerDHT;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TabControl tabGurkenhome;
        private System.Windows.Forms.TabPage tpWaesche;
        private System.Windows.Forms.TabPage tpPflanzen;
        private System.Windows.Forms.Label lblSonstige;
        private System.Windows.Forms.Label lblWindeln;
        private System.Windows.Forms.Label lblWeiße;
        private System.Windows.Forms.Label lblBunte;
        private System.Windows.Forms.Label lblSchwarze;
        private System.Windows.Forms.Label lblUnterwäsche;
        private System.Windows.Forms.Button cmdSonstige;
        private System.Windows.Forms.Button cmdWindeln;
        private System.Windows.Forms.Button cmdWeiße;
        private System.Windows.Forms.Button cmdBunte;
        private System.Windows.Forms.Button cmdSchwarze;
        private System.Windows.Forms.Button cmdUnterwäsche;
        private System.Windows.Forms.Label lblTimerUnter;
        private System.Windows.Forms.Label lblTimerWindeln;
        private System.Windows.Forms.Label lblTimerSonstige;
        private System.Windows.Forms.Label lblTimerWeiß;
        private System.Windows.Forms.Label lblTimerBunt;
        private System.Windows.Forms.Label lblTimerSchwarz;
        private System.Windows.Forms.ComboBox cbSonstige;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tpMüll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblRadies;
        private System.Windows.Forms.Label lblTomaten;
        private System.Windows.Forms.Label lblErdbeere;
        private System.Windows.Forms.Label lblTimerRadieschen;
        private System.Windows.Forms.Label lblTimerTomate;
        private System.Windows.Forms.Label lblTimerErdbeeren;
        private System.Windows.Forms.Button cmdErdbeeren;
        private System.Windows.Forms.Button cmdRadieschen;
        private System.Windows.Forms.Button cmdTomaten;
        private System.Windows.Forms.TabPage tpEinstellung;
    }
}

