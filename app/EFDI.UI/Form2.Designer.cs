namespace EFDI.UI {
  partial class Form2 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.label2 = new System.Windows.Forms.Label();
      this.tb_Name = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tb_Price = new System.Windows.Forms.TextBox();
      this.btn_Save = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(128, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Name";
      // 
      // tb_Name
      // 
      this.tb_Name.Location = new System.Drawing.Point(60, 98);
      this.tb_Name.Name = "tb_Name";
      this.tb_Name.Size = new System.Drawing.Size(166, 20);
      this.tb_Name.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(130, 147);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Price";
      // 
      // tb_Price
      // 
      this.tb_Price.Location = new System.Drawing.Point(61, 165);
      this.tb_Price.Name = "tb_Price";
      this.tb_Price.Size = new System.Drawing.Size(166, 20);
      this.tb_Price.TabIndex = 4;
      // 
      // btn_Save
      // 
      this.btn_Save.Location = new System.Drawing.Point(105, 207);
      this.btn_Save.Name = "btn_Save";
      this.btn_Save.Size = new System.Drawing.Size(74, 27);
      this.btn_Save.TabIndex = 6;
      this.btn_Save.Text = "Save";
      this.btn_Save.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(88, 16);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(119, 24);
      this.label4.TabIndex = 7;
      this.label4.Text = "New Product";
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btn_Save);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.tb_Price);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tb_Name);
      this.Name = "Form2";
      this.Text = "Form2";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tb_Name;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tb_Price;
    private System.Windows.Forms.Button btn_Save;
    private System.Windows.Forms.Label label4;
  }
}