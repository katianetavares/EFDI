namespace EFDI.UI {
  partial class Form1 {
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
      this.lv_Main = new System.Windows.Forms.ListView();
      this.lb_Title = new System.Windows.Forms.Label();
      this.bt_Sender = new System.Windows.Forms.Button();
      this.btn_NewProduct = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lv_Main
      // 
      this.lv_Main.Location = new System.Drawing.Point(12, 45);
      this.lv_Main.Name = "lv_Main";
      this.lv_Main.Size = new System.Drawing.Size(260, 154);
      this.lv_Main.TabIndex = 0;
      this.lv_Main.UseCompatibleStateImageBehavior = false;
      // 
      // lb_Title
      // 
      this.lb_Title.AutoSize = true;
      this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lb_Title.Location = new System.Drawing.Point(36, 22);
      this.lb_Title.Name = "lb_Title";
      this.lb_Title.Size = new System.Drawing.Size(80, 20);
      this.lb_Title.TabIndex = 1;
      this.lb_Title.Text = "Products";
      // 
      // bt_Sender
      // 
      this.bt_Sender.Location = new System.Drawing.Point(103, 226);
      this.bt_Sender.Name = "bt_Sender";
      this.bt_Sender.Size = new System.Drawing.Size(75, 23);
      this.bt_Sender.TabIndex = 2;
      this.bt_Sender.Text = "View Data";
      this.bt_Sender.UseVisualStyleBackColor = true;
      // 
      // btn_NewProduct
      // 
      this.btn_NewProduct.Location = new System.Drawing.Point(174, 12);
      this.btn_NewProduct.Name = "btn_NewProduct";
      this.btn_NewProduct.Size = new System.Drawing.Size(89, 27);
      this.btn_NewProduct.TabIndex = 3;
      this.btn_NewProduct.Text = "New Product";
      this.btn_NewProduct.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.btn_NewProduct);
      this.Controls.Add(this.bt_Sender);
      this.Controls.Add(this.lb_Title);
      this.Controls.Add(this.lv_Main);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView lv_Main;
    private System.Windows.Forms.Label lb_Title;
    private System.Windows.Forms.Button bt_Sender;
    private System.Windows.Forms.Button btn_NewProduct;
  }
}

