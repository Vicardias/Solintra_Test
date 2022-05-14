namespace Solintra_Test
{
    partial class Test_Solintra
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Delivery_Date = new System.Windows.Forms.DateTimePicker();
            this.Actual_Delivery_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Calculate_Cost = new System.Windows.Forms.Button();
            this.Cost_From_Book = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Delivery_Date
            // 
            this.Delivery_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delivery_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Delivery_Date.Location = new System.Drawing.Point(324, 57);
            this.Delivery_Date.Name = "Delivery_Date";
            this.Delivery_Date.Size = new System.Drawing.Size(246, 29);
            this.Delivery_Date.TabIndex = 0;
            // 
            // Actual_Delivery_Date
            // 
            this.Actual_Delivery_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actual_Delivery_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Actual_Delivery_Date.Location = new System.Drawing.Point(324, 109);
            this.Actual_Delivery_Date.Name = "Actual_Delivery_Date";
            this.Actual_Delivery_Date.Size = new System.Drawing.Size(246, 29);
            this.Actual_Delivery_Date.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Delivery Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Actual Delivery Date";
            // 
            // Calculate_Cost
            // 
            this.Calculate_Cost.BackColor = System.Drawing.Color.DimGray;
            this.Calculate_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate_Cost.ForeColor = System.Drawing.Color.White;
            this.Calculate_Cost.Location = new System.Drawing.Point(46, 171);
            this.Calculate_Cost.Name = "Calculate_Cost";
            this.Calculate_Cost.Size = new System.Drawing.Size(524, 39);
            this.Calculate_Cost.TabIndex = 4;
            this.Calculate_Cost.Text = "Calculate cost";
            this.Calculate_Cost.UseVisualStyleBackColor = false;
            this.Calculate_Cost.Click += new System.EventHandler(this.Calculate_Cost_Click);
            // 
            // Cost_From_Book
            // 
            this.Cost_From_Book.AutoSize = true;
            this.Cost_From_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost_From_Book.Location = new System.Drawing.Point(42, 259);
            this.Cost_From_Book.Name = "Cost_From_Book";
            this.Cost_From_Book.Size = new System.Drawing.Size(0, 24);
            this.Cost_From_Book.TabIndex = 5;
            // 
            // Test_Solintra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 359);
            this.Controls.Add(this.Cost_From_Book);
            this.Controls.Add(this.Calculate_Cost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Actual_Delivery_Date);
            this.Controls.Add(this.Delivery_Date);
            this.Name = "Test_Solintra";
            this.ShowIcon = false;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Solintra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Delivery_Date;
        private System.Windows.Forms.DateTimePicker Actual_Delivery_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calculate_Cost;
        private System.Windows.Forms.Label Cost_From_Book;
    }
}

