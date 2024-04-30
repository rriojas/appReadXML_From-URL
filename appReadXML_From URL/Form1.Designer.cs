namespace appReadXML_From_URL
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      txtXMLData = new TextBox();
      SuspendLayout();
      // 
      // txtXMLData
      // 
      txtXMLData.Font = new Font("Segoe UI", 15F);
      txtXMLData.Location = new Point(36, 59);
      txtXMLData.Multiline = true;
      txtXMLData.Name = "txtXMLData";
      txtXMLData.ScrollBars = ScrollBars.Both;
      txtXMLData.Size = new Size(752, 379);
      txtXMLData.TabIndex = 0;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(txtXMLData);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox txtXMLData;
  }
}
