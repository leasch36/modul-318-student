
namespace MyTransportApp
{
    partial class MyTransportAppForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.SearchForConnectionTabPage = new System.Windows.Forms.TabPage();
            this.ConnectionSearchMapButton = new System.Windows.Forms.Button();
            this.MailSendenButton = new System.Windows.Forms.Button();
            this.MailLabel = new System.Windows.Forms.Label();
            this.ChangeStationFieldsButton = new System.Windows.Forms.Button();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.ConnectionSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureStationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalStationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatformColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.ToComboBox = new System.Windows.Forms.ComboBox();
            this.FromComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DepartureBoardTabPage = new System.Windows.Forms.TabPage();
            this.DepartureTableDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchDepartureTabelLabel = new System.Windows.Forms.Button();
            this.DepartureTabelComboBox = new System.Windows.Forms.ComboBox();
            this.FromDepartureTabelLabel = new System.Windows.Forms.Label();
            this.MapTabPage = new System.Windows.Forms.TabPage();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.DepartureTimeDepartureTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDepartureTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategorieDepartureTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl.SuspendLayout();
            this.SearchForConnectionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionSearchDataGridView)).BeginInit();
            this.DepartureBoardTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepartureTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖV-Suche";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.SearchForConnectionTabPage);
            this.TabControl.Controls.Add(this.DepartureBoardTabPage);
            this.TabControl.Controls.Add(this.MapTabPage);
            this.TabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.ItemSize = new System.Drawing.Size(90, 25);
            this.TabControl.Location = new System.Drawing.Point(-2, 37);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(780, 324);
            this.TabControl.TabIndex = 2;
            // 
            // SearchForConnectionTabPage
            // 
            this.SearchForConnectionTabPage.BackColor = System.Drawing.Color.Azure;
            this.SearchForConnectionTabPage.Controls.Add(this.ConnectionSearchMapButton);
            this.SearchForConnectionTabPage.Controls.Add(this.MailSendenButton);
            this.SearchForConnectionTabPage.Controls.Add(this.MailLabel);
            this.SearchForConnectionTabPage.Controls.Add(this.ChangeStationFieldsButton);
            this.SearchForConnectionTabPage.Controls.Add(this.TimePicker);
            this.SearchForConnectionTabPage.Controls.Add(this.ConnectionSearchDataGridView);
            this.SearchForConnectionTabPage.Controls.Add(this.TimeLabel);
            this.SearchForConnectionTabPage.Controls.Add(this.FromLabel);
            this.SearchForConnectionTabPage.Controls.Add(this.ToLabel);
            this.SearchForConnectionTabPage.Controls.Add(this.DateLabel);
            this.SearchForConnectionTabPage.Controls.Add(this.DatePicker);
            this.SearchForConnectionTabPage.Controls.Add(this.ToComboBox);
            this.SearchForConnectionTabPage.Controls.Add(this.FromComboBox);
            this.SearchForConnectionTabPage.Controls.Add(this.SearchButton);
            this.SearchForConnectionTabPage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForConnectionTabPage.Location = new System.Drawing.Point(4, 29);
            this.SearchForConnectionTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.SearchForConnectionTabPage.Name = "SearchForConnectionTabPage";
            this.SearchForConnectionTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.SearchForConnectionTabPage.Size = new System.Drawing.Size(772, 291);
            this.SearchForConnectionTabPage.TabIndex = 0;
            this.SearchForConnectionTabPage.Text = "Verbindungssuche";
            // 
            // ConnectionSearchMapButton
            // 
            this.ConnectionSearchMapButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConnectionSearchMapButton.Location = new System.Drawing.Point(692, 19);
            this.ConnectionSearchMapButton.Name = "ConnectionSearchMapButton";
            this.ConnectionSearchMapButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectionSearchMapButton.TabIndex = 9;
            this.ConnectionSearchMapButton.Text = "Karte";
            this.ConnectionSearchMapButton.UseVisualStyleBackColor = true;
            // 
            // MailSendenButton
            // 
            this.MailSendenButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MailSendenButton.Location = new System.Drawing.Point(692, 48);
            this.MailSendenButton.Name = "MailSendenButton";
            this.MailSendenButton.Size = new System.Drawing.Size(75, 23);
            this.MailSendenButton.TabIndex = 8;
            this.MailSendenButton.Text = "senden";
            this.MailSendenButton.UseVisualStyleBackColor = true;
            this.MailSendenButton.Click += new System.EventHandler(this.MailSendenButtonClick);
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MailLabel.Location = new System.Drawing.Point(558, 53);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(128, 15);
            this.MailLabel.TabIndex = 7;
            this.MailLabel.Text = "Verbindung per E-Mail";
            // 
            // ChangeStationFieldsButton
            // 
            this.ChangeStationFieldsButton.Font = new System.Drawing.Font("Calibri", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeStationFieldsButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChangeStationFieldsButton.Location = new System.Drawing.Point(154, 19);
            this.ChangeStationFieldsButton.Name = "ChangeStationFieldsButton";
            this.ChangeStationFieldsButton.Size = new System.Drawing.Size(38, 22);
            this.ChangeStationFieldsButton.TabIndex = 6;
            this.ChangeStationFieldsButton.Text = "<-->";
            this.ChangeStationFieldsButton.UseVisualStyleBackColor = true;
            this.ChangeStationFieldsButton.Click += new System.EventHandler(this.ChangeStationFieldsButtonClick);
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "HH:mm";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(195, 48);
            this.TimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(54, 23);
            this.TimePicker.TabIndex = 5;
            // 
            // ConnectionSearchDataGridView
            // 
            this.ConnectionSearchDataGridView.AllowUserToAddRows = false;
            this.ConnectionSearchDataGridView.AllowUserToDeleteRows = false;
            this.ConnectionSearchDataGridView.AllowUserToResizeColumns = false;
            this.ConnectionSearchDataGridView.AllowUserToResizeRows = false;
            this.ConnectionSearchDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ConnectionSearchDataGridView.ColumnHeadersHeight = 21;
            this.ConnectionSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ConnectionSearchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.DepartureTimeColumn,
            this.DepartureStationColumn,
            this.ArrivalStationColumn,
            this.ArrivalTimeColumn,
            this.DurationColumn,
            this.PlatformColumn});
            this.ConnectionSearchDataGridView.Location = new System.Drawing.Point(3, 74);
            this.ConnectionSearchDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectionSearchDataGridView.Name = "ConnectionSearchDataGridView";
            this.ConnectionSearchDataGridView.ReadOnly = true;
            this.ConnectionSearchDataGridView.RowHeadersWidth = 62;
            this.ConnectionSearchDataGridView.RowTemplate.Height = 28;
            this.ConnectionSearchDataGridView.Size = new System.Drawing.Size(764, 211);
            this.ConnectionSearchDataGridView.TabIndex = 5;
            // 
            // DateColumn
            // 
            this.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateColumn.HeaderText = "Datum";
            this.DateColumn.MinimumWidth = 8;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // DepartureTimeColumn
            // 
            this.DepartureTimeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DepartureTimeColumn.HeaderText = "Abfahrtszeit";
            this.DepartureTimeColumn.MinimumWidth = 8;
            this.DepartureTimeColumn.Name = "DepartureTimeColumn";
            this.DepartureTimeColumn.ReadOnly = true;
            // 
            // DepartureStationColumn
            // 
            this.DepartureStationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DepartureStationColumn.HeaderText = "Von";
            this.DepartureStationColumn.MinimumWidth = 8;
            this.DepartureStationColumn.Name = "DepartureStationColumn";
            this.DepartureStationColumn.ReadOnly = true;
            // 
            // ArrivalStationColumn
            // 
            this.ArrivalStationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ArrivalStationColumn.HeaderText = "Nach";
            this.ArrivalStationColumn.MinimumWidth = 8;
            this.ArrivalStationColumn.Name = "ArrivalStationColumn";
            this.ArrivalStationColumn.ReadOnly = true;
            // 
            // ArrivalTimeColumn
            // 
            this.ArrivalTimeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ArrivalTimeColumn.HeaderText = "Ankunftszeit";
            this.ArrivalTimeColumn.MinimumWidth = 8;
            this.ArrivalTimeColumn.Name = "ArrivalTimeColumn";
            this.ArrivalTimeColumn.ReadOnly = true;
            // 
            // DurationColumn
            // 
            this.DurationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DurationColumn.HeaderText = "Dauer";
            this.DurationColumn.MinimumWidth = 8;
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.ReadOnly = true;
            // 
            // PlatformColumn
            // 
            this.PlatformColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PlatformColumn.HeaderText = "Platform";
            this.PlatformColumn.MinimumWidth = 8;
            this.PlatformColumn.Name = "PlatformColumn";
            this.PlatformColumn.ReadOnly = true;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TimeLabel.Location = new System.Drawing.Point(160, 50);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(32, 15);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "Zeit:";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(5, 22);
            this.FromLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(32, 15);
            this.FromLabel.TabIndex = 3;
            this.FromLabel.Text = "Von:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(197, 22);
            this.ToLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(38, 15);
            this.ToLabel.TabIndex = 4;
            this.ToLabel.Text = "Nach:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DateLabel.Location = new System.Drawing.Point(5, 50);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(48, 15);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Datum:";
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DatePicker.CalendarMonthBackground = System.Drawing.SystemColors.ControlDarkDark;
            this.DatePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DatePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DatePicker.CustomFormat = "";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(56, 48);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(94, 23);
            this.DatePicker.TabIndex = 4;
            // 
            // ToComboBox
            // 
            this.ToComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.ToComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ToComboBox.FormattingEnabled = true;
            this.ToComboBox.Location = new System.Drawing.Point(239, 18);
            this.ToComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ToComboBox.Name = "ToComboBox";
            this.ToComboBox.Size = new System.Drawing.Size(92, 23);
            this.ToComboBox.TabIndex = 2;
            // 
            // FromComboBox
            // 
            this.FromComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FromComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FromComboBox.FormattingEnabled = true;
            this.FromComboBox.Location = new System.Drawing.Point(41, 18);
            this.FromComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FromComboBox.Name = "FromComboBox";
            this.FromComboBox.Size = new System.Drawing.Size(104, 23);
            this.FromComboBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(338, 18);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(65, 22);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Suchen";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // DepartureBoardTabPage
            // 
            this.DepartureBoardTabPage.BackColor = System.Drawing.Color.Azure;
            this.DepartureBoardTabPage.Controls.Add(this.DepartureTableDataGridView);
            this.DepartureBoardTabPage.Controls.Add(this.SearchDepartureTabelLabel);
            this.DepartureBoardTabPage.Controls.Add(this.DepartureTabelComboBox);
            this.DepartureBoardTabPage.Controls.Add(this.FromDepartureTabelLabel);
            this.DepartureBoardTabPage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartureBoardTabPage.Location = new System.Drawing.Point(4, 29);
            this.DepartureBoardTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.DepartureBoardTabPage.Name = "DepartureBoardTabPage";
            this.DepartureBoardTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.DepartureBoardTabPage.Size = new System.Drawing.Size(772, 291);
            this.DepartureBoardTabPage.TabIndex = 1;
            this.DepartureBoardTabPage.Text = "Abfahrtstafel";
            // 
            // DepartureTableDataGridView
            // 
            this.DepartureTableDataGridView.AllowUserToAddRows = false;
            this.DepartureTableDataGridView.AllowUserToDeleteRows = false;
            this.DepartureTableDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DepartureTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartureTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureTimeDepartureTableColumn,
            this.ToDepartureTableColumn,
            this.KategorieDepartureTableColumn,
            this.BlankColumn});
            this.DepartureTableDataGridView.Location = new System.Drawing.Point(2, 53);
            this.DepartureTableDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DepartureTableDataGridView.Name = "DepartureTableDataGridView";
            this.DepartureTableDataGridView.ReadOnly = true;
            this.DepartureTableDataGridView.RowHeadersWidth = 62;
            this.DepartureTableDataGridView.RowTemplate.Height = 28;
            this.DepartureTableDataGridView.Size = new System.Drawing.Size(763, 254);
            this.DepartureTableDataGridView.TabIndex = 3;
            // 
            // SearchDepartureTabelLabel
            // 
            this.SearchDepartureTabelLabel.Location = new System.Drawing.Point(161, 24);
            this.SearchDepartureTabelLabel.Margin = new System.Windows.Forms.Padding(2);
            this.SearchDepartureTabelLabel.Name = "SearchDepartureTabelLabel";
            this.SearchDepartureTabelLabel.Size = new System.Drawing.Size(59, 25);
            this.SearchDepartureTabelLabel.TabIndex = 1;
            this.SearchDepartureTabelLabel.Text = "Suchen";
            this.SearchDepartureTabelLabel.UseVisualStyleBackColor = true;
            this.SearchDepartureTabelLabel.Click += new System.EventHandler(this.SearchDepartureTabelClick);
            // 
            // DepartureTabelComboBox
            // 
            this.DepartureTabelComboBox.FormattingEnabled = true;
            this.DepartureTabelComboBox.Location = new System.Drawing.Point(40, 24);
            this.DepartureTabelComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.DepartureTabelComboBox.Name = "DepartureTabelComboBox";
            this.DepartureTabelComboBox.Size = new System.Drawing.Size(107, 23);
            this.DepartureTabelComboBox.TabIndex = 0;
            // 
            // FromDepartureTabelLabel
            // 
            this.FromDepartureTabelLabel.AutoSize = true;
            this.FromDepartureTabelLabel.Location = new System.Drawing.Point(4, 29);
            this.FromDepartureTabelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FromDepartureTabelLabel.Name = "FromDepartureTabelLabel";
            this.FromDepartureTabelLabel.Size = new System.Drawing.Size(32, 15);
            this.FromDepartureTabelLabel.TabIndex = 0;
            this.FromDepartureTabelLabel.Text = "Von:";
            // 
            // MapTabPage
            // 
            this.MapTabPage.BackColor = System.Drawing.Color.Azure;
            this.MapTabPage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapTabPage.Location = new System.Drawing.Point(4, 29);
            this.MapTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.MapTabPage.Name = "MapTabPage";
            this.MapTabPage.Size = new System.Drawing.Size(772, 291);
            this.MapTabPage.TabIndex = 2;
            this.MapTabPage.Text = "Karte";
            // 
            // DepartureTimeDepartureTableColumn
            // 
            this.DepartureTimeDepartureTableColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DepartureTimeDepartureTableColumn.HeaderText = "Abfahrtszeit";
            this.DepartureTimeDepartureTableColumn.MinimumWidth = 8;
            this.DepartureTimeDepartureTableColumn.Name = "DepartureTimeDepartureTableColumn";
            this.DepartureTimeDepartureTableColumn.ReadOnly = true;
            // 
            // ToDepartureTableColumn
            // 
            this.ToDepartureTableColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ToDepartureTableColumn.HeaderText = "Nach";
            this.ToDepartureTableColumn.MinimumWidth = 8;
            this.ToDepartureTableColumn.Name = "ToDepartureTableColumn";
            this.ToDepartureTableColumn.ReadOnly = true;
            this.ToDepartureTableColumn.Width = 200;
            // 
            // KategorieDepartureTableColumn
            // 
            this.KategorieDepartureTableColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KategorieDepartureTableColumn.HeaderText = "Kategorie";
            this.KategorieDepartureTableColumn.MinimumWidth = 8;
            this.KategorieDepartureTableColumn.Name = "KategorieDepartureTableColumn";
            this.KategorieDepartureTableColumn.ReadOnly = true;
            // 
            // BlankColumn
            // 
            this.BlankColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BlankColumn.HeaderText = "";
            this.BlankColumn.Name = "BlankColumn";
            this.BlankColumn.ReadOnly = true;
            this.BlankColumn.Width = 298;
            // 
            // MyTransportAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(774, 356);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MyTransportAppForm";
            this.Text = "MyTransportApp";
            this.TabControl.ResumeLayout(false);
            this.SearchForConnectionTabPage.ResumeLayout(false);
            this.SearchForConnectionTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionSearchDataGridView)).EndInit();
            this.DepartureBoardTabPage.ResumeLayout(false);
            this.DepartureBoardTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepartureTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage SearchForConnectionTabPage;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TabPage DepartureBoardTabPage;
        private System.Windows.Forms.ComboBox DepartureTabelComboBox;
        private System.Windows.Forms.Label FromDepartureTabelLabel;
        private System.Windows.Forms.TabPage MapTabPage;
        private System.Windows.Forms.Button SearchDepartureTabelLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.ComboBox ToComboBox;
        private System.Windows.Forms.ComboBox FromComboBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DataGridView ConnectionSearchDataGridView;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.DataGridView DepartureTableDataGridView;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureStationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalStationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlatformColumn;
        private System.Windows.Forms.Button ChangeStationFieldsButton;
        private System.Windows.Forms.Button MailSendenButton;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Button ConnectionSearchMapButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTimeDepartureTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDepartureTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorieDepartureTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlankColumn;
    }
}

