
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
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.ConnectionSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureStationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalStationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.GateDepartureTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖV-Suche";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.SearchForConnectionTabPage);
            this.TabControl.Controls.Add(this.DepartureBoardTabPage);
            this.TabControl.Controls.Add(this.MapTabPage);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(12, 56);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(878, 513);
            this.TabControl.TabIndex = 2;
            // 
            // SearchForConnectionTabPage
            // 
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
            this.SearchForConnectionTabPage.Location = new System.Drawing.Point(4, 29);
            this.SearchForConnectionTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchForConnectionTabPage.Name = "SearchForConnectionTabPage";
            this.SearchForConnectionTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchForConnectionTabPage.Size = new System.Drawing.Size(870, 480);
            this.SearchForConnectionTabPage.TabIndex = 0;
            this.SearchForConnectionTabPage.Text = "Verbindungssuche";
            this.SearchForConnectionTabPage.UseVisualStyleBackColor = true;
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "HH:mm";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(290, 77);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(79, 25);
            this.TimePicker.TabIndex = 6;
            // 
            // ConnectionSearchDataGridView
            // 
            this.ConnectionSearchDataGridView.AllowUserToAddRows = false;
            this.ConnectionSearchDataGridView.AllowUserToDeleteRows = false;
            this.ConnectionSearchDataGridView.AllowUserToResizeColumns = false;
            this.ConnectionSearchDataGridView.AllowUserToResizeRows = false;
            this.ConnectionSearchDataGridView.ColumnHeadersHeight = 34;
            this.ConnectionSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ConnectionSearchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.DepartureTimeColumn,
            this.DepartureStationColumn,
            this.ArrivalStationColumn,
            this.ArrivalTimeColumn,
            this.DurationColumn,
            this.GateColumn});
            this.ConnectionSearchDataGridView.Location = new System.Drawing.Point(6, 108);
            this.ConnectionSearchDataGridView.Name = "ConnectionSearchDataGridView";
            this.ConnectionSearchDataGridView.RowHeadersWidth = 62;
            this.ConnectionSearchDataGridView.RowTemplate.Height = 28;
            this.ConnectionSearchDataGridView.Size = new System.Drawing.Size(861, 354);
            this.ConnectionSearchDataGridView.TabIndex = 5;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Datum";
            this.DateColumn.MinimumWidth = 8;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Width = 150;
            // 
            // DepartureTimeColumn
            // 
            this.DepartureTimeColumn.HeaderText = "Abfahrtszeit";
            this.DepartureTimeColumn.MinimumWidth = 8;
            this.DepartureTimeColumn.Name = "DepartureTimeColumn";
            this.DepartureTimeColumn.Width = 150;
            // 
            // DepartureStationColumn
            // 
            this.DepartureStationColumn.HeaderText = "Von";
            this.DepartureStationColumn.MinimumWidth = 8;
            this.DepartureStationColumn.Name = "DepartureStationColumn";
            this.DepartureStationColumn.Width = 150;
            // 
            // ArrivalStationColumn
            // 
            this.ArrivalStationColumn.HeaderText = "Nach";
            this.ArrivalStationColumn.MinimumWidth = 8;
            this.ArrivalStationColumn.Name = "ArrivalStationColumn";
            this.ArrivalStationColumn.Width = 150;
            // 
            // ArrivalTimeColumn
            // 
            this.ArrivalTimeColumn.HeaderText = "Ankunftszeit";
            this.ArrivalTimeColumn.MinimumWidth = 8;
            this.ArrivalTimeColumn.Name = "ArrivalTimeColumn";
            this.ArrivalTimeColumn.Width = 150;
            // 
            // DurationColumn
            // 
            this.DurationColumn.HeaderText = "Dauer";
            this.DurationColumn.MinimumWidth = 8;
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.Width = 150;
            // 
            // GateColumn
            // 
            this.GateColumn.HeaderText = "Gleis/BusNr";
            this.GateColumn.MinimumWidth = 8;
            this.GateColumn.Name = "GateColumn";
            this.GateColumn.Width = 150;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TimeLabel.Location = new System.Drawing.Point(244, 80);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(40, 20);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "Zeit:";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(15, 36);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(42, 20);
            this.FromLabel.TabIndex = 3;
            this.FromLabel.Text = "Von:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(234, 36);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(50, 20);
            this.ToLabel.TabIndex = 4;
            this.ToLabel.Text = "Nach:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DateLabel.Location = new System.Drawing.Point(8, 80);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(61, 20);
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
            this.DatePicker.Location = new System.Drawing.Point(75, 77);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(139, 25);
            this.DatePicker.TabIndex = 0;
            // 
            // ToComboBox
            // 
            this.ToComboBox.FormattingEnabled = true;
            this.ToComboBox.Location = new System.Drawing.Point(290, 30);
            this.ToComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ToComboBox.Name = "ToComboBox";
            this.ToComboBox.Size = new System.Drawing.Size(136, 28);
            this.ToComboBox.TabIndex = 0;
            // 
            // FromComboBox
            // 
            this.FromComboBox.FormattingEnabled = true;
            this.FromComboBox.Location = new System.Drawing.Point(74, 30);
            this.FromComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FromComboBox.Name = "FromComboBox";
            this.FromComboBox.Size = new System.Drawing.Size(154, 28);
            this.FromComboBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(497, 27);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 29);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Suchen";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // DepartureBoardTabPage
            // 
            this.DepartureBoardTabPage.Controls.Add(this.DepartureTableDataGridView);
            this.DepartureBoardTabPage.Controls.Add(this.SearchDepartureTabelLabel);
            this.DepartureBoardTabPage.Controls.Add(this.DepartureTabelComboBox);
            this.DepartureBoardTabPage.Controls.Add(this.FromDepartureTabelLabel);
            this.DepartureBoardTabPage.Location = new System.Drawing.Point(4, 29);
            this.DepartureBoardTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepartureBoardTabPage.Name = "DepartureBoardTabPage";
            this.DepartureBoardTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepartureBoardTabPage.Size = new System.Drawing.Size(870, 480);
            this.DepartureBoardTabPage.TabIndex = 1;
            this.DepartureBoardTabPage.Text = "Abfahrtstafel";
            this.DepartureBoardTabPage.UseVisualStyleBackColor = true;
            // 
            // DepartureTableDataGridView
            // 
            this.DepartureTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartureTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureTimeDepartureTableColumn,
            this.ToDepartureTableColumn,
            this.GateDepartureTableColumn});
            this.DepartureTableDataGridView.Location = new System.Drawing.Point(6, 82);
            this.DepartureTableDataGridView.Name = "DepartureTableDataGridView";
            this.DepartureTableDataGridView.RowHeadersWidth = 62;
            this.DepartureTableDataGridView.RowTemplate.Height = 28;
            this.DepartureTableDataGridView.Size = new System.Drawing.Size(799, 391);
            this.DepartureTableDataGridView.TabIndex = 3;
            // 
            // SearchDepartureTabelLabel
            // 
            this.SearchDepartureTabelLabel.Location = new System.Drawing.Point(247, 37);
            this.SearchDepartureTabelLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchDepartureTabelLabel.Name = "SearchDepartureTabelLabel";
            this.SearchDepartureTabelLabel.Size = new System.Drawing.Size(84, 29);
            this.SearchDepartureTabelLabel.TabIndex = 2;
            this.SearchDepartureTabelLabel.Text = "Suchen";
            this.SearchDepartureTabelLabel.UseVisualStyleBackColor = true;
            this.SearchDepartureTabelLabel.Click += new System.EventHandler(this.SearchDepartureTabelClick);
            // 
            // DepartureTabelComboBox
            // 
            this.DepartureTabelComboBox.FormattingEnabled = true;
            this.DepartureTabelComboBox.Location = new System.Drawing.Point(65, 37);
            this.DepartureTabelComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepartureTabelComboBox.Name = "DepartureTabelComboBox";
            this.DepartureTabelComboBox.Size = new System.Drawing.Size(158, 28);
            this.DepartureTabelComboBox.TabIndex = 1;
            // 
            // FromDepartureTabelLabel
            // 
            this.FromDepartureTabelLabel.AutoSize = true;
            this.FromDepartureTabelLabel.Location = new System.Drawing.Point(17, 40);
            this.FromDepartureTabelLabel.Name = "FromDepartureTabelLabel";
            this.FromDepartureTabelLabel.Size = new System.Drawing.Size(42, 20);
            this.FromDepartureTabelLabel.TabIndex = 0;
            this.FromDepartureTabelLabel.Text = "Von:";
            // 
            // MapTabPage
            // 
            this.MapTabPage.Location = new System.Drawing.Point(4, 29);
            this.MapTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MapTabPage.Name = "MapTabPage";
            this.MapTabPage.Size = new System.Drawing.Size(870, 480);
            this.MapTabPage.TabIndex = 2;
            this.MapTabPage.Text = "Karte";
            this.MapTabPage.UseVisualStyleBackColor = true;
            // 
            // DepartureTimeDepartureTableColumn
            // 
            this.DepartureTimeDepartureTableColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DepartureTimeDepartureTableColumn.HeaderText = "Abfahrtszeit";
            this.DepartureTimeDepartureTableColumn.MinimumWidth = 8;
            this.DepartureTimeDepartureTableColumn.Name = "DepartureTimeDepartureTableColumn";
            // 
            // ToDepartureTableColumn
            // 
            this.ToDepartureTableColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ToDepartureTableColumn.HeaderText = "Nach";
            this.ToDepartureTableColumn.MinimumWidth = 8;
            this.ToDepartureTableColumn.Name = "ToDepartureTableColumn";
            this.ToDepartureTableColumn.Width = 300;
            // 
            // GateDepartureTableColumn
            // 
            this.GateDepartureTableColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GateDepartureTableColumn.HeaderText = "Gleis/BusNr";
            this.GateDepartureTableColumn.MinimumWidth = 8;
            this.GateDepartureTableColumn.Name = "GateDepartureTableColumn";
            // 
            // MyTransportAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 580);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureStationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalStationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GateColumn;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTimeDepartureTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDepartureTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GateDepartureTableColumn;
    }
}

