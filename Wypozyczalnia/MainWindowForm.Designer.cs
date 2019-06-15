namespace Wypozyczalnia
{
    partial class RentACar
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.showCarsButton = new System.Windows.Forms.Button();
            this.rentCarButton = new System.Windows.Forms.Button();
            this.takeCarButton = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.showCarsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rentCarButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.takeCarButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.calendarButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.logoutButton, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 419);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // showCarsButton
            // 
            this.showCarsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showCarsButton.Location = new System.Drawing.Point(3, 3);
            this.showCarsButton.Name = "showCarsButton";
            this.showCarsButton.Size = new System.Drawing.Size(280, 77);
            this.showCarsButton.TabIndex = 0;
            this.showCarsButton.Text = "Pokaż samochody";
            this.showCarsButton.UseVisualStyleBackColor = true;
            this.showCarsButton.Click += new System.EventHandler(this.showCarsButton_Click);
            // 
            // rentCarButton
            // 
            this.rentCarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rentCarButton.Location = new System.Drawing.Point(3, 86);
            this.rentCarButton.Name = "rentCarButton";
            this.rentCarButton.Size = new System.Drawing.Size(280, 77);
            this.rentCarButton.TabIndex = 1;
            this.rentCarButton.Text = "Wypożycz auto";
            this.rentCarButton.UseVisualStyleBackColor = true;
            // 
            // takeCarButton
            // 
            this.takeCarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.takeCarButton.Location = new System.Drawing.Point(3, 169);
            this.takeCarButton.Name = "takeCarButton";
            this.takeCarButton.Size = new System.Drawing.Size(280, 77);
            this.takeCarButton.TabIndex = 2;
            this.takeCarButton.Text = "Odbierz auto";
            this.takeCarButton.UseVisualStyleBackColor = true;
            // 
            // calendarButton
            // 
            this.calendarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarButton.Location = new System.Drawing.Point(3, 252);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(280, 77);
            this.calendarButton.TabIndex = 3;
            this.calendarButton.Text = "Terminarz";
            this.calendarButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoutButton.Location = new System.Drawing.Point(3, 335);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(280, 81);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Wyloguj";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // RentACar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 419);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RentACar";
            this.Text = "Rent a Car";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button showCarsButton;
        private System.Windows.Forms.Button rentCarButton;
        private System.Windows.Forms.Button takeCarButton;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Button logoutButton;
    }
}

