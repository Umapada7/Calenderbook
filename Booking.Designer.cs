namespace Calender
{
    partial class Booking
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
            this.newBooking = new System.Windows.Forms.Button();
            this.showBooking = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newBooking
            // 
            this.newBooking.BackColor = System.Drawing.Color.HotPink;
            this.newBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBooking.Location = new System.Drawing.Point(180, 239);
            this.newBooking.Name = "newBooking";
            this.newBooking.Size = new System.Drawing.Size(263, 102);
            this.newBooking.TabIndex = 0;
            this.newBooking.Text = "New Booking";
            this.newBooking.UseVisualStyleBackColor = false;
            this.newBooking.Click += new System.EventHandler(this.newBooking_Click);
            // 
            // showBooking
            // 
            this.showBooking.BackColor = System.Drawing.Color.HotPink;
            this.showBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBooking.Location = new System.Drawing.Point(180, 419);
            this.showBooking.Name = "showBooking";
            this.showBooking.Size = new System.Drawing.Size(263, 102);
            this.showBooking.TabIndex = 0;
            this.showBooking.Text = "Show Booking";
            this.showBooking.UseVisualStyleBackColor = false;
            this.showBooking.Click += new System.EventHandler(this.showBooking_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(507, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose what you want to do";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(687, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showBooking);
            this.Controls.Add(this.newBooking);
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBooking;
        private System.Windows.Forms.Button showBooking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}