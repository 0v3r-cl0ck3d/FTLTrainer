namespace FTLTrainerGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BaseLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SetScrapButtonHostPanel = new System.Windows.Forms.Panel();
            this.SetScrapButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ScrapValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ReactorPanelNumericHost = new System.Windows.Forms.Panel();
            this.ReactorLevelUpDown = new System.Windows.Forms.NumericUpDown();
            this.SetReactorButtonPanel = new System.Windows.Forms.Panel();
            this.SetReactorButton = new System.Windows.Forms.Button();
            this.MaxEverythingButtonHost = new System.Windows.Forms.Panel();
            this.MaxEverythingButton = new System.Windows.Forms.Button();
            this.FuelButtonHostPannel = new System.Windows.Forms.Panel();
            this.SetFuelButton = new System.Windows.Forms.Button();
            this.FuelNumericHostPannel = new System.Windows.Forms.Panel();
            this.NumericFuel = new System.Windows.Forms.NumericUpDown();
            this.AboutAndDockHost = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.Button();
            this.DockPannel = new System.Windows.Forms.Panel();
            this.DronePartsButtonHostPanel = new System.Windows.Forms.Panel();
            this.SetDronePartsButton = new System.Windows.Forms.Button();
            this.DronePartsNumericPanelHost = new System.Windows.Forms.Panel();
            this.NumericDroneParts = new System.Windows.Forms.NumericUpDown();
            this.SetMissileButtonPanelHost = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NumericMissiles = new System.Windows.Forms.NumericUpDown();
            this.NumericHpPanelHost = new System.Windows.Forms.Panel();
            this.NumeriHullHP = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SetHpButton = new System.Windows.Forms.Button();
            this.MaxHullHPPanelHost = new System.Windows.Forms.Panel();
            this.SetMaxHullButton = new System.Windows.Forms.Button();
            this.SetMaxHullHPNumericHostPanel = new System.Windows.Forms.Panel();
            this.NumericMaxHull = new System.Windows.Forms.NumericUpDown();
            this.InstaChargeFTLPanelHost = new System.Windows.Forms.Panel();
            this.InstaChargeFTLButton = new System.Windows.Forms.Button();
            this.UpdatePosTimer = new System.Windows.Forms.Timer(this.components);
            this.BaseLayoutPanel.SuspendLayout();
            this.SetScrapButtonHostPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScrapValueNumericUpDown)).BeginInit();
            this.ReactorPanelNumericHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReactorLevelUpDown)).BeginInit();
            this.SetReactorButtonPanel.SuspendLayout();
            this.MaxEverythingButtonHost.SuspendLayout();
            this.FuelButtonHostPannel.SuspendLayout();
            this.FuelNumericHostPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFuel)).BeginInit();
            this.AboutAndDockHost.SuspendLayout();
            this.DronePartsButtonHostPanel.SuspendLayout();
            this.DronePartsNumericPanelHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDroneParts)).BeginInit();
            this.SetMissileButtonPanelHost.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMissiles)).BeginInit();
            this.NumericHpPanelHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeriHullHP)).BeginInit();
            this.panel3.SuspendLayout();
            this.MaxHullHPPanelHost.SuspendLayout();
            this.SetMaxHullHPNumericHostPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaxHull)).BeginInit();
            this.InstaChargeFTLPanelHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseLayoutPanel
            // 
            this.BaseLayoutPanel.ColumnCount = 2;
            this.BaseLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BaseLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BaseLayoutPanel.Controls.Add(this.SetScrapButtonHostPanel, 0, 0);
            this.BaseLayoutPanel.Controls.Add(this.panel1, 1, 0);
            this.BaseLayoutPanel.Controls.Add(this.ReactorPanelNumericHost, 1, 1);
            this.BaseLayoutPanel.Controls.Add(this.SetReactorButtonPanel, 0, 1);
            this.BaseLayoutPanel.Controls.Add(this.MaxEverythingButtonHost, 0, 9);
            this.BaseLayoutPanel.Controls.Add(this.FuelButtonHostPannel, 0, 2);
            this.BaseLayoutPanel.Controls.Add(this.FuelNumericHostPannel, 1, 2);
            this.BaseLayoutPanel.Controls.Add(this.AboutAndDockHost, 1, 9);
            this.BaseLayoutPanel.Controls.Add(this.DronePartsButtonHostPanel, 0, 3);
            this.BaseLayoutPanel.Controls.Add(this.DronePartsNumericPanelHost, 1, 3);
            this.BaseLayoutPanel.Controls.Add(this.SetMissileButtonPanelHost, 0, 4);
            this.BaseLayoutPanel.Controls.Add(this.panel2, 1, 4);
            this.BaseLayoutPanel.Controls.Add(this.NumericHpPanelHost, 1, 5);
            this.BaseLayoutPanel.Controls.Add(this.panel3, 0, 5);
            this.BaseLayoutPanel.Controls.Add(this.MaxHullHPPanelHost, 0, 6);
            this.BaseLayoutPanel.Controls.Add(this.SetMaxHullHPNumericHostPanel, 1, 6);
            this.BaseLayoutPanel.Controls.Add(this.InstaChargeFTLPanelHost, 0, 8);
            this.BaseLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.BaseLayoutPanel.Name = "BaseLayoutPanel";
            this.BaseLayoutPanel.RowCount = 10;
            this.BaseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.BaseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.BaseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.BaseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.BaseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.BaseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.BaseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.BaseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BaseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.BaseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.BaseLayoutPanel.Size = new System.Drawing.Size(284, 261);
            this.BaseLayoutPanel.TabIndex = 0;
            // 
            // SetScrapButtonHostPanel
            // 
            this.SetScrapButtonHostPanel.Controls.Add(this.SetScrapButton);
            this.SetScrapButtonHostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetScrapButtonHostPanel.Location = new System.Drawing.Point(3, 3);
            this.SetScrapButtonHostPanel.Name = "SetScrapButtonHostPanel";
            this.SetScrapButtonHostPanel.Size = new System.Drawing.Size(136, 19);
            this.SetScrapButtonHostPanel.TabIndex = 0;
            // 
            // SetScrapButton
            // 
            this.SetScrapButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetScrapButton.Location = new System.Drawing.Point(0, 0);
            this.SetScrapButton.Name = "SetScrapButton";
            this.SetScrapButton.Size = new System.Drawing.Size(136, 19);
            this.SetScrapButton.TabIndex = 0;
            this.SetScrapButton.Text = "Set Scrap";
            this.SetScrapButton.UseVisualStyleBackColor = true;
            this.SetScrapButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ScrapValueNumericUpDown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(145, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 19);
            this.panel1.TabIndex = 1;
            // 
            // ScrapValueNumericUpDown
            // 
            this.ScrapValueNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScrapValueNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.ScrapValueNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.ScrapValueNumericUpDown.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.ScrapValueNumericUpDown.Name = "ScrapValueNumericUpDown";
            this.ScrapValueNumericUpDown.Size = new System.Drawing.Size(136, 20);
            this.ScrapValueNumericUpDown.TabIndex = 0;
            this.ScrapValueNumericUpDown.ThousandsSeparator = true;
            // 
            // ReactorPanelNumericHost
            // 
            this.ReactorPanelNumericHost.Controls.Add(this.ReactorLevelUpDown);
            this.ReactorPanelNumericHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReactorPanelNumericHost.Location = new System.Drawing.Point(145, 28);
            this.ReactorPanelNumericHost.Name = "ReactorPanelNumericHost";
            this.ReactorPanelNumericHost.Size = new System.Drawing.Size(136, 19);
            this.ReactorPanelNumericHost.TabIndex = 2;
            // 
            // ReactorLevelUpDown
            // 
            this.ReactorLevelUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReactorLevelUpDown.Location = new System.Drawing.Point(0, 0);
            this.ReactorLevelUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ReactorLevelUpDown.Name = "ReactorLevelUpDown";
            this.ReactorLevelUpDown.Size = new System.Drawing.Size(136, 20);
            this.ReactorLevelUpDown.TabIndex = 1;
            // 
            // SetReactorButtonPanel
            // 
            this.SetReactorButtonPanel.Controls.Add(this.SetReactorButton);
            this.SetReactorButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetReactorButtonPanel.Location = new System.Drawing.Point(3, 28);
            this.SetReactorButtonPanel.Name = "SetReactorButtonPanel";
            this.SetReactorButtonPanel.Size = new System.Drawing.Size(136, 19);
            this.SetReactorButtonPanel.TabIndex = 3;
            // 
            // SetReactorButton
            // 
            this.SetReactorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetReactorButton.Location = new System.Drawing.Point(0, 0);
            this.SetReactorButton.Name = "SetReactorButton";
            this.SetReactorButton.Size = new System.Drawing.Size(136, 19);
            this.SetReactorButton.TabIndex = 0;
            this.SetReactorButton.Text = "Set Reactor Level";
            this.SetReactorButton.UseVisualStyleBackColor = true;
            this.SetReactorButton.Click += new System.EventHandler(this.SetReactorButton_Click);
            // 
            // MaxEverythingButtonHost
            // 
            this.MaxEverythingButtonHost.Controls.Add(this.MaxEverythingButton);
            this.MaxEverythingButtonHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxEverythingButtonHost.Location = new System.Drawing.Point(3, 234);
            this.MaxEverythingButtonHost.Name = "MaxEverythingButtonHost";
            this.MaxEverythingButtonHost.Size = new System.Drawing.Size(136, 24);
            this.MaxEverythingButtonHost.TabIndex = 4;
            // 
            // MaxEverythingButton
            // 
            this.MaxEverythingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxEverythingButton.Location = new System.Drawing.Point(0, 0);
            this.MaxEverythingButton.Name = "MaxEverythingButton";
            this.MaxEverythingButton.Size = new System.Drawing.Size(136, 24);
            this.MaxEverythingButton.TabIndex = 0;
            this.MaxEverythingButton.Text = "Max Everything";
            this.MaxEverythingButton.UseVisualStyleBackColor = true;
            this.MaxEverythingButton.Click += new System.EventHandler(this.MaxEverythingButton_Click);
            // 
            // FuelButtonHostPannel
            // 
            this.FuelButtonHostPannel.Controls.Add(this.SetFuelButton);
            this.FuelButtonHostPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FuelButtonHostPannel.Location = new System.Drawing.Point(3, 53);
            this.FuelButtonHostPannel.Name = "FuelButtonHostPannel";
            this.FuelButtonHostPannel.Size = new System.Drawing.Size(136, 19);
            this.FuelButtonHostPannel.TabIndex = 5;
            // 
            // SetFuelButton
            // 
            this.SetFuelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetFuelButton.Location = new System.Drawing.Point(0, 0);
            this.SetFuelButton.Name = "SetFuelButton";
            this.SetFuelButton.Size = new System.Drawing.Size(136, 19);
            this.SetFuelButton.TabIndex = 0;
            this.SetFuelButton.Text = "Set FTL Fuel";
            this.SetFuelButton.UseVisualStyleBackColor = true;
            this.SetFuelButton.Click += new System.EventHandler(this.SetFuelButton_Click);
            // 
            // FuelNumericHostPannel
            // 
            this.FuelNumericHostPannel.Controls.Add(this.NumericFuel);
            this.FuelNumericHostPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FuelNumericHostPannel.Location = new System.Drawing.Point(145, 53);
            this.FuelNumericHostPannel.Name = "FuelNumericHostPannel";
            this.FuelNumericHostPannel.Size = new System.Drawing.Size(136, 19);
            this.FuelNumericHostPannel.TabIndex = 6;
            // 
            // NumericFuel
            // 
            this.NumericFuel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericFuel.Location = new System.Drawing.Point(0, 0);
            this.NumericFuel.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NumericFuel.Name = "NumericFuel";
            this.NumericFuel.Size = new System.Drawing.Size(136, 20);
            this.NumericFuel.TabIndex = 0;
            this.NumericFuel.ThousandsSeparator = true;
            // 
            // AboutAndDockHost
            // 
            this.AboutAndDockHost.Controls.Add(this.AboutButton);
            this.AboutAndDockHost.Controls.Add(this.DockPannel);
            this.AboutAndDockHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutAndDockHost.Location = new System.Drawing.Point(145, 234);
            this.AboutAndDockHost.Name = "AboutAndDockHost";
            this.AboutAndDockHost.Size = new System.Drawing.Size(136, 24);
            this.AboutAndDockHost.TabIndex = 8;
            // 
            // AboutButton
            // 
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutButton.Location = new System.Drawing.Point(0, 0);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(111, 24);
            this.AboutButton.TabIndex = 8;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // DockPannel
            // 
            this.DockPannel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DockPannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DockPannel.Location = new System.Drawing.Point(111, 0);
            this.DockPannel.Name = "DockPannel";
            this.DockPannel.Size = new System.Drawing.Size(25, 24);
            this.DockPannel.TabIndex = 7;
            this.DockPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.DockPannel_Paint);
            this.DockPannel.DoubleClick += new System.EventHandler(this.DockPannel_DoubleClick);
            // 
            // DronePartsButtonHostPanel
            // 
            this.DronePartsButtonHostPanel.Controls.Add(this.SetDronePartsButton);
            this.DronePartsButtonHostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DronePartsButtonHostPanel.Location = new System.Drawing.Point(3, 78);
            this.DronePartsButtonHostPanel.Name = "DronePartsButtonHostPanel";
            this.DronePartsButtonHostPanel.Size = new System.Drawing.Size(136, 19);
            this.DronePartsButtonHostPanel.TabIndex = 9;
            // 
            // SetDronePartsButton
            // 
            this.SetDronePartsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetDronePartsButton.Location = new System.Drawing.Point(0, 0);
            this.SetDronePartsButton.Name = "SetDronePartsButton";
            this.SetDronePartsButton.Size = new System.Drawing.Size(136, 19);
            this.SetDronePartsButton.TabIndex = 0;
            this.SetDronePartsButton.Text = "Set Drone Parts";
            this.SetDronePartsButton.UseVisualStyleBackColor = true;
            this.SetDronePartsButton.Click += new System.EventHandler(this.SetDronePartsButton_Click);
            // 
            // DronePartsNumericPanelHost
            // 
            this.DronePartsNumericPanelHost.Controls.Add(this.NumericDroneParts);
            this.DronePartsNumericPanelHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DronePartsNumericPanelHost.Location = new System.Drawing.Point(145, 78);
            this.DronePartsNumericPanelHost.Name = "DronePartsNumericPanelHost";
            this.DronePartsNumericPanelHost.Size = new System.Drawing.Size(136, 19);
            this.DronePartsNumericPanelHost.TabIndex = 10;
            // 
            // NumericDroneParts
            // 
            this.NumericDroneParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericDroneParts.Location = new System.Drawing.Point(0, 0);
            this.NumericDroneParts.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NumericDroneParts.Name = "NumericDroneParts";
            this.NumericDroneParts.Size = new System.Drawing.Size(136, 20);
            this.NumericDroneParts.TabIndex = 0;
            this.NumericDroneParts.ThousandsSeparator = true;
            // 
            // SetMissileButtonPanelHost
            // 
            this.SetMissileButtonPanelHost.Controls.Add(this.button1);
            this.SetMissileButtonPanelHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetMissileButtonPanelHost.Location = new System.Drawing.Point(3, 103);
            this.SetMissileButtonPanelHost.Name = "SetMissileButtonPanelHost";
            this.SetMissileButtonPanelHost.Size = new System.Drawing.Size(136, 19);
            this.SetMissileButtonPanelHost.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set Missiles (WIP)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NumericMissiles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(145, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 19);
            this.panel2.TabIndex = 12;
            // 
            // NumericMissiles
            // 
            this.NumericMissiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericMissiles.Location = new System.Drawing.Point(0, 0);
            this.NumericMissiles.Name = "NumericMissiles";
            this.NumericMissiles.Size = new System.Drawing.Size(136, 20);
            this.NumericMissiles.TabIndex = 0;
            // 
            // NumericHpPanelHost
            // 
            this.NumericHpPanelHost.Controls.Add(this.NumeriHullHP);
            this.NumericHpPanelHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericHpPanelHost.Location = new System.Drawing.Point(145, 128);
            this.NumericHpPanelHost.Name = "NumericHpPanelHost";
            this.NumericHpPanelHost.Size = new System.Drawing.Size(136, 19);
            this.NumericHpPanelHost.TabIndex = 13;
            // 
            // NumeriHullHP
            // 
            this.NumeriHullHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumeriHullHP.Location = new System.Drawing.Point(0, 0);
            this.NumeriHullHP.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NumeriHullHP.Name = "NumeriHullHP";
            this.NumeriHullHP.Size = new System.Drawing.Size(136, 20);
            this.NumeriHullHP.TabIndex = 0;
            this.NumeriHullHP.ThousandsSeparator = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SetHpButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 19);
            this.panel3.TabIndex = 14;
            // 
            // SetHpButton
            // 
            this.SetHpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetHpButton.Location = new System.Drawing.Point(0, 0);
            this.SetHpButton.Name = "SetHpButton";
            this.SetHpButton.Size = new System.Drawing.Size(136, 19);
            this.SetHpButton.TabIndex = 0;
            this.SetHpButton.Text = "Set Hull HP";
            this.SetHpButton.UseVisualStyleBackColor = true;
            this.SetHpButton.Click += new System.EventHandler(this.SetHpButton_Click);
            // 
            // MaxHullHPPanelHost
            // 
            this.MaxHullHPPanelHost.Controls.Add(this.SetMaxHullButton);
            this.MaxHullHPPanelHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxHullHPPanelHost.Location = new System.Drawing.Point(3, 153);
            this.MaxHullHPPanelHost.Name = "MaxHullHPPanelHost";
            this.MaxHullHPPanelHost.Size = new System.Drawing.Size(136, 19);
            this.MaxHullHPPanelHost.TabIndex = 15;
            // 
            // SetMaxHullButton
            // 
            this.SetMaxHullButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetMaxHullButton.Location = new System.Drawing.Point(0, 0);
            this.SetMaxHullButton.Name = "SetMaxHullButton";
            this.SetMaxHullButton.Size = new System.Drawing.Size(136, 19);
            this.SetMaxHullButton.TabIndex = 0;
            this.SetMaxHullButton.Text = "Set Max Hull HP Value";
            this.SetMaxHullButton.UseVisualStyleBackColor = true;
            this.SetMaxHullButton.Click += new System.EventHandler(this.SetMaxHullButton_Click);
            // 
            // SetMaxHullHPNumericHostPanel
            // 
            this.SetMaxHullHPNumericHostPanel.Controls.Add(this.NumericMaxHull);
            this.SetMaxHullHPNumericHostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetMaxHullHPNumericHostPanel.Location = new System.Drawing.Point(145, 153);
            this.SetMaxHullHPNumericHostPanel.Name = "SetMaxHullHPNumericHostPanel";
            this.SetMaxHullHPNumericHostPanel.Size = new System.Drawing.Size(136, 19);
            this.SetMaxHullHPNumericHostPanel.TabIndex = 16;
            // 
            // NumericMaxHull
            // 
            this.NumericMaxHull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericMaxHull.Location = new System.Drawing.Point(0, 0);
            this.NumericMaxHull.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NumericMaxHull.Name = "NumericMaxHull";
            this.NumericMaxHull.Size = new System.Drawing.Size(136, 20);
            this.NumericMaxHull.TabIndex = 0;
            this.NumericMaxHull.ThousandsSeparator = true;
            // 
            // InstaChargeFTLPanelHost
            // 
            this.InstaChargeFTLPanelHost.Controls.Add(this.InstaChargeFTLButton);
            this.InstaChargeFTLPanelHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstaChargeFTLPanelHost.Location = new System.Drawing.Point(3, 209);
            this.InstaChargeFTLPanelHost.Name = "InstaChargeFTLPanelHost";
            this.InstaChargeFTLPanelHost.Size = new System.Drawing.Size(136, 19);
            this.InstaChargeFTLPanelHost.TabIndex = 17;
            // 
            // InstaChargeFTLButton
            // 
            this.InstaChargeFTLButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstaChargeFTLButton.Location = new System.Drawing.Point(0, 0);
            this.InstaChargeFTLButton.Name = "InstaChargeFTLButton";
            this.InstaChargeFTLButton.Size = new System.Drawing.Size(136, 19);
            this.InstaChargeFTLButton.TabIndex = 0;
            this.InstaChargeFTLButton.Text = "Insta Charge FTL";
            this.InstaChargeFTLButton.UseVisualStyleBackColor = true;
            this.InstaChargeFTLButton.Click += new System.EventHandler(this.InstaChargeFTLButton_Click);
            // 
            // UpdatePosTimer
            // 
            this.UpdatePosTimer.Tick += new System.EventHandler(this.UpdatePosTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BaseLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BaseLayoutPanel.ResumeLayout(false);
            this.SetScrapButtonHostPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScrapValueNumericUpDown)).EndInit();
            this.ReactorPanelNumericHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReactorLevelUpDown)).EndInit();
            this.SetReactorButtonPanel.ResumeLayout(false);
            this.MaxEverythingButtonHost.ResumeLayout(false);
            this.FuelButtonHostPannel.ResumeLayout(false);
            this.FuelNumericHostPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericFuel)).EndInit();
            this.AboutAndDockHost.ResumeLayout(false);
            this.DronePartsButtonHostPanel.ResumeLayout(false);
            this.DronePartsNumericPanelHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericDroneParts)).EndInit();
            this.SetMissileButtonPanelHost.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericMissiles)).EndInit();
            this.NumericHpPanelHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumeriHullHP)).EndInit();
            this.panel3.ResumeLayout(false);
            this.MaxHullHPPanelHost.ResumeLayout(false);
            this.SetMaxHullHPNumericHostPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaxHull)).EndInit();
            this.InstaChargeFTLPanelHost.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BaseLayoutPanel;
        private System.Windows.Forms.Panel SetScrapButtonHostPanel;
        private System.Windows.Forms.Button SetScrapButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown ScrapValueNumericUpDown;
        private System.Windows.Forms.Panel ReactorPanelNumericHost;
        private System.Windows.Forms.NumericUpDown ReactorLevelUpDown;
        private System.Windows.Forms.Panel SetReactorButtonPanel;
        private System.Windows.Forms.Button SetReactorButton;
        private System.Windows.Forms.Panel MaxEverythingButtonHost;
        private System.Windows.Forms.Button MaxEverythingButton;
        private System.Windows.Forms.Panel FuelButtonHostPannel;
        private System.Windows.Forms.Button SetFuelButton;
        private System.Windows.Forms.Panel FuelNumericHostPannel;
        private System.Windows.Forms.NumericUpDown NumericFuel;
        private System.Windows.Forms.Panel DockPannel;
        private System.Windows.Forms.Timer UpdatePosTimer;
        private System.Windows.Forms.Panel AboutAndDockHost;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Panel DronePartsButtonHostPanel;
        private System.Windows.Forms.Button SetDronePartsButton;
        private System.Windows.Forms.Panel DronePartsNumericPanelHost;
        private System.Windows.Forms.NumericUpDown NumericDroneParts;
        private System.Windows.Forms.Panel SetMissileButtonPanelHost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown NumericMissiles;
        private System.Windows.Forms.Panel NumericHpPanelHost;
        private System.Windows.Forms.NumericUpDown NumeriHullHP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SetHpButton;
        private System.Windows.Forms.Panel MaxHullHPPanelHost;
        private System.Windows.Forms.Button SetMaxHullButton;
        private System.Windows.Forms.Panel SetMaxHullHPNumericHostPanel;
        private System.Windows.Forms.NumericUpDown NumericMaxHull;
        private System.Windows.Forms.Panel InstaChargeFTLPanelHost;
        private System.Windows.Forms.Button InstaChargeFTLButton;
    }
}

